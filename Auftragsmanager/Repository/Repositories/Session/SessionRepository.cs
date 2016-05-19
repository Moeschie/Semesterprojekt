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

        private Session _session;

        private int AccessLevel;
        private string Username;
        private string Name;
        private string LastName;

        public void SetSession(User usr)
        {
            if (_session == null)
            {
                _session.User = usr;
                Username = usr.Username;
                LastName = usr.LastName;
                AccessLevel = usr.AccessLevel;
                Name = usr.Name;
            }
        }

        public int GetAccessLevel()
        {
            return AccessLevel;
        }

        public DataContext DataContext
        {
            get { return Context as DataContext; }
        }
    }
}