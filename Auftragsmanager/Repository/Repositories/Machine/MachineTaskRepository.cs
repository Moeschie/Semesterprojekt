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
        private DataContext _context;
        public MachineTaskRepository(DataContext context) : base(context)
        {
            _context = context;
        }



        public DataContext DataContext
        {
            get { return Context as DataContext; }
        }

        public void ceateTasksFromOrder(string titel, string start, string end, string orderID, Machine machine)
        {
            MachineTask task = new MachineTask();
            MachineTask duplicateTask = new MachineTask();

            if (GetAll().Where(m => m.type == orderID).Count() > 0)
            {
                duplicateTask = GetAll().Where(m => m.type == orderID).FirstOrDefault();
                Remove(duplicateTask);
            }
            task.Id = Guid.NewGuid();
            task.type = orderID;
            task.machine_Id = machine.Id;
            task.title = titel;
            task.UsageStart = start;
            task.UsageEnd = end;

            Add(task);
            _context.SaveChanges();
        }
    }

}