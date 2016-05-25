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

            f.AddRule(OrderNumberInput, t.ENTRY_REQUIRED);
            f.AddRule(OrderNameInput, t.MIN_CHARS_REQUIRED("Auftrags Name", 5), f.MinLength(5));

            if (f.Validate())
            {
                Console.WriteLine("ENTRY");
            }
             

        }

        private void OrderDataButton_Click(object sender, EventArgs e)
        {
            FilebrowserFrame fframe = new FilebrowserFrame(_unit);
            fframe.Show();
        }
    }
}
