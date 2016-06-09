﻿using System;
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
    }
}
