using Repository.Models;
using Repository.Persistence;
using Repository.Persistence.Utilities;
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
    public partial class EditMachine : Form
    {
        private Unit _unit;
        private static EditMachine instance;

        private EditMachine(Unit unit)
        {
            _unit = unit;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.FormClosing += closeEvent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            foreach (var machine in _unit.Machine.GetAll().ToList())
            {     
                EditMaschineSelectMaschineComboBox.Items.Add(machine.Name);
                EditMaschineSelectMaschineComboBox.SelectedItem = 1;
            }
        }
        private void closeEvent(object sender, FormClosingEventArgs e)
        {
            instance = null;
            _unit.Machine.InitGantt();
        }
        public static EditMachine Instance(Unit unit)
        {

            if (instance == null)
            {
                instance = new EditMachine(unit);
            }
            instance.BringToFront();
            return instance;

        }

        private void EditMashineNameButton_Click(object sender, EventArgs e)
        {
            FormValidation f = new FormValidation();
            f.AddRule(EditMashineNameTextBox, "Sie müssen einen Maschinennamen eintragen.", f.MinLength(1));

            if (f.Validate())
            {
                Machine machine = new Machine();                
                machine.Name = EditMashineNameTextBox.Text;
                _unit.Machine.Add(machine);
                _unit.Complete();
            }
        }
    }
}
