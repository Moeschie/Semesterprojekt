﻿using System;
using System.Collections.Generic;

namespace Repository.Model
{
    public class Customer
    {
        public Customer()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }


    }
}
