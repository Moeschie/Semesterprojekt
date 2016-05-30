using Repository.Core;
using Repository.Model;
using System.Data.Entity;
using System.Linq;
using System;
using System.Windows.Forms;
using Repository.Persistence.Utilities;
using System.IO;
using System.Configuration;

namespace Repository.Persistence
{
    public class FilesRepository : IFilesRepository
    {
    
        public FilesRepository()
        {

        }

        public void CreateFolder(string orderID)
        {
            string path = Path.Combine(ConfigurationSettings.AppSettings["Path"], orderID);
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

        public string[] DdisplayDirectories()
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.SelectedPath = ConfigurationSettings.AppSettings["Path"];
            string[] directories = Directory.GetDirectories(FBD.SelectedPath);
            return directories;
        }

        public string[] DisplayFiles(string orderID)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.SelectedPath = Path.Combine(ConfigurationSettings.AppSettings["Path"], orderID);
            string[] files = Directory.GetFiles(FBD.SelectedPath);
            return files;
        }

        public void DownloadFile(string orderID, string filename)
        {
            string pathUser = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string SourcePath = Path.Combine(ConfigurationSettings.AppSettings["Path"], orderID, filename);
            string DestinationPath = Path.Combine(pathUser, "Downloads", filename);
            File.Copy(SourcePath, DestinationPath);
        }

        public void OpenFile(string orderID, string filename)
        {
                System.Diagnostics.Process.Start(Path.Combine(ConfigurationSettings.AppSettings["Path"], orderID, filename));
        }

        public void UploadFile(string orderID,String filename, String sourcePath)
        {
            string destinationPath = Path.Combine(ConfigurationSettings.AppSettings["Path"], orderID, filename);
            File.Copy(sourcePath, destinationPath);
        }
    }
}