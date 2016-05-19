using Repository.Core;
using Repository.Model;
using System.Data.Entity;
using System.Linq;
using System;

namespace Repository.Persistence
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository 
    {
    
        public CustomerRepository(DataContext context) : base(context)
        {
        }

        public Customer GetCustomerById(Guid id)
        {
            return new Customer();
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