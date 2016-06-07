using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Models;

namespace Repository.Core
{
    public interface IUserRepository : IRepository<User>
    {
        User Login(string username, string password);
        int GetAccessLevelByName(string v);
        bool CheckUserExists(string username);
    }
}
