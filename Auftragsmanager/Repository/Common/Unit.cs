using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Core;
using Repository.Model;


namespace Repository.Persistence
{
    public class Unit : IUnit
    {
        private readonly DataContext _context;

        public Unit(DataContext context)
        {
            _context = context;
            User = new UserRepository(_context);
        }

        public IUserRepository User { get; set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
