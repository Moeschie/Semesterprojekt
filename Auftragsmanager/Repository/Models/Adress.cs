﻿using System;
using System.Collections.Generic;

namespace Repository.Model
{
    public class Adress
    {
        public Adress()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string POBox { get; set; }
        public string ZIP { get; set; }
        


    }
}
