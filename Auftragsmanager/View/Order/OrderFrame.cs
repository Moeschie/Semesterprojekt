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
using Repository.Model;

namespace View
{
    public partial class OrderFrame : Form
    {
        Unit _unit;
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
            if (MessageBox.Show("Wollen sie die Änderungen Speichern?", "",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                AddOrder(sender, null);
            }
            instance = null;
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
            FormValidation f = new FormValidation();
            TextStrings t = new TextStrings();

            if (f.Validate())
            {

                //OrderDetails
                //EdvActions
                //ProductionActions


                //Linke Seite
                OrderDetails od = new OrderDetails();
                //Info
                od.IncomeDate = OrderIncomeDateInput.Text;
                od.IncomeTime = OrderIncomeTimeInput.Text;
                od.Deadline = OrderDeadlineInput.Text;
                od.OrderEdition = OrderEditionInput.Text;
                od.OrderName = OrderNameInput.Text;
                od.OrderNumber = OrderNumberInput.Text;

                //Details
                od.Customer = new Customer();
                od.Customer.Name = OrderCustomerInput.Text;
                od.Object = OrderObjectInput.Text;
                od.Editor = new User();
                od.Editor.Username = OrderEditorInput.Text;
                int n;
                bool isNumeric = int.TryParse(OrderQuantityInput.Text, out n);
                if (isNumeric)
                {
                      od.OverallQuantity = n;
                }
                od.SplitForeinLand = OrderInlandInput.Text;
                od.SplitHomeLand = OrderInlandInput.Text;
                od.RemainsToo = new Adress();
                od.RemainsToo.Name = OrderConsultantInput.Text;
                od.Foreign = OrderForeignInput.Text;
                od.AdditionalInformation = OrderInfoInput.Text;
                od.BillTo = OrderBillInput.Text;
                od.Material = OrderBillInput.Text;
                

                // Rechte Seite
                EdvActions edv = new EdvActions();
                edv.Actions = new string[6];
                edv.Actions[0] = OrderEDVJob1Input.Text;
                edv.Actions[1] = OrderEDVJob2Input.Text;
                edv.Actions[2] = OrderEDVJob3Input.Text;
                edv.Actions[3] = OrderEDVJob4Input.Text;
                edv.Actions[4] = OrderEDVJob5Input.Text;
                edv.Actions[5] = OrderEDVJob6Input.Text;

                ProductionActions pa = new ProductionActions();
                pa.Value = new string[6];
                pa.Value[0] = OrderProJob1Input.Text;
                pa.Value[1] = OrderProJob2Input.Text;
                pa.Value[2] = OrderProJob3Input.Text;
                pa.Value[3] = OrderProJob4Input.Text;
                pa.Value[4] = OrderProJob5Input.Text;
                pa.Value[5] = OrderProJob6Input.Text;
                pa.Insert = OrderInsertInput.Text;
                pa.InsertKind = OrderInsertKindInput.Text;
                pa.Kuvert = kuvertierenCBInput.Checked;
                pa.Ink = inkenCBInput.Checked;
                pa.folieren = folierenCBInput.Checked;

                Order order = new Order();
                order.ProductionActions = pa;
                order.EdvActions = edv;
                order.Details = od;

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
