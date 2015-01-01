using System;
using Extensibility;
using EnvDTE;
using EnvDTE80;
using GitHistoryAddIn.Model;
using System.Collections.Generic;
using Microsoft.VisualStudio.CommandBars;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace GitHistoryAddIn
{
	/// <summary>The object for implementing an Add-in.</summary>
	/// <seealso class='IDTExtensibility2' />
    public class Connect : IDTExtensibility2, IDTCommandTarget
	{
        private const string FILE_COMMAND_ID = "File";

        private EnvDTE.Window toolWindow = null;
        private List<CommandBarControl> _buttons = new List<CommandBarControl>();

        public string GetCommandId(string command, bool withProgId)
        {
            return withProgId ? string.Format("{0}.{1}", _addInInstance.ProgID, command) : command;
        }

        public Connect()
        {
        }

        #region IDTExtensibility2 implementation

        public void OnConnection(object application, ext_ConnectMode connectMode, object addInInst, ref Array custom)
        {
            _applicationObject = (DTE2)application;
            _addInInstance = (AddIn)addInInst;

            try
            {
                string ctlProgID, asmPath, guidStr;
                EnvDTE80.Windows2 toolWins;
                object objTemp = null;

                ctlProgID = "GitHistoryAddIn.View.GitHistory";
                asmPath = Assembly.GetExecutingAssembly().CodeBase;
                guidStr = "{E9C60F2B-F01B-4e3e-A551-C09C62E5F584}";

                toolWins = (Windows2)_applicationObject.Windows;
                toolWindow = toolWins.CreateToolWindow2(_addInInstance, asmPath, ctlProgID, "Git History", guidStr, ref objTemp);
                
                if (toolWindow != null)
                {
                    toolWindow.Visible = true;
                }
                
                toolWindow.Height = 500;
                toolWindow.Width = 400;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Exception: " + ex.Message);
            }
        }

        public void OnAddInsUpdate(ref Array custom)
        {
        }

        public void OnStartupComplete(ref Array custom)
        {
            AddButton("Item", FILE_COMMAND_ID, "Git History", "");
        }

        public void OnDisconnection(ext_DisconnectMode disconnectMode, ref Array custom)
        {
            _buttons.ForEach(a => a.Delete());
        }

        public void OnBeginShutdown(ref Array custom)
        {
        }

        #endregion

        private DTE2 _applicationObject;
        private AddIn _addInInstance;

        #region IDTCommandTarget implementation

        public void Exec(string CmdName, vsCommandExecOption ExecuteOption, ref object VariantIn, ref object VariantOut, ref bool Handled)
        {
            Handled = false;

            if (ExecuteOption == vsCommandExecOption.vsCommandExecOptionDoDefault)
            {
                if (CmdName.Equals(GetCommandId(FILE_COMMAND_ID, true), StringComparison.InvariantCultureIgnoreCase))
                {
                    try
                    {
                        List<SelectedFile> selectedFiles = GetSelectedFiles();

                        MessageBox.Show(selectedFiles.Count.ToString());
                        toolWindow.Visible = true;
                        selectedFiles.ForEach(x => MessageBox.Show(x.FriendlyFilePath));
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
        }

        public void QueryStatus(string CmdName, vsCommandStatusTextWanted NeededText, ref vsCommandStatus StatusOption, ref object CommandText)
        {
            if (NeededText == vsCommandStatusTextWanted.vsCommandStatusTextWantedNone)
            {
                if (CmdName.StartsWith(_addInInstance.ProgID, StringComparison.InvariantCultureIgnoreCase))
                {
                    var status = vsCommandStatus.vsCommandStatusUnsupported;

                    if (CmdName.Equals(GetCommandId(FILE_COMMAND_ID, true), StringComparison.InvariantCultureIgnoreCase))
                    {
                        status = vsCommandStatus.vsCommandStatusEnabled | vsCommandStatus.vsCommandStatusSupported;
                    }

                    StatusOption = status;
                }
            }
        }

        #endregion

        private void AddButton(string location, string buttonId, string caption, string tooltip)
        {
            Command command = null;
            CommandBarControl button;
            CommandBar commandBar;
            CommandBars commandBars;

            try
            {
                string commandName = GetCommandId(buttonId, true);
                try
                {
                    command = _applicationObject.Commands.Item(commandName);
                }
                catch { }

                if (command == null)
                {
                    command = _applicationObject.Commands.AddNamedCommand(_addInInstance, buttonId, caption, tooltip, true, 0, null, (int)(vsCommandStatus.vsCommandStatusSupported | vsCommandStatus.vsCommandStatusEnabled));
                }

                commandBars = (CommandBars)_applicationObject.CommandBars;
                commandBar = commandBars[location];
                button = (CommandBarControl)command.AddControl(commandBar, commandBar.Controls.Count + 1);
                _buttons.Add(button);

                button.Caption = caption;
                button.TooltipText = tooltip;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private List<SelectedFile> GetSelectedFiles()
        {
            List<SelectedFile> selectedFiles = new List<SelectedFile>();

            string solutionPath = Path.GetDirectoryName(_applicationObject.Solution.FullName);

            if (_applicationObject.ActiveWindow != null && _applicationObject.ActiveWindow.Project != null)
            {
                selectedFiles.Add(new SelectedFile
                {
                    FilePath = _applicationObject.ActiveWindow.Document.FullName,
                    FriendlyFilePath = GetFriendlyPath(solutionPath, _applicationObject.ActiveWindow.Document.FullName)
                });
            }
            else if (_applicationObject.SelectedItems != null)
            {
                List<SelectedItem> selectedItems = new List<SelectedItem>();
                foreach (SelectedItem item in _applicationObject.SelectedItems)
                {
                    selectedItems.Add(item);
                }

                if (selectedItems.Count > 1)
                {
                    return selectedFiles;
                }

                selectedItems.ForEach(item =>
                {
                    string path = item.ProjectItem.Properties.Item("FullPath").Value.ToString();
                    selectedFiles.Add(new SelectedFile { FilePath = path, FriendlyFilePath = GetFriendlyPath(solutionPath, path) });
                });
            }

            return selectedFiles;
        }

        private bool _publishing = false;

        private string GetFriendlyPath(string solutionPath, string filePath)
        {
            return filePath.Replace(solutionPath, "");
        }

        #region Output window

        private OutputWindowPane _outputWindow = null;

        public void WriteToOutputWindow(string format, params object[] args)
        {
            if (_outputWindow == null)
            {
                Window window = _applicationObject.Windows.Item(Constants.vsWindowKindOutput);
                OutputWindow outputWindow = (OutputWindow)window.Object;
                _outputWindow = outputWindow.OutputWindowPanes.Add("Git History");
            }

            _outputWindow.OutputString(string.Format(format, args));
            _outputWindow.OutputString(Environment.NewLine);
        }

        #endregion
    }
}