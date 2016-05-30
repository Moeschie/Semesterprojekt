using Repository.Model;
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
    public partial class NewMachine : Form
    {
        private Unit _unit;
        private static NewMachine instance;

        private NewMachine(Unit unit)
        {
            _unit = unit;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.FormClosing += closeEvent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        private void closeEvent(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        public static NewMachine Instance(Unit unit)
        {

            if (instance == null)
            {
                instance = new NewMachine(unit);
            }
            instance.BringToFront();
            return instance;

        }

        private void AddNewMashineButton_Click(object sender, EventArgs e)
        {
            FormValidation f = new FormValidation();
            f.AddRule(NewMashineNameTextBox, "Sie müssen einen Maschinennamen eintragen.", f.MinLength(1));

            if (f.Validate())
            {
                if (!_unit.Machine.MachineExists(NewMashineNameTextBox.Text))
                {
                    Machine machine = new Machine();
                    machine.Name = NewMashineNameTextBox.Text;

                    _unit.Machine.Add(machine);
                    _unit.Complete();
                }
                else
                {
                    MessageBox.Show("Diese Maschine ist bereits vorhanden.", @"Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
