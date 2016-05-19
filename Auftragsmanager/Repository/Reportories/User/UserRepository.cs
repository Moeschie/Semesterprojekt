using Repository.Core;
using Repository.Model;
using System.Data.Entity;
using System.Linq;
using System;

namespace Repository.Persistence
{
    public class UserRepository : Repository<User>, IUserRepository
    {
    
        public UserRepository(DataContext context) : base(context)
        {
        }

        public User GetUserById(int id)
        {
            return new User();
        }

        public User GetUserWithId(int id)
        {
            throw new NotImplementedException();
        }

        public DataContext DataContext
        {
            get { return Context as DataContext; }
        }
    }
}