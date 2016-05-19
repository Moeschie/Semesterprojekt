using Repository.Core;
using Repository.Model;
using System.Data.Entity;
using System.Linq;
using System;

namespace Repository.Persistence
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
    
        public OrderRepository(DataContext context) : base(context)
        {
        }

        public Order GetOrderById(Guid id)
        {
            return new Order();
        }

        public Order GetUserWithId(int id)
        {
            throw new NotImplementedException();
        }

        public DataContext DataContext
        {
            get { return Context as DataContext; }
        }
    }
}