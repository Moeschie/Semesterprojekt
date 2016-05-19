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
        public MainFrame()
        {
            InitializeComponent();
        }
        private void TestOrderFrameBtn_Click(object sender, EventArgs e)
        {
            OrderFrame order = new OrderFrame();
            order.Show();
        }

        private void TestLoginFrameBtn_Click(object sender, EventArgs e)
        {
            LoginFrame login = new LoginFrame();
            login.Show();
        }

        private void TestMaschineFrameBtn_Click(object sender, EventArgs e)
        {
            MaschineFrame maschine = new MaschineFrame();
            maschine.Show();
        }
    }
}
