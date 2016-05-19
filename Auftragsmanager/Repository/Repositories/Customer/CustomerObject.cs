using System;
using System.Collections.Generic;

namespace Repository.Model
{
    public class CustomerObject
    {
        public CustomerObject()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }


    }
}
