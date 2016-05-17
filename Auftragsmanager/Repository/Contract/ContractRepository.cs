using Repository.Core;
using Repository.Model;
using System.Data.Entity;
using System.Linq;
using System;

namespace Repository.Persistence
{
    public class ContractRepository : Repository<Contract>, IContractRepository
    {
    
        public ContractRepository(DataContext context) : base(context)
        {
        }

        public Contract GetContractById(int id)
        {
            return new Contract();
        }

        public Contract GetUserWithId(int id)
        {
            throw new NotImplementedException();
        }

        public Contract GetContractWithId(int id)
        {
            throw new NotImplementedException();
        }

        public DataContext DataContext
        {
            get { return Context as DataContext; }
        }
    }
}