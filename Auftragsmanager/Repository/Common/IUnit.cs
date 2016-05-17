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
        IOrderRepository Order { get; set; }
        ICustomerRepository Customer { get; set; }
        ICustomerObjectRepository CustomerObject { get; set; }
        IMachineRepository Machine { get; set; }
        IAdressRepository Adress { get; set; }
        IContactPersonRepository ContactPerson { get; set; }
        IEdvActionsRepository EdvActions { get; set; }
        int Complete();
    }
}
