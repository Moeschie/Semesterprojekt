using Repository.Core;
using Repository.Model;
using System.Data.Entity;
using System.Linq;
using System;
using System.Collections.Generic;

namespace Repository.Persistence
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        int count;
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
            //List<Order> orderList = new List<Order>();
            //orderList = GetAll().Where(n => n.Details.OrderNumber.Contains(timeString)).ToList();
            //count = orderList.Count();
            //count = GetAll().Where(o => o.Details.OrderNumber.StartsWith(timeString)).ToList().Count()+1;
            if (count < 1)
            {
                count = 1;
            }
            string orderID = timeString + "-" + count; 
            return orderID;
        }
    }
}