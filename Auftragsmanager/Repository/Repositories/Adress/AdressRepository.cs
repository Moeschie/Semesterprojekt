using Repository.Core;
using Repository.Models;
using System.Data.Entity;
using System.Linq;
using System;

namespace Repository.Persistence
{
    public class AdressRepository : Repository<Adress>, IAdressRepository
    {
    
        public AdressRepository(DataContext context) : base(context)
        {
        }

        public Adress GetAdressById(Guid id)
        {
            return new Adress();
        }


        public DataContext DataContext
        {
            get { return Context as DataContext; }
        }
    }
}