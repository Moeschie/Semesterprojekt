using System;
using System.Collections.Generic;

namespace Repository.Model
{
    public class OrderDetails
    {
        public OrderDetails()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public User Editor { get; set; }
        public int OVerallQuantity { get; set; }
         
        public Adress RemainsToo { get; set; }
        public string SplitForeinLand { get; set; }
        public string SplitHomeLand { get; set; }
        


    }
}
