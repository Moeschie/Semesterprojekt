using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Model;

namespace Repository.Core
{
    public interface IUserRepository : IRepository<User>
    {
        User GetUserById(int id);
        User Login(string username, string password);
    }
}
