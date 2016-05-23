using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Repository.Persistence;
using System.Configuration;

namespace View
{
    public partial class FilebrowserFrame : Form
    {
        private Unit _unit;

        public FilebrowserFrame(Unit _unit)
        {
            this._unit = _unit;
            InitializeComponent();
            createFolder("test");
            onload("test");
        }
        private void createFolder(String name)
        {
            string path = @"" +ConfigurationSettings.AppSettings["Path"]+name;
            try
            {
                if (Directory.Exists(path))
                {
                    Console.WriteLine("That path exists already.");
                    return;
                }
                DirectoryInfo di = Directory.CreateDirectory(path);
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }
        }
        private void onload(String OrderID)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.SelectedPath = ConfigurationSettings.AppSettings["Path"]+ OrderID;

            FileDisplayListBox.Items.Clear();
            string[] files = Directory.GetFiles(FBD.SelectedPath);
            foreach (string file in files)
            {
                FileDisplayListBox.Items.Add(Path.GetFileName(file));
            }         
        }
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            openFile("Test");
        }

        private void FileDisplayListBox_DoubleClick(object sender, EventArgs e)
        {
            openFile("Test");
        }

        private void openFile(String OrderID)
        {
            String OpenFilePath = ConfigurationSettings.AppSettings["Path"] +OrderID+"\\" + FileDisplayListBox.SelectedItem.ToString();
            System.Diagnostics.Process.Start(OpenFilePath);
        }
    }
}
