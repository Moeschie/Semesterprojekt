using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.ViewUtilities;

namespace View
{
    public partial class OrderFrame : Form
    {
        public OrderFrame()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void SaveOrder()
        {
            Formular order = new Formular();
            order.AddRule(OrderEDVJob1Input.Text,"EDV Job1", Formular.Rule.Equals(null));
        }


    }
}
