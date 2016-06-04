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
        public string UsageStart { get; set; }
        public string UsageEnd { get; set; }
        public string title { get; set; }
        public string type { get; set; }     
    }
}
