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

        public Order GetOrderById(string orderID)
        {
            string[] substring = orderID.Split('|');
            orderID = substring[0].Replace(" ", string.Empty);
            return GetAll().Where(u => u.OrderDetails.OrderNumber == orderID).First();

        }

        public List<Order> GetAllByGroup()
        {
            List<Order> GroupOrders = new List<Order>();

            var Groups = GetAll().GroupBy(w => w.OrderDetails.OrderNumber)
            .Select(g => new
            {
                keyword = g.Key,
                RecordIDs = g.Select(c => c.Id)
            }).ToList();

            foreach(var i in Groups)
            {
                Debug.WriteLine(i.keyword);
                foreach(var n in i.RecordIDs.ToList())
                {
                    Order nO = GetAll().Where(u => u.Id ==  n).Last();
                    bool test = false;
                    foreach(var go in GroupOrders)
                    {
                        if (go.OrderDetails.OrderNumber == nO.OrderDetails.OrderNumber)
                            test = true;
                    }
                    if(!test)
                        GroupOrders.Add(nO);
                }
            }


            return GroupOrders;
        }
    }
}