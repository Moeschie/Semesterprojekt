using Repository.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.OrderSelectFilterInput.Text = _unit.Session.GetSessionUser().Username;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormClosing += closeEvent;
            this.Show();

            if (_unit.Session.Access(2))
                Console.WriteLine("Access");
            {
            }
        }

        private void closeEvent(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void TestOrderFrameBtn_Click_1(object sender, EventArgs e)
        {
            OrderFrame order = new OrderFrame(_unit);
            order.Show();
        }

        private void TestLoginFrameBtn_Click_1(object sender, EventArgs e)
        {
            LoginFrame login = new LoginFrame(_unit);
            login.Show();
        }

        private void TestMaschineFrameBtn_Click_1(object sender, EventArgs e)
        {
            MaschineFrame maschine = new MaschineFrame(_unit);
            maschine.Show();
        }
    }
}
