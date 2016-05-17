using System.Collections.Generic;
using System;

namespace Repository.Model
{
    public class User
    {
        public User()
        {
            // Default Constructor
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public int AccessLevel { get; set; }


    }
}
