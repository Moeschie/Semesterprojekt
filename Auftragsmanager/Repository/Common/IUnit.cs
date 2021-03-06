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
        IMachineRepository Machine { get; set; }
        IMachineTaskRepository MachineTask { get; set; }
        IAdressRepository Adress { get; set; }
        IContactPersonRepository ContactPerson { get; set; }
        ISessionRepository Session { get; set; }
        IUtilitiesRepository Utilities { get; set; }
        IFilesRepository Files { get; set; }



        int Complete();
    }
}
