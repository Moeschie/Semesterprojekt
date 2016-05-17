using System;
using System.Collections.Generic;

namespace Repository.Model
{
    public class EdvActions
    {
        public EdvActions()
        {
            // Default Constructor
        }

        public Guid Id { get; set; }
        public string[] Actions { get; set; }
        public List<Machine> Machines { get; set; }

        


    }
}
