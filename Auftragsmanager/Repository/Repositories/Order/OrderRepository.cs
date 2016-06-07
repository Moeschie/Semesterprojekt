using Repository.Core;
using Repository.Models;
using System.Data.Entity;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Repository.Persistence
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        int count = 0;
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
        public string orderIDgen()
        {
            string timeString = DateTime.Now.ToString("yyyy-MM");
            count = GetAll().Count(o => o.OrderDetails.OrderNumber.StartsWith(timeString)) + 1;
            string orderID = timeString + "-" + count; 
            return orderID;
        }
    }
}