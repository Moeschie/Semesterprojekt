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
using Repository.Persistence;

namespace View
{
    public partial class MaschineFrame : Form
    {
        ProjectManager GanttContent;
        Unit _unit;

        public MaschineFrame(Unit unit)
        {
            _unit = unit;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            GanttContent = new ProjectManager();

            DateTime StartMaschine = new DateTime(2016, 1,1);
            DateTime EndMachine = new DateTime(2016, 12, 12);
            DateTime StartWorkorder = new DateTime(2016, 5, 25);
            DateTime EndWorkOrder = new DateTime(2016, 8, 7);
            DateTime DateTimeNow = DateTime.Now;


            //CREATE MACHINE/AUFTRAG
            var Machine_1 = new MyTask(GanttContent) { Name = "Maschine 1" };
            GanttContent.Add(Machine_1);
            //CONNECT TOOLTIP TOO MACHINE/AUFTRAG
            var Machine_1ToolTip = new MyResource() { Name = "Maschine 1" };
            GanttContent.Assign(Machine_1, Machine_1ToolTip);

            var Auftrag_1 = new MyTask(GanttContent) { Name = "Auftrag 1" };
            GanttContent.Add(Auftrag_1);

            var Auftrag_1ToolTip = new MyResource() { Name = "Auftrag 1" };
            GanttContent.Assign(Auftrag_1, Auftrag_1ToolTip);

            GanttContent.SetDuration(Machine_1, _unit.Utilities.SetTaskDateTime(StartMaschine, EndMachine));
            GanttContent.SetStart(Machine_1, _unit.Utilities.SetTaskDateTime(DateTimeNow, StartMaschine));
            GanttContent.SetEnd(Machine_1, _unit.Utilities.SetTaskDateTime(DateTimeNow, EndMachine));

            GanttContent.SetDuration(Auftrag_1, _unit.Utilities.SetTaskDateTime(StartWorkorder, EndWorkOrder));
            GanttContent.SetStart(Auftrag_1, _unit.Utilities.SetTaskDateTime(DateTimeNow, StartWorkorder)-10);
            GanttContent.SetEnd(Auftrag_1, _unit.Utilities.SetTaskDateTime(DateTimeNow, EndWorkOrder));

            //COMPLETION PROGRESS
            Auftrag_1.Complete = (_unit.Utilities.SetTaskDateTime(StartMaschine,DateTimeNow)/100F);

            //CONNECT AUFTRAG 1 TOO MACHINE 1
            GanttContent.Group(Machine_1, Auftrag_1);

            MachineUsageChart.Init(GanttContent);
            MachineUsageChart.CreateTaskDelegate = delegate () { return new MyTask(GanttContent); };



            // TOOLTIP MACHINE
            MachineUsageChart.SetToolTip(Machine_1, string.Join(", ", GanttContent.ResourcesOf(Machine_1).Select(x => (x as MyResource).Name)));
            // TOOLTIP WORKORDER
            MachineUsageChart.SetToolTip(Auftrag_1, "Auftrag: " + string.Join(", ", GanttContent.ResourcesOf(Auftrag_1).Select(x => (x as MyResource).Name))+" Zeitraum: "+ string.Format("{0} to {1}", StartWorkorder.ToLongDateString(), EndWorkOrder.ToLongDateString()));
            //DISABLEW DRAG AND DROP CAUSE OF DAU
            MachineUsageChart.AllowTaskDragDrop = false;
            //DATUM AUF HEUTE SETZEN
            TimeSpan span = DateTimeNow - StartMaschine;
            GanttContent.Now = span.Days;
            //START DATUM = MAX PUNKT FÜR ZURÜCK SCROLLEN
            GanttContent.Start = StartMaschine;
            //ANSICHT AUF DATUM HEUTE FIXIEREN
            MachineUsageChart.ScrollTo(DateTimeNow);
            //EINHEIT GANTCHART MONAT-TAGE
            GanttContent.TimeScale = TimeScale.Day;
            MachineUsageChart.TimeScaleDisplay = TimeScaleDisplay.DayOfMonth;
           //VALIDATE
            MachineUsageChart.Invalidate();

        }


        private void MachineUsageChart_Load(object sender, EventArgs e)
        {

        }

        private void MaschineOptionGrpBox_Enter(object sender, EventArgs e)
        {

        }
    }
    public class MyResource
    {
        public string Name { get; set; }
    }
    public class MyTask : Braincase.GanttChart.Task
    {
        public MyTask(ProjectManager manager)
            : base()
        {
            Manager = manager;
        }

        private ProjectManager Manager { get; set; }
        public new int Start { get { return base.Start; } set { Manager.SetStart(this, value); } }
        public new int End { get { return base.End; } set { Manager.SetEnd(this, value); } }
        public new int Duration { get { return base.Duration; } set { Manager.SetDuration(this, value); } }
        public new float Complete { get { return base.Complete; } set { Manager.SetComplete(this, value); } }
    }
}
