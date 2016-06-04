using System;
using System.Collections.Generic;

namespace Repository.Model
{
    public class Order
    {
        public Order()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public OrderDetails Details { get; set; }
        public EdvActions EdvActions { get; set; }
        public ProductionActions ProductionActions { get; set; }



    }
}
