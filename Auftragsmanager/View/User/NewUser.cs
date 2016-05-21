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
        }

        private void AddNewUserButton_Click(object sender, EventArgs e)
        {
            FormValidation f = new FormValidation();
            TextStrings t = new TextStrings();

            f.AddRule(UsernameTextBox, t.ENTRY_REQUIRED);
            f.AddRule(NameTextBox, t.ENTRY_REQUIRED);
            f.AddRule(LastNameTextBox, t.ENTRY_REQUIRED);
      
            f.AddRule(PasswordTextBox, t.ENTRY_REQUIRED);

            if (f.Validate())
            {
                User newUser = new User();
                newUser.Username = UsernameTextBox.Text;

                Console.WriteLine(UserRightsSelect.Text);
            }


        }
    }
}
