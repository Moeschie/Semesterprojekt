using Repository.Core;
using Repository.Model;
using System.Data.Entity;
using System.Linq;
using System;

namespace Repository.Persistence
{
    public class EdvActionsRepository : Repository<EdvActions>, IEdvActionsRepository
    {
    
        public EdvActionsRepository(DataContext context) : base(context)
        {
        }

        public EdvActions GetEdvActionsById(Guid id)
        {
            return new EdvActions();
        }


        public DataContext DataContext
        {
            get { return Context as DataContext; }
        }
    }
}