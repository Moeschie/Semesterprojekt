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
      //  List<Guid> guidList = new List<Guid>();

        private static OrderFrame instance;

        private OrderFrame(Unit unit)
        {
            _unit = unit;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.FormClosing += closeEvent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            OrderNumberInput.Text = _unit.Order.orderIDgen();
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
                AddOrder(sender, null);
            }

            instance = null;
            MainFrame asda = new MainFrame(_unit);
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
        private void AddOrder(object sender, EventArgs e)
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

            //Details
            od.Customer = new Customer();
            od.Customer.Id = Guid.NewGuid();

            od.Customer.Name = OrderCustomerInput.Text;
            od.Object = OrderObjectInput.Text;
            //od.User = new User();
            //od.User.Username = OrderEditorInput.Text;
            int n;
            bool isNumeric = int.TryParse(OrderQuantityInput.Text, out n);
            if (isNumeric)
            {
                od.OverallQuantity = n;
            }
            od.SplitForeinLand = OrderInlandInput.Text;
            od.SplitHomeLand = OrderInlandInput.Text;
            od.Adress = new Adress();
            od.Adress.Id = Guid.NewGuid();
            od.Adress.Name = OrderConsultantInput.Text;
            od.Foreign = OrderForeignInput.Text;
            od.AdditionalInformation = OrderInfoInput.Text;
            od.BillTo = OrderBillInput.Text;
            od.Material = OrderBillInput.Text;


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
            pa.value = proData[0]+"|"+ proData[1] + "|" + proData[2] + "|" + proData[3] + "|" + proData[4] + "|" + proData[5];

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
            updateOrder.OrderDetails.Object = order.OrderDetails.BillTo;
            updateOrder.OrderDetails.Order = order.OrderDetails.Order;
            updateOrder.OrderDetails.OrderEdition = order.OrderDetails.OrderEdition;
            updateOrder.OrderDetails.OrderName = order.OrderDetails.OrderName;
            updateOrder.OrderDetails.OrderNumber = order.OrderDetails.OrderNumber;
            updateOrder.OrderDetails.OverallQuantity = order.OrderDetails.OverallQuantity;
            updateOrder.OrderDetails.SplitForeinLand = order.OrderDetails.SplitForeinLand;
            updateOrder.OrderDetails.SplitHomeLand = order.OrderDetails.SplitHomeLand;
            //updateOrder.OrderDetails.User = order.OrderDetails.User;

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
