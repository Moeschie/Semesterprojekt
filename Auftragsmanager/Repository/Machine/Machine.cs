using System;
using System.Collections.Generic;

namespace Repository.Model
{
    public class Machine
    {
        public Machine()
        {
            // Default Constructor
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime UsageStart { get; set; }
        public DateTime UsageEnd { get; set; }
        


    }
}
