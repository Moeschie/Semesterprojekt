using Repository.Core;
using Repository.Model;
using System.Data.Entity;
using System.Linq;
using System;

namespace Repository.Persistence
{
    public class UtilitiesRepository :  IUtilitiesRepository
    {
    
        public UtilitiesRepository()
        {

        }

        public int SetTaskDateTime(DateTime start, DateTime end)
        {
            return (int)((end - start).Days);

        }

 
    }
}