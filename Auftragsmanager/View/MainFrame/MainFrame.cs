using Braincase.GanttChart;
using Repository.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class MainFrame : Form
    {
        Unit _unit;

        public MainFrame(Unit unit)
        {
            _unit = unit;
            InitializeComponent();
            this.OrderSelectFilterInput.Text = _unit.Session.GetSessionUser().Username;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormClosing += closeEvent;
            this.Show();
            _unit.Files.DdisplayDirectories();
            if (_unit.Session.Access(2))
                Console.WriteLine("Access");
            DisplayDirectories(DirSearchFilterInput.Text, MainFrameDirListBox);
            DisplayFiles(FileSeachFilterInput.Text, MainFrameFileListBox);
            initGant();
        }
      
        private void DirSearchFilterInput_KeyUp(object sender, KeyEventArgs e)
        {
            DisplayDirectories(DirSearchFilterInput.Text, MainFrameDirListBox);
        }
        private void MainFrameDirListBox_Click(object sender, EventArgs e)
        {
            DisplayFiles(FileSeachFilterInput.Text, MainFrameFileListBox);
        }
        private void DisplayDirectories(string filter, ListBox listBox)
        {
            listBox.Items.Clear();
            string[] directories = _unit.Files.DdisplayDirectories();          
            foreach (string dir in directories)
            {
                if (dir.Contains(filter))
                {
                    listBox.Items.Add(Path.GetFileName(dir));
                    if (listBox.Items.Count > 0)
                        listBox.SetSelected(0, true);
                }
            }
        }
        private void DisplayFiles(string filter, ListBox listBox)
        {
            listBox.Items.Clear();
            if (true && (MainFrameDirListBox.SelectedItem.ToString() != null))
            {
                
                string[] files = _unit.Files.DisplayFiles(MainFrameDirListBox.SelectedItem.ToString());
                foreach (string file in files)
                {
                    if (file.Contains(filter))
                    {
                        listBox.Items.Add(Path.GetFileName(file));
                    }
                }
            }
        }
        
        private void closeEvent(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void EmptyFolderSubMenuItem_Click(object sender, EventArgs e)
        {
            OrderFrame order = new OrderFrame(_unit);
            order.Show();
        }
        private void newUser(object sender, EventArgs e)
        {
            NewUser newUser = NewUser.Instance(_unit) ;
            newUser.Show();
        }        
        private void newMachine(object sender, EventArgs e)
        {
            NewMachine newMachine = NewMachine.Instance(_unit);
            newMachine.Show();
        }
        private void addDefect(object sender, EventArgs e)
        {
            AddDefect addDefect = AddDefect.Instance(_unit);
            addDefect.Show();
        }
        private void editMaschine(object sender, EventArgs e)
        {
            EditMachine editMashine = EditMachine.Instance(_unit);
            editMashine.Show();
        }

        private void DownloadDirButton_Click(object sender, EventArgs e)
        {
            _unit.Files.DownloadDir(MainFrameDirListBox.SelectedItem.ToString());
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            _unit.Files.OpenFile(MainFrameDirListBox.SelectedItem.ToString(),MainFrameFileListBox.SelectedItem.ToString());
        }

        private void DownloadFileButton_Click(object sender, EventArgs e)
        {
            _unit.Files.DownloadFile(MainFrameDirListBox.SelectedItem.ToString(), MainFrameFileListBox.SelectedItem.ToString());
        }        
        
         /*
         * INIT GANT CHART
         * CREATE MACHINE FIELDS
         * CREATE MACHINE WORKORDER FIELDS
         * 
         */
         private void initGant()
        {
            _unit.Machine.CreateGantMachine(MachineUsageChart);
            MachineUsageChart.AllowTaskDragDrop = false;
            MachineUsageChart.ScrollTo(DateTime.Now);
            MachineUsageChart.TimeScaleDisplay = TimeScaleDisplay.DayOfMonth;
            MachineUsageChart.Invalidate();
        }
    }
}
