using Braincase.GanttChart;
using Repository.Models;
using Repository.Persistence;
using System;
using System.IO;
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
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormClosing += closeEvent;
            this.Show();
            _unit.Files.DdisplayDirectories();
            if (_unit.Session.Access(2))
                benutzerToolStripMenuItem.Visible = true;
            DisplayDirectories(DirSearchFilterInput.Text, MainFrameDirListBox);
            DisplayFiles(FileSeachFilterInput.Text, MainFrameFileListBox);
            DisplayOrderFolder("");
            if (SelectedOrderListBox.Items.Count > 0)
            {
                SelectedOrderListBox.SetSelected(0, true);
                DisplaySelectedOrder(SelectedOrderListBox.SelectedItem.ToString());
            }
            
            initGant();
        }
        /*
         DISPLAY SELECTED ORDER PART
         */
        private void DisplaySelectedOrder(string orderID)
        {
            string[] substring = orderID.Split('|');
            //Order order = _unit.Order.Find(o => o.OrderDetails.OrderNumber == substring[0].ToString());
            
           
            //TOP LEFT
            OrderIncomeDateInput.Text = "";
            OrderIncomeTimeInput.Text = "";
            OrderDeadlineInput.Text = "";
            OrderEditionInput.Text = "";
            //TOP RIGHT
            OrderNameInput.Text = substring[1].ToString();
            OrderNumberInput.Text = substring[0].ToString();
            //MID LEFT
            OrderCustomerInput.Text = "";
            OrderObjectInput.Text = "";
            OrderConsultantInput.Text = "";
            OrderEditorInput.Text = "";
            OrderQuantityInput.Text = "";
            OrderInlandInput.Text = "";
            OrderForeignInput.Text = "";
            OrderRemainsInput.Text = "";
            //MID RIGHT
            OrderEDVJob1Input.Text = "";
            OrderEDVJob2Input.Text = "";
            OrderEDVJob3Input.Text = "";
            OrderEDVJob4Input.Text = "";
            OrderEDVJob5Input.Text = "";
            OrderEDVJob6Input.Text = "";
            MaschineSelectInput.Text = "";
            OrderMaxProTimeInput.Text = "";
            StartLabelDisplay.Text = "";
            endLabelDisplay.Text = "";
            //BOT LEFT
            OrderInfoInput.Text = "";
            OrderBillInput.Text = "";
            OrderMaterialInput.Text = "";
            //BOT RIGHT
            OrderProJob1Input.Text = "";
            OrderProJob2Input.Text = "";
            OrderProJob3Input.Text = "";
            OrderProJob4Input.Text = "";
            OrderProJob5Input.Text = "";
            OrderProJob6Input.Text = "";
            kuvertierenCBInput.Checked = true;
            inkenCBInput.Checked = true;
            folierenCBInput.Checked = true;
        }

        /*
        ORDER PART
        */
        private void OrderSelectFilterInput_KeyUp(object sender, KeyEventArgs e)
        {
            DisplayOrderFolder(OrderSelectFilterInput.Text);
        }
        private void EmptyFolderSubMenuItem_Click(object sender, EventArgs e)
        {
            OrderFrame newOrder = OrderFrame.Instance(_unit);
            newOrder.Show();
        }
        private void ClonedFolderSubMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void DisplayOrderFolder(string Filter)
        {
            SelectedOrderListBox.Items.Clear();
            if (_unit.Order.GetAll() != null)
            {
                foreach (var item in _unit.Order.GetAll())
                {
                    if (item.OrderDetails.OrderName.Contains(Filter) || item.OrderDetails.OrderNumber.Contains(Filter) || item.OrderDetails.Customer.Name.Contains(Filter))
                    {
                        SelectedOrderListBox.Items.Add(item.OrderDetails.OrderNumber + " | " + item.OrderDetails.OrderName);
                    }
                }
            }
        }
        /*
        FILE PART
        */
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
            if (directories != null)
            {
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
        }
        private void DisplayFiles(string filter, ListBox listBox)
        {
            listBox.Items.Clear();
            if (MainFrameDirListBox.SelectedItem != null)
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
        private void DownloadDirButton_Click(object sender, EventArgs e)
        {
            if (MainFrameDirListBox.SelectedItem != null)
            {
                _unit.Files.DownloadDir(MainFrameDirListBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Es muss erst ein Ordner ausgewählt werden.", @"Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if (MainFrameFileListBox.SelectedItem != null)
            {
                _unit.Files.OpenFile(MainFrameDirListBox.SelectedItem.ToString(), MainFrameFileListBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Es muss erst eine Datei ausgewählt werden.", @"Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DownloadFileButton_Click(object sender, EventArgs e)
        {
            if (MainFrameFileListBox.SelectedItem != null)
            {
                _unit.Files.DownloadFile(MainFrameDirListBox.SelectedItem.ToString(), MainFrameFileListBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Es muss erst eine Datei ausgewählt werden.", @"Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*
         MACHINE PART             
         */
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
        private void initGant()
        {
            _unit.Machine.CreateGantMachine(MachineUsageChart);
            MachineUsageChart.AllowTaskDragDrop = false;
            MachineUsageChart.ScrollTo(DateTime.Now);
            MachineUsageChart.TimeScaleDisplay = TimeScaleDisplay.DayOfMonth;
            MachineUsageChart.Invalidate();
        }
        /*
         USER PART - ONLY ADMIN
         */
        private void neuenBenutzerAnlegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewUser newUser = NewUser.Instance(_unit);
            newUser.Show();
        }

    }
}
