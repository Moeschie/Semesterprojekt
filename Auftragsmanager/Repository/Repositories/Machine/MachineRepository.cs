using Repository.Core;
using Repository.Model;
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
        ProjectManager GanttContent;
        MachineTask machineTasks;
        int rgb;
        public MachineRepository(DataContext context) : base(context)
        {
        }


        public bool MachineExists(string machinename)
        {
            bool exists = false;
            Machine machine = GetAll().Where(m => m.Name == machinename).FirstOrDefault();

            if (machine != null)
                exists = true;

            return exists;
        }

        public void CreateGantMachine(Chart usagesChart)
        {
            GanttContent = new ProjectManager();
            DateTime StartMaschine = new DateTime(2016, 1, 1);
            DateTime EndMachine = new DateTime(2016, 12, 12);
            DateTime Now = DateTime.Now;
            foreach (var machine in GetAll().ToList())
            {
                rgb += 25;
                var AddMachine = new MyTask(GanttContent) { Name = machine.Name, Color = Color.FromArgb(rgb,rgb,rgb)};
                GanttContent.Add(AddMachine);
                var AddToolTip = new MyResource() { Name = machine.Name };
                GanttContent.Assign(AddMachine, AddToolTip);
                GanttContent.SetStart(AddMachine, SetStartTaskDateTime(DateTime.Now, StartMaschine));
                GanttContent.SetEnd(AddMachine, DateTime.Now.DayOfYear + 365);
                usagesChart.SetToolTip(AddMachine, string.Join(", ", GanttContent.ResourcesOf(AddMachine).Select(x => (x as MyResource).Name)));
                foreach (var machineTask in .GetAll().Where(m=>m.Machine == machine.Name).ToList()) 
                {
                    var AddTask = new MyTask(GanttContent) { Name = machineTask.Name };
                    GanttContent.Add(AddTask);
                    var AddTaskToolTip = new MyResource() { Name = "Auftrag 1" };
                    GanttContent.Assign(AddTask, AddTaskToolTip);
                    GanttContent.Group(AddMachine, AddTask);
                    usagesChart.SetToolTip(AddTask, "Auftrag: " + string.Join(", ", GanttContent.ResourcesOf(AddTask).Select(x => (x as MyResource).Name)) + " Zeitraum: " + string.Format("{0} to {1}", machineTask.UsageStart.ToLongDateString(), machineTask.UsageStart.ToLongDateString()));
                }
            }
            TimeSpan span = DateTime.Now - StartMaschine;
            GanttContent.Now = span.Days;
            GanttContent.Start = StartMaschine;
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

        private int SetStartTaskDateTime(DateTime start, DateTime end)
        {
            return (int)((end - start).Days);
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