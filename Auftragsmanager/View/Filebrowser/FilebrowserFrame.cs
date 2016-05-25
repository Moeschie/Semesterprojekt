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
            displayFiles("test","");
        }
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            openFile("Test");
        }

        private void FileDisplayListBox_DoubleClick(object sender, EventArgs e)
        {
            openFile("Test");
        }
        private void FileUploadButton_Click(object sender, EventArgs e)
        {
            uploadFile("test");
        }

        private void FileDownloadButton_Click(object sender, EventArgs e)
        {
            downloadFile("test");
        }
        private void FileSearchFilterInput_KeyUp(object sender, KeyEventArgs e)
        {
            displayFiles("test", FileSearchFilterInput.Text);

        }
        private void createFolder(String OrderID)
        {
            string path = Path.Combine(ConfigurationSettings.AppSettings["Path"], OrderID);
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
        private void displayFiles(String OrderID,String Filter)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.SelectedPath = Path.Combine(ConfigurationSettings.AppSettings["Path"],OrderID);
            FileDisplayListBox.Items.Clear();
            string[] files = Directory.GetFiles(FBD.SelectedPath);
            foreach (string file in files)
            {
                if (file.Contains(Filter))
                {
                    FileDisplayListBox.Items.Add(Path.GetFileName(file));
                }
            }         
        }

        private void openFile(String OrderID)
        {
            if (FileDisplayListBox.SelectedItem != null)
            {
                String OpenFilePath = Path.Combine(ConfigurationSettings.AppSettings["Path"], OrderID, FileDisplayListBox.SelectedItem.ToString());
                System.Diagnostics.Process.Start(OpenFilePath);
            } else
            {
                MessageBox.Show("Es muss erst eine Datei ausgewählt werden.", @"Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uploadFile(String OrderID)
        {
            String DestinationPath = "";
            String SourcePath = "";
            FileDialog.InitialDirectory=("C:\\");
            if (FileDialog.ShowDialog(this) == DialogResult.OK)
            {
                DestinationPath = Path.Combine(ConfigurationSettings.AppSettings["Path"],OrderID,Path.GetFileName(FileDialog.FileName));
                SourcePath = FileDialog.FileName;
                File.Copy(SourcePath, DestinationPath);
            }
            displayFiles(OrderID,"");
        }
        private void downloadFile(String OrderID)
        {
            string pathUser = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            if (FileDisplayListBox.SelectedItem != null)
            {
                String SourcePath = Path.Combine(ConfigurationSettings.AppSettings["Path"],OrderID,FileDisplayListBox.SelectedItem.ToString());
                string DestinationPath = Path.Combine(pathUser, "Downloads", FileDisplayListBox.SelectedItem.ToString());
                File.Copy(SourcePath, DestinationPath);
            }
            else
            {
                MessageBox.Show("Es muss erst eine Datei ausgewählt werden.", @"Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
