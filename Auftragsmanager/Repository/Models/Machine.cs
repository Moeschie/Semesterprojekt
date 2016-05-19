using System;
using System.Collections.Generic;

namespace Repository.Model
{
    public class Machine
    {
        public Machine()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime UsageStart { get; set; }
        public DateTime UsageEnd { get; set; }
        


    }
}
