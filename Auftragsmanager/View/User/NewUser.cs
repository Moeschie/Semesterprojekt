using Repository.Persistence;
using Repository.Persistence.Utilities;
using Repository.Model;
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
    public partial class NewUser : Form
    {
        Unit _unit;
        public NewUser(Unit unit)
        {
            _unit = unit;
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void AddNewUserButton_Click(object sender, EventArgs e)
        {
            FormValidation f = new FormValidation();
            TextStrings t = new TextStrings();

            f.AddRule(UsernameTextBox, t.ENTRY_REQUIRED);
            f.AddRule(NameTextBox, t.ENTRY_REQUIRED);
            f.AddRule(LastNameTextBox, t.ENTRY_REQUIRED);
            f.AddRule(PasswordTextBox, t.ENTRY_REQUIRED);

            User newUser = new User();
            newUser.Username = UsernameTextBox.Text;
            newUser.Name = NameTextBox.Text;
            newUser.LastName = LastNameTextBox.Text;
            newUser.Password = PasswordTextBox.Text;

            string UserAccess = UserRightsSelect.Text;
            newUser.AccessLevel = 0;
            if (!UserAccess.Equals("Moderator"))
                newUser.AccessLevel = 1000;

            if (f.Validate())
            {
                _unit.User.Add(newUser);
                _unit.Complete();
            }



        }
    }
}
