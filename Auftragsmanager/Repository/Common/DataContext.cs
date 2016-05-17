using Repository.Model;
using System.Data.Entity;

namespace Repository.Persistence
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Machine> Machines { get; set; }
        public virtual DbSet<Adress> Adresses { get; set; }
        public virtual DbSet<ContactPerson> ContactPersons { get; set; }
        public virtual DbSet<CustomerObject> CustomerObjects { get; set;  }


    }
}
