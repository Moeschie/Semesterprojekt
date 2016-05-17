using System;
using System.Collections.Generic;

namespace Repository.Model
{
    public class Customer
    {
        public Customer()
        {
            // Default Constructor
        }

        public Guid Id { get; set; }
        public string Name { get; set; }


    }
}
