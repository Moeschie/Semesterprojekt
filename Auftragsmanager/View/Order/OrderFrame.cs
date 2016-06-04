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
     
        public OrderFrame(Unit unit)
        {
            _unit = unit;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AddOrder(object sender, EventArgs e)
        {

            FormValidation f = new FormValidation();
            TextStrings t = new TextStrings();

            if (f.Validate())
            {

                //Linke Seite
                OrderDetails od = new OrderDetails();
                od.Customer.Name = OrderCustomerInput.Text;
                od.Object = OrderObjectInput.Text;
                od.Editor.Username = OrderEditorInput.Text;
                od.OverallQuantity = int.Parse(OrderQuantityInput.Text);
                od.SplitForeinLand = OrderInlandInput.Text;
                od.SplitHomeLand = OrderInlandInput.Text;
                od.RemainsToo.Name = OrderConsultantInput.Text;
                od.Foreign = OrderForeignInput.Text;
                od.AdditionalInformation = OrderInfoInput.Text;
                od.BillTo = OrderBillInput.Text;
                od.Material = OrderBillInput.Text;

                // Rechte Seite
                EdvActions edv = new EdvActions();
                edv.Actions[0] = OrderEDVJob1Input.Text;
                edv.Actions[1] = OrderEDVJob2Input.Text;
                edv.Actions[2] = OrderEDVJob3Input.Text;
                edv.Actions[3] = OrderEDVJob4Input.Text;
                edv.Actions[4] = OrderEDVJob5Input.Text;
                edv.Actions[5] = OrderEDVJob6Input.Text;

                ProductionActions pa = new ProductionActions();
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


            }


        }

        private void OrderDataButton_Click(object sender, EventArgs e)
        {
            FilebrowserFrame filebrowserframe = FilebrowserFrame.Instance(_unit);
            filebrowserframe.Show();

        }
    }
}
