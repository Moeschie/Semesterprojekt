using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Repository.Model
{
    public class Session
    {

        public Session()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
        public User User { get; set; }
        public DateTime SessionStart {get; set;}
        public DateTime SessionEnd { get; set; }

    }
}
