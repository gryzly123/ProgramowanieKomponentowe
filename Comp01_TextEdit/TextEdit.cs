using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;

namespace Comp01_TextEdit
{
    public partial class TextEdit : Form
    {
        public TextEdit()
        {
            InitializeComponent();
            LoadPlugins();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            richTextbox.ResetText();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdOpenFile = new OpenFileDialog();
            ofdOpenFile.DefaultExt = "*.rtf";
            ofdOpenFile.Filter = "Rich Text File (rtf)|*.rtf";
            ofdOpenFile.FileOk += OnFileSelectedForOpen;
            ofdOpenFile.ShowDialog();
        }

        private void OnFileSelectedForOpen(object sender, CancelEventArgs e)
        {
            try
            {
                OpenFileDialog ofdOpenFile = (OpenFileDialog)sender;
                richTextbox.LoadFile(ofdOpenFile.FileName);
            }
            catch
            {
                MessageBox.Show("File open failed");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofdSaveFile = new SaveFileDialog();
            ofdSaveFile.FileName = "new document.rtf";
            ofdSaveFile.FileOk += OnFileSelectedForSave;
            ofdSaveFile.ShowDialog();
        }

        private void OnFileSelectedForSave(object sender, CancelEventArgs e)
        {
            try
            {
                SaveFileDialog ofdOpenFile = (SaveFileDialog)sender;
                richTextbox.SaveFile(ofdOpenFile.FileName);
            }
            catch
            {
                MessageBox.Show("File save failed");
            }
        }

        private Dictionary<string, Dictionary<string, MethodInfo>> PluginActions = new Dictionary<string, Dictionary<string, MethodInfo>>();

        private void LoadPlugins()
        {
            string[] Plugins = Directory.GetFiles(".\\dll\\", "*.dll");
            PluginActions.Clear();

            foreach (string PluginDll in Plugins)
            {
                Assembly Plugin = Assembly.LoadFrom(PluginDll);
                Dictionary<string, MethodInfo> Actions = new Dictionary<string, MethodInfo>();

                foreach (Type Class in Plugin.GetTypes())
                {
                    string VisibleName = "";
                    MethodInfo Method = null;

                    MethodInfo[] AvailableMethods = Class.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Static);
                    if (AvailableMethods.Length != 2)
                    {
                        throw new Exception("More than two member functions are not allowed");
                    }

                    foreach(MethodInfo MemberMethod in AvailableMethods)
                    {
                        if(MemberMethod.Name.Equals("RegisterWithName"))
                        {
                            VisibleName = (string)MemberMethod.Invoke(null, new object[] { });
                        }
                        else
                        {
                            Method = MemberMethod;
                        }
                    }

                    if (VisibleName.Length > 0 && Method != null) Actions.Add(VisibleName, Method);
                }

                if(Actions.Count > 0)
                {
                    PluginActions.Add(Plugin.GetName().Name, Actions);
                }
            }

            if(PluginActions.Keys.Count > 0)
            {
                dropdownPlugins.DropDownItems.Clear();
                foreach (string Plugin in PluginActions.Keys)
                {
                    ToolStripMenuItem DropItem = new ToolStripMenuItem(Plugin);
                    foreach (string Action in PluginActions[Plugin].Keys)
                    {
                        ToolStripMenuItem SubDropItem = new ToolStripMenuItem(Action);
                        SubDropItem.Click += DropItem_Click;
                        DropItem.DropDownItems.Add(SubDropItem);
                    }
                    dropdownPlugins.DropDownItems.Add(DropItem);
                }
            }
        }

        private void DropItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem DropItem = (ToolStripMenuItem)sender;
            MethodInfo ActionToInvoke = PluginActions[DropItem.OwnerItem.Text][DropItem.Text];
            char MethodSignature = ActionToInvoke.Name[0];
            switch(MethodSignature)
            {
                case 'r': //receives richtextbox, can manipulate content
                    ActionToInvoke.Invoke(null, new object[] { richTextbox });
                    break;

                case 's': //receices string with selected text, can only read content
                    if (richTextbox.SelectedText.Length == 0) richTextbox.SelectAll();
                    ActionToInvoke.Invoke(null, new object[] { richTextbox.SelectedText });
                    break;

                default:
                    throw new Exception("Unknown signature");
            }
        }
    }
}
