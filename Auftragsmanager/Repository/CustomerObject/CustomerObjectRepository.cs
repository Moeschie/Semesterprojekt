using Repository.Core;
using Repository.Model;
using System.Data.Entity;
using System.Linq;
using System;

namespace Repository.Persistence
{
    public class CustomerObjectRepository : Repository<CustomerObject>, ICustomerObjectRepository
    {
    
        public CustomerObjectRepository(DataContext context) : base(context)
        {
        }

        public CustomerObject GetCustomerObjectById(Guid id)
        {
            return new CustomerObject();
        }

        public void GetUserWithId()
        {
            throw new NotImplementedException();
        }

        public DataContext DataContext
        {
            get { return Context as DataContext; }
        }
    }
}