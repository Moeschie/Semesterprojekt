using Repository.Core;
using Repository.Model;
using System.Data.Entity;
using System.Linq;
using System;

namespace Repository.Persistence
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private SessionRepository session;
        public UserRepository(DataContext context) : base(context)
        {
           session  = new SessionRepository(context);
        }
        
        public User Login(string username, string password)
        {
            User user = GetAll().Where(u => u.Username == username && u.Password == password).FirstOrDefault();
            session.SetSession(user);
            return user;
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