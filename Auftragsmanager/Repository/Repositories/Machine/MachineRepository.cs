using Repository.Core;
using Repository.Model;
using System.Data.Entity;
using System.Linq;
using System;

namespace Repository.Persistence
{
    public class MachineRepository : Repository<Machine>, IMachineRepository
    {
    
        public MachineRepository(DataContext context) : base(context)
        {
        }


        public bool MachineExists(string machinename)
        {
            bool exists = false;
            Machine machine = GetAll().Where(m => m.Name == machinename).FirstOrDefault();

            if (machine != null)
                exists = true;

            return exists;
        }

        public DataContext DataContext
        {
            get { return Context as DataContext; }
        }
    }
}