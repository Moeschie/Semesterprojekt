using Braincase.GanttChart;
using Repository.Models;
using Repository.Persistence;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace View
{
    public partial class MainFrame : Form
    {
        Unit _unit;
        private static MainFrame instance;

        private MainFrame(Unit unit)
        {
            _unit = unit;
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormClosing += closeEvent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Show();
            _unit.Files.DdisplayDirectories();
            if (_unit.Session.Access(2))
            {
                benutzerToolStripMenuItem.Visible = true;
                NewMachineMenuItem.Visible = true;
                EditMachineMenuItem.Visible = true;
            }
                
            DisplayDirectories(DirSearchFilterInput.Text);
            DisplayFiles(FileSeachFilterInput.Text);
            DisplayOrderFolder("");
            setSelectedOrder();
            _unit.Machine.CreateGantMachine(MachineUsageChart, getSelectedMachines());
            _unit.Machine.InitGantt();
            initMenu();
        }

        public void setSelectedOrder() {
            if (SelectedOrderListBox.Items.Count > 0)
            {
                SelectedOrderListBox.SetSelected(0, true);
                DisplaySelectedOrder(SelectedOrderListBox.SelectedItem.ToString());
            }
        }

        public static MainFrame Instance(Unit unit)
        {
            if (instance == null)
            {
                instance = new MainFrame(unit);
            }
            instance.BringToFront();
            return instance;
        }
        /*
         DISPLAY SELECTED ORDER PART
         */
        private void DisplaySelectedOrder(string orderID)
        {
            Order order = _unit.Order.GetOrderById(orderID);
            string machineName="";

            if (order != null)
            {
                //TOP LEFT
                OrderIncomeDateInput.Text = order.OrderDetails.IncomeDate;
                OrderIncomeTimeInput.Text = order.OrderDetails.IncomeTime;
                OrderDeadlineInput.Text = order.OrderDetails.Deadline;
                OrderEditionInput.Text = order.OrderDetails.OrderEdition;
                //TOP RIGHT
                OrderNameInput.Text = order.OrderDetails.OrderName;
                OrderNumberInput.Text = order.OrderDetails.OrderNumber;
                //MID LEFT
                OrderCustomerInput.Text = order.OrderDetails.Customer.Name;
                OrderObjectInput.Text = order.OrderDetails.ObjectTitel;                
                OrderConsultantInput.Text = order.OrderDetails.Consultant;
                OrderEditorInput.Text = order.OrderDetails.User.Username;
                OrderQuantityInput.Text = order.OrderDetails.OverallQuantity.ToString();
                OrderInlandInput.Text = order.OrderDetails.SplitForeinLand;
                OrderForeignInput.Text = order.OrderDetails.Foreign;
                OrderRemainsInput.Text = order.OrderDetails.RemainsToo;
                //MID RIGHT
                string[] edvActions = order.EdvActions.Actions.Split('|');
                OrderEDVJob1Input.Text = edvActions[0];
                OrderEDVJob2Input.Text = edvActions[1];
                OrderEDVJob3Input.Text = edvActions[2];
                OrderEDVJob4Input.Text = edvActions[3];
                OrderEDVJob5Input.Text = edvActions[4];
                OrderEDVJob6Input.Text = edvActions[5];

                if (order.OrderDetails.Machine != null) machineName = order.OrderDetails.Machine.Name;
                MaschineSelectInput.Text = machineName;
                OrderMaxProTimeInput.Text = order.OrderDetails.ProductionTimespan;
                StartLabelDisplay.Text = order.OrderDetails.ProductionStart;
                endLabelDisplay.Text = order.OrderDetails.ProductionEnd;
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
                OrderInsertInput.Text = order.ProductionActions.Insert;
                OrderInsertKindInput.Text = order.ProductionActions.InsertKind;
                kuvertierenCBInput.Checked = order.ProductionActions.Kuvert;
                inkenCBInput.Checked = order.ProductionActions.Ink;
                folierenCBInput.Checked = order.ProductionActions.folieren;
            }
        }

        /*
        ORDER PART
        */
        private void OrderSelectFilterInput_KeyUp(object sender, KeyEventArgs e)
        {
            DisplayOrderFolder(OrderSelectFilterInput.Text);
        }
        public void DisplayOrderFolder(string Filter)
        {
            SelectedOrderListBox.Items.Clear();
            List<Order> orders = _unit.Order.GetAllByGroup();
            if (orders != null)
            {
                foreach (var item in orders)
                {
                    //System.Text.RegularExpressions.Regex.IsMatch(item.OrderDetails.OrderName, Filter, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
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
            DisplayDirectories(DirSearchFilterInput.Text);
        }
        private void MainFrameDirListBox_Click(object sender, EventArgs e)
        {
            DisplayFiles(FileSeachFilterInput.Text);
        }
        public void DisplayDirectories(string filter)
        {
            MainFrameDirListBox.Items.Clear();
            string[] directories = _unit.Files.DdisplayDirectories();
            if (directories != null)
            {
                foreach (string dir in directories)
                {
                    if (dir.Contains(filter))
                    {
                        MainFrameDirListBox.Items.Add(Path.GetFileName(dir));
                        if (MainFrameDirListBox.Items.Count > 0)
                            MainFrameDirListBox.SetSelected(0, true);
                    }
                }
            }
        }
        public void DisplayFiles(string filter)
        {
            MainFrameFileListBox.Items.Clear();
            if (MainFrameDirListBox.SelectedItem != null)
            {

                string[] files = _unit.Files.DisplayFiles(MainFrameDirListBox.SelectedItem.ToString());
                foreach (string file in files)
                {
                    if (file.Contains(filter))
                    {
                        MainFrameFileListBox.Items.Add(Path.GetFileName(file));
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
        //FIXME: FIX SCROLL BUG
        private void switchScrollTO(object sender, EventArgs e)
        {
            ProjectManager projectManager = _unit.Machine.getProjectManager();
            if (gesammtToolStripMenuItem.Text =="Gesamt")
            {
                DateTime firstOrder = DateTime.Now;
                foreach (var tasks in _unit.MachineTask.GetAll())
                {
                    if(DateTime.Compare(firstOrder,DateTime.Parse(tasks.UsageStart)) >0)
                    {
                        firstOrder = DateTime.Parse(tasks.UsageStart);
                    }
                }                                
                gesammtToolStripMenuItem.Text = "Von Heute";
                Console.WriteLine(firstOrder);
                projectManager.Start=firstOrder;
                MachineUsageChart.Init(projectManager);
            }
            else
            {
                gesammtToolStripMenuItem.Text = "Gesamt";
                MachineUsageChart.ScrollTo(DateTime.Now);
            }
            MachineUsageChart.Invalidate();
        }
        public void initMenu()
        {
            ToolStripMenuItem added;
            maschinenToolStripMenuItem.DropDown.Items.Clear();
            foreach (var machine in _unit.Machine.GetAll().ToList())
            {
                added = new ToolStripMenuItem();
                added.Text = machine.Name;
                added.Name = machine.Name;
                added.Checked = true;
                added.Click += new EventHandler(MenuItemClickHandler);
                maschinenToolStripMenuItem.DropDown.Items.Add(added);                
            }
        }
        private void MenuItemClickHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            clickedItem.Checked = !clickedItem.Checked;

            _unit.Machine.CreateGantMachine(MachineUsageChart, getSelectedMachines());
            _unit.Machine.InitGantt();
        }
        private List<string> getSelectedMachines()
        {
            List<string> checkedMachines = new List<string>();

            foreach (ToolStripMenuItem item in maschinenToolStripMenuItem.DropDownItems)
            {
                if (item.Checked) checkedMachines.Add(item.Text);

            }
            return checkedMachines;
        }
        /*
         USER PART - ONLY ADMIN
         */
        private void neuenBenutzerAnlegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewUser newUser = NewUser.Instance(_unit);
            newUser.Show();
        }

        private void SelectedOrderListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedOrderListBox.SelectedItem != null)
                DisplaySelectedOrder(SelectedOrderListBox.SelectedItem.ToString());
            
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            _unit.RefreshAll();
            if (SelectedOrderListBox.SelectedItem != null)
            {
                if (!_unit.Order.Occupied(SelectedOrderListBox.SelectedItem.ToString()))
                {
                        _unit.Order.SetOccupied(SelectedOrderListBox.SelectedItem.ToString());
                        OrderFrame newOrder = OrderFrame.Instance(_unit, SelectedOrderListBox.SelectedItem.ToString());
                        newOrder.Show();
                }
                else
                {
                    if (MessageBox.Show("Diese Mappe wird bearbeitet, wollen sie fortfahren?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        _unit.Order.SetOccupied(SelectedOrderListBox.SelectedItem.ToString());
                        OrderFrame newOrder = OrderFrame.Instance(_unit, SelectedOrderListBox.SelectedItem.ToString());
                        newOrder.Show();
                    }
                }

            }
        }

        private void PrintOrder(object sender, EventArgs e)
        {
            string v = _unit.Order.SplitOrderID(SelectedOrderListBox.SelectedItem.ToString());
            _unit.Order.PrintOrder(SelectedOrderListBox.SelectedItem.ToString(), false);
            Process.Start(Path.Combine(ConfigurationSettings.AppSettings["Path"], v, "Auftrag_" + v + ".pdf"));
        }

        private void PrintLaufzettelButton_Click(object sender, EventArgs e)
        {
            string v = _unit.Order.SplitOrderID(SelectedOrderListBox.SelectedItem.ToString());
            _unit.Order.PrintOrder(SelectedOrderListBox.SelectedItem.ToString(), true);
            Process.Start(Path.Combine(ConfigurationSettings.AppSettings["Path"], v, "Laufzettel_" + v + ".pdf"));
        }



        private void CloneOrder(object sender, EventArgs e)
        {
            if (SelectedOrderListBox.SelectedItem != null)
            {
                OrderFrame newOrder = OrderFrame.InstanceClone(_unit, SelectedOrderListBox.SelectedItem.ToString());
                newOrder.Show();
            }else
            {
                MessageBox.Show("Wählen sie die Mappe aus welche geklont werden soll.", @"Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refeshListButton_Click(object sender, EventArgs e)
        {
            DisplayDirectories("");
        }

        private void NewFolderMenuItem_Click(object sender, EventArgs e)
        {
            OrderFrame newOrder = OrderFrame.Instance(_unit);
            newOrder.Show();
        }
    }
}
