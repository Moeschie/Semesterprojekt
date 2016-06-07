using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Models;

namespace Repository.Core
{
    public interface IContactPersonRepository : IRepository<ContactPerson>
    {
        ContactPerson GetContactPersonById(Guid id);
    }
}
