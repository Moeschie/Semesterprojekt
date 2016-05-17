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

        public Machine GetMachineById(Guid id)
        {
            return new Machine();
        }

        public DataContext DataContext
        {
            get { return Context as DataContext; }
        }
    }
}