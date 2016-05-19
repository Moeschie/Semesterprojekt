using System;
using System.Collections.Generic;

namespace Repository.Model
{
    public class ProductionActions
    {
        public ProductionActions()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string[] Value { get; set; }
        public string Insert { get; set; }
        public string InsertKind { get; set; }
        public bool Kuvert { get; set; }
        public bool Ink { get; set; }
        public bool folieren { get; set; }

        


    }
}
