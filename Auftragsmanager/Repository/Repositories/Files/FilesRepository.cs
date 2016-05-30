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

        public void OpenFile(string orderID, string filename)
        {
                String OpenFilePath = Path.Combine(ConfigurationSettings.AppSettings["Path"], orderID, filename);
                System.Diagnostics.Process.Start(OpenFilePath);
        }
    }
}