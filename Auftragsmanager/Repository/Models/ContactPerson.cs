using System;
using System.Collections.Generic;

namespace Repository.Model
{
    public class ContactPerson
    {
        public ContactPerson()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Telefon { get; set; }
        public string Fax { get; set; }
        public string Mail { get; set; }
        public Adress adress { get; set; }

        


    }
}
