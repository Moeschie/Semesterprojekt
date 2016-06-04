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
        public string Object { get; set; }
        public Customer Customer { get; set; } 
        public int OverallQuantity { get; set; }
        public string Foreign { get; set; }
        public Adress RemainsToo { get; set; }
        public string SplitForeinLand { get; set; }
        public string SplitHomeLand { get; set; }
        public string AdditionalInformation { get; set; }
        public string BillTo { get; set; }
        public string Material { get; set; }
        public string IncomeDate { get; set; }
        public string IncomeTime { get; set; }
        public string Deadline { get; set; }
        public string OrderEdition { get; set; }
        public string OrderName { get; set; }
        public string OrderNumber { get; set; }

    }
}
