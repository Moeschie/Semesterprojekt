using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository.Persistence;
using Repository.Persistence.Utilities;
using Repository.Models;

namespace View
{
    public partial class OrderFrame : Form
    {
        Unit _unit;
        Guid OrderNumber;
        bool save;
        Order order;

        FormValidation f = new FormValidation();
        TextStrings t = new TextStrings();

        private static OrderFrame instance;
        private bool UpdateState;
        static string orderID;

        private OrderFrame(Unit unit)
        {
            _unit = unit;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.FormClosing += closeEvent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            if (!UpdateState)
                OrderNumberInput.Text = _unit.Order.orderIDgen();

            orderID = OrderNumberInput.Text;
            StartMachineUsagesDateTimeInput.CustomFormat = "dd/MM/yyyy";
            StartMachineUsagesDateTimeInput.Format = DateTimePickerFormat.Custom;
            EndMachineUsagesDateTimeInput.CustomFormat = "dd/MM/yyyy";
            EndMachineUsagesDateTimeInput.Format = DateTimePickerFormat.Custom;
            foreach (var machine in _unit.Machine.GetAll().ToList())
            {
                MaschineSelectInput.Items.Add(machine.Name);
                MaschineSelectInput.SelectedItem = 1;
            }
        }
        private void closeEvent(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Wollen sie die Änderungen Speichern?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (f.Validate())
                {
                    AddOrder(sender, null);
                    _unit.Order.SetOccupied(orderID);
                }
            }
            instance = null;
            MainFrame.Instance(_unit).DisplayOrderFolder("");
            _unit.Machine.InitGantt();
        }
        public static OrderFrame Instance(Unit unit)
        {
            if (instance == null)
            {
                instance = new OrderFrame(unit);
            }
            instance.BringToFront();
            return instance;
        }

        internal static OrderFrame Instance(Unit unit, string v)
        {
            if (instance == null)
            {
                instance = new OrderFrame(unit);
            }
            orderID = v;
            instance.BringToFront();
            instance.EditFields(v, false);
            return instance;
        }
        internal static OrderFrame InstanceClone(Unit unit, string v)
        {
            if (instance == null)
            {
                instance = new OrderFrame(unit);
            }
            orderID = v;
            instance.BringToFront();
            instance.EditFields(v, true);
            return instance;
        }

        private void EditFields(string v, bool clone)
        {

            Order editOrder = _unit.Order.GetOrderById(v);
            if (!clone) OrderNumberInput.Text = editOrder.OrderDetails.OrderNumber;
            else OrderNumberInput.Text = _unit.Order.orderIDgen();

            OrderIncomeDateInput.Text = editOrder.OrderDetails.IncomeDate;
            OrderIncomeTimeInput.Text = editOrder.OrderDetails.IncomeTime;
            OrderDeadlineInput.Text = editOrder.OrderDetails.Deadline;
            OrderEditionInput.Text = editOrder.OrderDetails.OrderEdition;
            OrderNameInput.Text = editOrder.OrderDetails.OrderName;

            //Details
            OrderCustomerInput.Text = editOrder.OrderDetails.Customer.Name;
            OrderObjectInput.Text = editOrder.OrderDetails.ObjectTitel;
            OrderQuantityInput.Text = editOrder.OrderDetails.OverallQuantity.ToString();
            OrderInlandInput.Text = editOrder.OrderDetails.SplitHomeLand;
            OrderForeignInput.Text = editOrder.OrderDetails.SplitForeinLand;
            OrderConsultantInput.Text = editOrder.OrderDetails.Consultant;
            OrderEditorInput.Text = editOrder.OrderDetails.User.Username;
            OrderRemainsInput.Text = editOrder.OrderDetails.RemainsToo;
            OrderInfoInput.Text = editOrder.OrderDetails.AdditionalInformation;
            OrderBillInput.Text = editOrder.OrderDetails.BillTo;
            OrderMaterialInput.Text = editOrder.OrderDetails.Material;
            StartMachineUsagesDateTimeInput.Value = DateTime.Parse(editOrder.OrderDetails.ProductionStart);
            EndMachineUsagesDateTimeInput.Value = DateTime.Parse(editOrder.OrderDetails.ProductionEnd);
            OrderMaxProTimeInput.Text = editOrder.OrderDetails.ProductionTimespan;
            // Rechte Seite
            string[] edvActions = editOrder.EdvActions.Actions.Split('|');
            OrderEDVJob1Input.Text = edvActions[0];
            OrderEDVJob2Input.Text = edvActions[1];
            OrderEDVJob3Input.Text = edvActions[2];
            OrderEDVJob4Input.Text = edvActions[3];
            OrderEDVJob5Input.Text = edvActions[4];
            OrderEDVJob6Input.Text = edvActions[5];
            string machineName = "";
            if (editOrder.EdvActions.Machine.Count > 0) machineName = editOrder.EdvActions.Machine.ToList().Single().Name;
            MaschineSelectInput.Text = machineName;
            string[] actions = editOrder.ProductionActions.value.Split('|');
            OrderProJob1Input.Text = actions[0];
            OrderProJob2Input.Text = actions[1];
            OrderProJob3Input.Text = actions[2];
            OrderProJob4Input.Text = actions[3];
            OrderProJob5Input.Text = actions[4];
            OrderProJob6Input.Text = actions[5];
            kuvertierenCBInput.Checked = editOrder.ProductionActions.Kuvert;
            inkenCBInput.Checked = editOrder.ProductionActions.Ink;
            folierenCBInput.Checked = editOrder.ProductionActions.folieren;
            OrderInsertInput.Text = editOrder.ProductionActions.Insert;
            OrderInsertKindInput.Text = editOrder.ProductionActions.InsertKind;
            UpdateState = true;

        }

        private void AddOrder(object sender, EventArgs e)
        {


            f.AddRule(OrderNameInput, t.ENTRY_REQUIRED);

            if (f.Validate())
            {

                //Linke Seite
                OrderDetails od = new OrderDetails();

                od.Id = Guid.NewGuid();

                od.IncomeDate = OrderIncomeDateInput.Text;
                od.IncomeTime = OrderIncomeTimeInput.Text;
                od.Deadline = OrderDeadlineInput.Text;
                od.OrderEdition = OrderEditionInput.Text;
                od.OrderName = OrderNameInput.Text;
                od.OrderNumber = OrderNumberInput.Text;
                if (MaschineSelectInput.SelectedItem != null)
                    od.Machine = _unit.Machine.Find(m => m.Name == MaschineSelectInput.Text).FirstOrDefault();
                //Details
                od.Customer = new Customer();
                od.Customer.Id = Guid.NewGuid();

                od.Customer.Name = OrderCustomerInput.Text;
                od.ObjectTitel = OrderObjectInput.Text;
                od.Consultant = OrderConsultantInput.Text;
                od.User = _unit.Session.GetSessionUser();
                int n;
                bool isNumeric = int.TryParse(OrderQuantityInput.Text, out n);
                if (isNumeric) od.OverallQuantity = n;
                od.SplitForeinLand = OrderInlandInput.Text;
                od.SplitHomeLand = OrderInlandInput.Text;
                od.Adress = new Adress();
                od.Adress.Id = Guid.NewGuid();
                od.Adress.Name = OrderConsultantInput.Text;
                od.Foreign = OrderForeignInput.Text;
                od.RemainsToo = OrderRemainsInput.Text;
                od.AdditionalInformation = OrderInfoInput.Text;
                od.BillTo = OrderBillInput.Text;
                od.Material = OrderMaterialInput.Text;

                od.ProductionStart = StartMachineUsagesDateTimeInput.Text.ToString();
                od.ProductionEnd = EndMachineUsagesDateTimeInput.Text.ToString();
                od.ProductionTimespan = OrderMaxProTimeInput.Text.ToString();
                // Rechte Seite
                EdvActions edv = new EdvActions();
                string[] data = new string[6];

                edv.Id = Guid.NewGuid();

                data[0] = OrderEDVJob1Input.Text;
                data[1] = OrderEDVJob2Input.Text;
                data[2] = OrderEDVJob3Input.Text;
                data[3] = OrderEDVJob4Input.Text;
                data[4] = OrderEDVJob5Input.Text;
                data[5] = OrderEDVJob6Input.Text;
                edv.Actions = data[0] + "|" + data[1] + "|" + data[2] + "|" + data[3] + "|" + data[4] + "|" + data[5];
                ProductionActions pa = new ProductionActions();
                pa.Id = Guid.NewGuid();
                string[] proData = new string[6];
                proData[0] = OrderProJob1Input.Text;
                proData[1] = OrderProJob2Input.Text;
                proData[2] = OrderProJob3Input.Text;
                proData[3] = OrderProJob4Input.Text;
                proData[4] = OrderProJob5Input.Text;
                proData[5] = OrderProJob6Input.Text;
                pa.value = proData[0] + "|" + proData[1] + "|" + proData[2] + "|" + proData[3] + "|" + proData[4] + "|" + proData[5];

                pa.Insert = OrderInsertInput.Text;
                pa.InsertKind = OrderInsertKindInput.Text;
                pa.Kuvert = kuvertierenCBInput.Checked;
                pa.Ink = inkenCBInput.Checked;
                pa.folieren = folierenCBInput.Checked;

                order = new Order();
                order.ProductionActions = pa;
                order.EdvActions = edv;
                order.OrderDetails = od;


                if (!save)
                    SaveOrder();

                if (save)
                    UpdateOrder();

            }

        }
        private void UpdateOrder()
        {
            Order updateOrder = _unit.Order.Find(o => o.Id == OrderNumber).Single();
            updateOrder = order;
            //EDV
            updateOrder.EdvActions.Actions = order.EdvActions.Actions;
            updateOrder.EdvActions.Machine = order.EdvActions.Machine;
            updateOrder.EdvActions.Order = order.EdvActions.Order;
            //DETAILS
            updateOrder.OrderDetails.AdditionalInformation = order.OrderDetails.AdditionalInformation;
            updateOrder.OrderDetails.Adress = order.OrderDetails.Adress;
            updateOrder.OrderDetails.BillTo = order.OrderDetails.BillTo;
            updateOrder.OrderDetails.Customer = order.OrderDetails.Customer;
            updateOrder.OrderDetails.Deadline = order.OrderDetails.Deadline;
            updateOrder.OrderDetails.Foreign = order.OrderDetails.Foreign;
            updateOrder.OrderDetails.IncomeDate = order.OrderDetails.IncomeDate;
            updateOrder.OrderDetails.Material = order.OrderDetails.Material;
            updateOrder.OrderDetails.ObjectTitel = order.OrderDetails.BillTo;
            updateOrder.OrderDetails.Order = order.OrderDetails.Order;
            updateOrder.OrderDetails.OrderEdition = order.OrderDetails.OrderEdition;
            updateOrder.OrderDetails.OrderName = order.OrderDetails.OrderName;
            updateOrder.OrderDetails.OrderNumber = order.OrderDetails.OrderNumber;
            updateOrder.OrderDetails.OverallQuantity = order.OrderDetails.OverallQuantity;
            updateOrder.OrderDetails.SplitForeinLand = order.OrderDetails.SplitForeinLand;
            updateOrder.OrderDetails.SplitHomeLand = order.OrderDetails.SplitHomeLand;
            updateOrder.OrderDetails.RemainsToo = order.OrderDetails.RemainsToo;
            //Production
            updateOrder.ProductionActions.folieren = order.ProductionActions.folieren;
            updateOrder.ProductionActions.Ink = order.ProductionActions.Ink;
            updateOrder.ProductionActions.Insert = order.ProductionActions.Insert;
            updateOrder.ProductionActions.InsertKind = order.ProductionActions.InsertKind;
            updateOrder.ProductionActions.Kuvert = order.ProductionActions.Kuvert;
            updateOrder.ProductionActions.Order = order.ProductionActions.Order;
            updateOrder.ProductionActions.value = order.ProductionActions.value;

            _unit.Complete();
        }

        private void SaveOrder()
        {
            FormValidation f = new FormValidation();
            TextStrings t = new TextStrings();

            if (f.Validate())
            {
                order.Versionierung = _unit.Order.Find(o => o.OrderDetails.OrderNumber == OrderNumberInput.Text).Count() + 1;
                save = true;
                order.Id = Guid.NewGuid();
                OrderNumber = order.Id;
                _unit.Order.Add(order);
                _unit.Complete();
            }
        }


        private void OrderDataButton_Click(object sender, EventArgs e)
        {
            FilebrowserFrame filebrowserframe = FilebrowserFrame.Instance(_unit);
            filebrowserframe.Show();

        }

    }
}
