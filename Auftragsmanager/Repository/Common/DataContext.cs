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
        public  virtual DbSet<Contract> Contracts { get; set; }

    }
}
