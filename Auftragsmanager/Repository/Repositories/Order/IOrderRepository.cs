using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Models;

namespace Repository.Core
{
    public interface IOrderRepository : IRepository<Order>
    {
        Order GetOrderById(Guid id);
        string orderIDgen();
        Order GetOrderById(string orderID);
        List<Order> GetAllByGroup();
        void PrintOrder(string orderID, bool type);
        bool Occupied(string orderID);
        void SetOccupied(string orderID);
        string SplitOrderID(string orderID);
    }
}
