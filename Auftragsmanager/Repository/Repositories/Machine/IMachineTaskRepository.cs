using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Models;
using Braincase.GanttChart;


namespace Repository.Core
{
    public interface IMachineTaskRepository : IRepository<MachineTask>
    {
        void ceateTasksFromOrder(string titel, string start, string end, string orderID, Machine machine);
    }
}
