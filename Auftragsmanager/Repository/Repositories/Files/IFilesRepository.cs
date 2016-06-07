using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Models;
using Repository.Persistence;

namespace Repository.Core
{
    public interface IFilesRepository
    {
        void OpenFile(string orderID, string filename);
        void UploadFile(string orderID, string filename, string sourcePath);
        void CreateFolder(string orderID);
        void DownloadFile(string orderID, string filename);
        string[] DisplayFiles(string orderID);
        string[] DdisplayDirectories();
        void DownloadDir(string dirname);
    }
}
