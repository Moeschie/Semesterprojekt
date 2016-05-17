﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Core
{
    public interface IUnit : IDisposable
    {
        IUserRepository User { get; set; }
        IContractRepository Contract { get; set; }
        int Complete();
    }
}
