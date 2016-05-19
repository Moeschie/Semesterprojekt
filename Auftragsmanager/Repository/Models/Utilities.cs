using System;
using System.Collections.Generic;

namespace Repository.Model
{
    public class Utilities
    {
        public Utilities()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }


    }
}
