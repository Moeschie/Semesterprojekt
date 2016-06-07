using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Models;

namespace Repository.Core
{
    public interface ISessionRepository : IRepository<Session>
    {
        void SetSession(User user);
        User GetSessionUser();
        bool Access(int level);

    }
}
