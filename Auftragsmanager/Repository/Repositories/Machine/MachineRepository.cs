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
    public class MachineRepository : Repository<Machine>, IMachineRepository
    {
        public ProjectManager GanttContent;
        Chart usagesChart;
        MachineTaskRepository machineTasks;
        private List<string> checkedMachines = new List<string>();        
        private List<Color> colorPalette = new List<Color>();
        public MachineRepository(DataContext context) : base(context)
        {
            machineTasks = new MachineTaskRepository(context);
        }

        public bool MachineExists(string machinename)
        {
            bool exists = false;
            Machine machine = GetAll().Where(m => m.Name == machinename).FirstOrDefault();
            if (machine != null)
                exists = true;
            return exists;
        }

        public Color GetColorCode()
        {
            if (colorPalette.Count() < 1)
                setColorPalette();

            Color color = colorPalette[0];
            colorPalette.Remove(color);

            return color;
        }
        private void setColorPalette()
        {
            colorPalette.Add(Color.BlueViolet);
            colorPalette.Add(Color.Aqua);
            colorPalette.Add(Color.CadetBlue);
            colorPalette.Add(Color.Chartreuse);
            colorPalette.Add(Color.Chocolate);
            colorPalette.Add(Color.Crimson);
            colorPalette.Add(Color.DarkBlue);
            colorPalette.Add(Color.DarkCyan);
            colorPalette.Add(Color.DarkGoldenrod);
            colorPalette.Add(Color.DarkGreen);
            colorPalette.Add(Color.Yellow);
            colorPalette.Add(Color.SteelBlue);
            colorPalette.Add(Color.SandyBrown);
        }
        public ProjectManager getProjectManager()
        {
            return GanttContent;
        }
        public void CreateGantMachine(Chart givenChart, List<string> checkedList)
        {
            usagesChart = givenChart;
            checkedMachines = checkedList;
            GanttContent = new ProjectManager();
            if (checkedList.Count <1)
            {
                foreach (var item in GetAll().ToList())
                {
                    checkedList.Add(item.Name);
                }
            }
            foreach (var item in checkedMachines)
            {
                foreach (var machine in GetAll().Where(n => n.Name == item))
                {
                    var AddMachine = new MyTask(GanttContent) { Name = machine.Name, Color = GetColorCode() };
                    GanttContent.Add(AddMachine);

                    var AddToolTip = new MyResource() { Name = machine.Name };
                    GanttContent.Assign(AddMachine, AddToolTip);

                    usagesChart.SetToolTip(AddMachine, string.Join(", ", GanttContent.ResourcesOf(AddMachine).Select(x => (x as MyResource).Name)));

                    foreach (var machineTask in machineTasks.GetAll().Where(m => m.Machine.Id == machine.Id).ToList())
                    {
                        DateTime machineTaskSart = DateTime.Parse(machineTask.UsageStart);
                        DateTime machineTaskEnd = DateTime.Parse(machineTask.UsageEnd);
                        if (machineTaskSart >= DateTime.Now || machineTaskEnd >= DateTime.Now)
                        {
                            var AddTask = new MyTask(GanttContent) { Name = machineTask.title, Color = Color.LightGray };
                            GanttContent.Add(AddTask);
                            var AddTaskToolTip = new MyResource() { Name = machineTask.title };
                            GanttContent.Assign(AddTask, AddTaskToolTip);
                            GanttContent.SetStart(AddTask, setDateTime(machineTaskSart));
                            GanttContent.SetEnd(AddTask, setDateTime(machineTaskEnd));
                            GanttContent.Group(AddMachine, AddTask);

                            usagesChart.SetToolTip(AddTask, "Auftrag: " + string.Join(", ", GanttContent.ResourcesOf(AddTask).Select(x => (x as MyResource).Name)) + " Zeitraum: " + string.Format("{0} bis {1}", machineTaskSart.ToString("dd/MM/yyyy"), machineTaskEnd.ToString("dd/MM/yyyy")));
                        }
                    }
                } }

            //TimeSpan span = DateTime.Now - DateTime.Now.AddDays(-5);
            //GanttContent.Now = span.Days;
            //DateTime test = DateTime.Now;
            //GanttContent.Start = test.AddDays(-5);
            GanttContent.Start = DateTime.Now;
            GanttContent.TimeScale = TimeScale.Day;
            usagesChart.Init(GanttContent);
            usagesChart.PaintTask += (s, e) =>
            {
                MyTask ctask = e.Task as MyTask;
                if (ctask != null)
                {
                    var format = new TaskFormat();
                    format = e.Format;
                    format.BackFill = new SolidBrush(ctask.Color);
                    e.Format = format;
                }
            };
        }
        private int setDateTime(DateTime dateTime)
        {
            return dateTime.DayOfYear - DateTime.Now.DayOfYear;
        }

        public void InitGantt()
        {            
            CreateGantMachine(usagesChart, checkedMachines);
            usagesChart.AllowTaskDragDrop = false;
            usagesChart.ScrollTo(DateTime.Now);
            usagesChart.TimeScaleDisplay = TimeScaleDisplay.DayOfMonth;
            usagesChart.Invalidate();
        }

        public DataContext DataContext
        {
            get { return Context as DataContext; }
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
        public Color Color { get; set; }
        public new int Start { get { return base.Start; } set { Manager.SetStart(this, value); } }
        public new int End { get { return base.End; } set { Manager.SetEnd(this, value); } }
        public new int Duration { get { return base.Duration; } set { Manager.SetDuration(this, value); } }
        public new float Complete { get { return base.Complete; } set { Manager.SetComplete(this, value); } }
    }
}