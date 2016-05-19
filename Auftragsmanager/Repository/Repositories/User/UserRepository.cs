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
        
        public bool LoginState()
        {
            return true;
        } 

        public User Login(string username, string password)
        {
            return GetAll().Where(u => u.Username == username && u.Password == password).FirstOrDefault();       
        }

        public DataContext DataContext
        {
            get { return Context as DataContext; }
        }
    }
}