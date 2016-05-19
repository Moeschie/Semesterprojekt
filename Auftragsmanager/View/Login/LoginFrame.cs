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
            this.FormClosing += closeEvent;
            this.Show();
        }

        private void closeEvent(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string Username = this.LoginNameInput.Text;
            string Password = this.LoginPasswordInput.Text;

            if(_unit.User.Login(Username, Password))
            {
                this.Hide();
                MainFrame mainFrame = new MainFrame(_unit);
            } else
            {
                string messageText = "Password oder Benutzername sind nicht richtig!";
                string messageTitle = "Falscher Login";
                MessageBox.Show(messageText, messageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoginPasswordInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
