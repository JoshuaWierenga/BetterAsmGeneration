#nullable enable
using System;
using System.ComponentModel.Design;
using System.Threading.Tasks;
using EnvDTE;
using Microsoft.VisualStudio.Shell;
using TextSelection = EnvDTE.TextSelection;

namespace InlineAssembly.SyntaxHighlighting
{
    /// <summary>
    /// Command handler
    /// </summary>
    internal sealed class SwitchExtensionCommand
    {
        /// <summary>
        /// Command ID.
        /// </summary>
        private const int CommandId = 0x0100;

        /// <summary>
        /// Command menu group (command set GUID).
        /// </summary>
        private static readonly Guid CommandSet = new("6aa688e9-69ce-4c3c-aa7d-54f2312eaed3");

        /// <summary>
        /// VS Package that provides this command, not null.
        /// </summary>
        private readonly AsyncPackage _package;

        /// <summary>
        /// Initializes a new instance of the <see cref="SwitchExtensionCommand"/> class.
        /// Adds our command handlers for menu (commands must exist in the command table file)
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        /// <param name="commandService">Command service to add command to, not null.</param>
        private SwitchExtensionCommand(AsyncPackage package, OleMenuCommandService? commandService)
        {
            _package = package ?? throw new ArgumentNullException(nameof(package));
            commandService = commandService ?? throw new ArgumentNullException(nameof(commandService));

            CommandID menuCommandId = new(CommandSet, CommandId);
            MenuCommand menuItem = new(SwitchExtension, menuCommandId);
            commandService.AddCommand(menuItem);
        }

        /// <summary>
        /// Gets the instance of the command.
        /// </summary>
        private static SwitchExtensionCommand? Instance
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the service provider from the owner package.
        /// </summary>
        private IAsyncServiceProvider ServiceProvider => _package;

        /// <summary>
        /// Initializes the singleton instance of the command.
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        public static async Task InitializeAsync(AsyncPackage package)
        {
            // Switch to the main thread - the call to AddCommand in SwitchExtensionCommand's constructor requires
            // the UI thread.
            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(package.DisposalToken);

            OleMenuCommandService? commandService = await package.GetServiceAsync(typeof(IMenuCommandService)) as OleMenuCommandService;
            Instance = new SwitchExtensionCommand(package, commandService);
        }

        private void SwitchExtension(object sender, EventArgs e)
        {
            ThreadHelper.ThrowIfNotOnUIThread();
            _ = _package.JoinableTaskFactory.RunAsync(async () =>
            {
                await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();

                DTE? dte = await GetDTEAsync();
                if (dte?.ActiveWindow.Selection is not TextSelection ts)
                {
                    return;
                }

                int tsCurrentLine = ts.CurrentLine;
                int tsCurrentColumn = ts.CurrentColumn;
                string currentFileName = dte.ActiveWindow.Document.FullName;
                string newFileName;

                if (currentFileName.EndsWith(".csasm"))
                {
                    newFileName = currentFileName.Substring(0, currentFileName.Length - 6);
                }
                else if (currentFileName.EndsWith(".cs"))
                {
                    newFileName = currentFileName + ".csasm";
                }
                else
                {
                    return;
                }

                dte.ActiveWindow.Document.ProjectItem.Save(newFileName);
                dte.ActiveWindow.Document.ProjectItem.Delete();
                dte.ItemOperations.OpenFile(newFileName);

                if (dte.ActiveWindow.Selection is not TextSelection newTs)
                {
                    return;
                }

                newTs.MoveTo(tsCurrentLine, tsCurrentColumn);

                /*CodeElement? elem = ts.ActivePoint.CodeElement[vsCMElement.vsCMElementFunction];
                if (elem == null)
                {
                    return;
                }

                MessageBox.Show(elem.FullName);*/
            });
        }

        private async Task<DTE?> GetDTEAsync()
        {
            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();

            object? dteAsync = await ServiceProvider.GetServiceAsync(typeof(DTE));
            return dteAsync as DTE;
        }

        // TODO Use or remove
        // Based on https://stackoverflow.com/a/45823780
        /*private async Task<IWpfTextView?> GetTextViewAsync()
        {
            object? textManagerAsync = await ServiceProvider.GetServiceAsync(typeof(SVsTextManager));
            if (textManagerAsync is not IVsTextManager textManager)
            {
                return null;
            }

            object? componentModelAsync = await ServiceProvider.GetServiceAsync(typeof(SComponentModel));
            if (componentModelAsync is not IComponentModel componentModel)
            {
                return null;
            }

            IVsEditorAdaptersFactoryService? editorAdaptersFactoryServiceAsync =
                componentModel.GetService<IVsEditorAdaptersFactoryService>();
            if (editorAdaptersFactoryServiceAsync is not { })
            {
                return null;
            }

            textManager.GetActiveView(1, null, out IVsTextView textView);
            return editorAdaptersFactoryServiceAsync.GetWpfTextView(textView);
        }*/
    }
}
