using Repository.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Repository.Persistence
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.AutoDetectChangesEnabled = true;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Machine> Machines { get; set; }
        public virtual DbSet<MachineTask> MachineTasks { get; set; }
        public virtual DbSet<Adress> Adresses { get; set; }
        public virtual DbSet<ContactPerson> ContactPersons { get; set; }
        public virtual DbSet<CustomerObject> CustomerObjects { get; set;  }
        public virtual DbSet<EdvActions> EdvsActions { get; set; }

    }
}
