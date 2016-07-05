using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Core;
using Repository.Models;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;

namespace Repository.Persistence
{
    public class Unit : IUnit
    {
        private readonly DataContext _context;

        public Unit(DataContext context)
        {
            _context = context;
            User = new UserRepository(_context);
            Order = new OrderRepository(_context);
            Customer = new CustomerRepository(_context);
            Machine = new MachineRepository(_context);
            MachineTask = new MachineTaskRepository(_context);
            Adress = new AdressRepository(_context);
            ContactPerson = new ContactPersonRepository(_context);
            Session = new SessionRepository(_context);
            Utilities = new UtilitiesRepository();
            Files = new FilesRepository();
        }

        public IUserRepository User { get; set; }
        public IOrderRepository Order { get; set; }
        public ICustomerRepository Customer { get; set; }
        public IMachineRepository Machine { get; set; }
        public IMachineTaskRepository MachineTask { get; set; }

        public IAdressRepository Adress { get; set;  }
        public IContactPersonRepository ContactPerson { get; set; }
        public ISessionRepository Session { get; set; }
        public IUtilitiesRepository Utilities { get; set; }
        public IFilesRepository Files { get; set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void RefreshAll()
        {
            foreach (var entity in _context.ChangeTracker.Entries()) entity.Reload();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
