using Repository.Core;
using Repository.Model;
using System.Data.Entity;
using System.Linq;
using System;
using System.Windows.Forms;
using Repository.Persistence.Utilities;

namespace Repository.Persistence
{
    public class UtilitiesRepository :  IUtilitiesRepository
    {
    
        public UtilitiesRepository()
        {

        }

        public FormValidation FormValidation()
        {
            return new FormValidation();
        }

        public int SetTaskDateTime(DateTime start, DateTime end)
        {
            return (int)((end - start).Days);

        }


 
    }
}