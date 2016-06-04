using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Model;
using Braincase.GanttChart;
using System.Drawing;

namespace Repository.Core
{
    public interface IMachineRepository : IRepository<Machine>
    {
        bool MachineExists(string machinename);
        void CreateGantMachine(Chart usagesChart);
        Color GetColorCode();
    }
}
