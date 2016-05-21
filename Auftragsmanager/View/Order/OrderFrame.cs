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
using View.ViewUtilities;

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

            FormValidation order = new FormValidation();

            order.AddRule(OrderNameInput, "Name ist mindestens 5 Zeichen lang", m => m.Text.Length >= 5);
            order.AddRule(OrderNameInput, "Muss ausgefüllt werden.", m => m.Text.Length >= 10);

            if (order.Validate())
            {
                Console.WriteLine("test");
            }


        }

    }
}
