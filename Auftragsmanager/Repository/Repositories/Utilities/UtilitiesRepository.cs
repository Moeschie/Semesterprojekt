using Repository.Core;
using Repository.Models;
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
    }
}