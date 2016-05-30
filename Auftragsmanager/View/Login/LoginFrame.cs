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
    public partial class LoginFrame : Form
    {
        private Unit _unit;
        public LoginFrame(Unit unit)
        {
            _unit = unit;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormClosing += closeEvent;
            this.Show();
        }

        private void closeEvent(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginAction();
        }

        private void LoginPasswordInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                LoginAction();
            }
        }
        private void LoginAction()
        {
            string Username = LoginNameInput.Text;
            string Password = LoginPasswordInput.Text;

            if (_unit.User.Login(Username, Password) != null)
            {
                MainFrame mainFrame = new MainFrame(_unit);
                Hide();
            }
            else
            {
                string messageText = "Password oder Benutzername sind nicht richtig!";
                string messageTitle = "Falscher Login";
                MessageBox.Show(messageText, messageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

   
    }
}
