﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Model;

namespace Repository.Core
{
    public interface IContractRepository : IRepository<Contract>
    {
        Contract GetContractWithId(int id);
    }
}
