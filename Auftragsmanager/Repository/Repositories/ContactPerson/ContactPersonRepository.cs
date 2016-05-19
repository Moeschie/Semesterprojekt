using Repository.Core;
using Repository.Model;
using System.Data.Entity;
using System.Linq;
using System;

namespace Repository.Persistence
{
    public class ContactPersonRepository : Repository<ContactPerson>, IContactPersonRepository
    {
    
        public ContactPersonRepository(DataContext context) : base(context)
        {
        }

        public ContactPerson GetContactPersonById(Guid id)
        {
            return new ContactPerson();
        }


        public DataContext DataContext
        {
            get { return Context as DataContext; }
        }
    }
}