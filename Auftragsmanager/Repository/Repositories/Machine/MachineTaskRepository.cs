using Repository.Core;
using Repository.Models;
using System.Data.Entity;
using System.Linq;
using System;
using Braincase.GanttChart;
using System.Collections.Generic;
using System.Drawing;

namespace Repository.Persistence
{
    public class MachineTaskRepository : Repository<MachineTask>, IMachineTaskRepository
    {

        public MachineTaskRepository(DataContext context) : base(context)
        {
        }



        public DataContext DataContext
        {
            get { return Context as DataContext; }
        }
    }

}