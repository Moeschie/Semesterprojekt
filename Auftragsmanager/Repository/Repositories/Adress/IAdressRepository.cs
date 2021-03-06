﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Models;

namespace Repository.Core
{
    public interface IAdressRepository : IRepository<Adress>
    {
        Adress GetAdressById(Guid id);
    }
}
