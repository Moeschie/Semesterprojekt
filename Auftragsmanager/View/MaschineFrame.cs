using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Braincase.GanttChart;
namespace View
{
    public partial class MaschineFrame : Form
    {
       ProjectManager _mProject;

        public MaschineFrame()
        {
            InitializeComponent();

            _mProject = new ProjectManager();
            _mProject.Add(new Braincase.GanttChart.Task() { Name = "New Task" });
            MachineUsageChart.Init(_mProject);
        }
    }
}
