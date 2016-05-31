using System;
using System.Collections.Generic;

namespace Repository.Model
{
    public class MachineTask
    {
        public MachineTask()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public Machine machine { get; set; }
        public DateTime UsageStart { get; set; }
        public DateTime UsageEnd { get; set; }
        public string title { get; set; }
        public string type { get; set; }     
    }
}
