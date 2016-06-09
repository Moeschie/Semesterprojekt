using Braincase.GanttChart;
using Repository.Models;
using Repository.Persistence;
using System;
using System.Diagnostics;
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

            


            Order order = _unit.Order.GetOrderById(orderID);


            if(order != null)
            {

            //TOP LEFT
            //  OrderIncomeDateInput.Text = order.OrderDetails.OrderNumber;
            OrderIncomeTimeInput.Text = order.OrderDetails.IncomeTime;
            OrderDeadlineInput.Text = order.OrderDetails.Deadline;
            OrderEditionInput.Text = order.OrderDetails.OrderEdition;
            //TOP RIGHT
            OrderNameInput.Text = order.OrderDetails.OrderName;
            OrderNumberInput.Text = order.OrderDetails.OrderNumber;
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
            string[] edvActions = order.EdvActions.Actions.Split('|');
            OrderEDVJob1Input.Text = edvActions[0];
            OrderEDVJob2Input.Text = edvActions[1];
            OrderEDVJob3Input.Text = edvActions[2];
            OrderEDVJob4Input.Text = edvActions[3];
            OrderEDVJob5Input.Text = edvActions[4];
            OrderEDVJob6Input.Text = edvActions[5];
            MaschineSelectInput.Text = "Machine";
            OrderMaxProTimeInput.Text = "OrderMaxProTime";
            StartLabelDisplay.Text = "startLabel";
            endLabelDisplay.Text = "endLabel";
            //BOT LEFT
            OrderInfoInput.Text = order.OrderDetails.AdditionalInformation;
            OrderBillInput.Text = order.OrderDetails.BillTo;
            OrderMaterialInput.Text = order.OrderDetails.Material;
                //BOT RIGHT
            string[] actions = order.ProductionActions.value.Split('|');
            OrderProJob1Input.Text = actions[0];
            OrderProJob2Input.Text = actions[1];
            OrderProJob3Input.Text = actions[2];
            OrderProJob4Input.Text = actions[3];
            OrderProJob5Input.Text = actions[4];
            OrderProJob6Input.Text = actions[5];
            kuvertierenCBInput.Checked = true;
            inkenCBInput.Checked = true;
            folierenCBInput.Checked = true;
            }

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
