using Repository.Core;
using Repository.Model;
using System.Data.Entity;
using System.Linq;
using System;
using System.Windows.Forms;
using Repository.Persistence.Utilities;
using System.IO;
using System.Configuration;
using System.Collections.Generic;

namespace Repository.Persistence
{
    public class FilesRepository : IFilesRepository
    {

        private string pathUser;

    
        public FilesRepository()
        {
            pathUser = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

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

        public void DownloadDir(string dirname)
        {
            DirectoryInfo dir = new DirectoryInfo(Path.Combine(ConfigurationSettings.AppSettings["Path"], dirname));
            Console.WriteLine(dir);
            List<string> path = new List<string>();
            path.Add(pathUser);
            path.Add("Downloads");
            path.Add(dirname);
            Directory.CreateDirectory(GetDestination(path));
        }


        public void DownloadFile(string orderID, string filename)
        {
            string SourcePath = Path.Combine(ConfigurationSettings.AppSettings["Path"], orderID, filename);

            List<string> path = new List<string>();
            path.Add(pathUser);
            path.Add("Downloads");
            path.Add(filename);        
            File.Copy(SourcePath, GetDestination(path));
        }

        private string GetDestination(List<string> path)
        {
            bool free = true;
            int fileCount = 1;
            string DestinationPath = Path.Combine(path[0], path[1], path[2]);
            if (File.Exists(DestinationPath))
            {
                if (!File.Exists(Path.Combine(path[0], path[1], "Kopie - " + path[2])))
                {
                    while (free)
                    {
                        if (!File.Exists(Path.Combine(path[0], path[1], "Kopie(" + fileCount + ") - " + path[2])))
                        {
                            path[2] = "Kopie(" + fileCount + ") - " + path[2];
                            free = !free;
                        }
                        fileCount++;
                    }
                }
                else
                {
                    path[2] = "Kopie - " + path[2];
                }
                DestinationPath = Path.Combine(path[0], path[1], path[2]);
            }
            return DestinationPath;
        }

        public void OpenFile(string orderID, string filename)
        {
                System.Diagnostics.Process.Start(Path.Combine(ConfigurationSettings.AppSettings["Path"], orderID, filename));
        }

        public void UploadFile(string orderID,String filename, String sourcePath)
        {

            List<string> path = new List<string>();
            path.Add(ConfigurationSettings.AppSettings["Path"]);
            path.Add(orderID);
            path.Add(filename);

            File.Copy(sourcePath, GetDestination(path));
        }
    }
}