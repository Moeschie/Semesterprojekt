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
        
        public User Login(string username, string password)
        {
            User user = GetAll().Where(u => u.Username == username && u.Password == password).FirstOrDefault();

            return user;

            //return GetAll().Where(u => u.Username == username && u.Password == password).FirstOrDefault();       
        }

        public int GetAccessLevelByName(string name)
        {
            return GetAll().Where(u => u.Username == name).FirstOrDefault().AccessLevel;
        }

        public DataContext DataContext
        {
            get { return Context as DataContext; }
        }
    }
}