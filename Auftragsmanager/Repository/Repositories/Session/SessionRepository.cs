using Repository.Core;
using Repository.Model;
using System.Data.Entity;
using System.Linq;
using System;

namespace Repository.Persistence
{
    public class SessionRepository : Repository<Session>, ISessionRepository
    {


        public SessionRepository(DataContext context) : base(context)
        {
            
        }

        private static User _session;

        public void SetSession(User usr)
        {
            if (_session == null)
                _session = usr;
            
        }

        public User GetSessionUser()
        {
            return _session;
        }

        public bool Access(int Level)
        {
            if (_session.AccessLevel >= Level) return true;
            return false;
        }

        public DataContext DataContext
        {
            get { return Context as DataContext; }
        }
    }
}