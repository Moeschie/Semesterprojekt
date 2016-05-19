using Repository.Core;
using Repository.Model;
using System.Data.Entity;
using System.Linq;
using System;

namespace Repository.Persistence
{
    public class UtilitiesRepository : Repository<Utilities>, IUtilitiesRepository
    {
    
        public UtilitiesRepository(DataContext context) : base(context)
        {
        }

        public Utilities GetAdressById(Guid id)
        {
            return new Utilities();
        }

        public int SetTaskDateTime(DateTime start, DateTime end)
        {
            return (int)((end - start).Days);

        }

        public DataContext DataContext
        {
            get { return Context as DataContext; }
        }
    }
}