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
    public partial class AddDefect : Form
    {
        private Unit _unit;
        private static AddDefect instance;

        private AddDefect(Unit unit)
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
                AddDefectSelectMashineComboBox.Items.Add(machine.Name);
            }
        }

        private void closeEvent(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        public static AddDefect Instance(Unit unit)
        {
            if (instance == null)
            {
                instance = new AddDefect(unit);
            }
            instance.BringToFront();
            return instance;
        }

        private void AddDefectSubmitButton_Click(object sender, EventArgs e)
        {
            FormValidation f = new FormValidation();
            f.AddRule(AddDefectTitleTextBox, "Sie müssen einen Maschinennamen eintragen.", f.MinLength(1));
            MachineTask machinetask = new MachineTask();
            machinetask.Id = Guid.NewGuid();
            machinetask.title = AddDefectTitleTextBox.Text;
            machinetask.UsageStart = AddDefectStartDateTimePicker.Text;
            machinetask.UsageEnd = AddDefectEndDateTimePicker.Text;
            machinetask.Machine = _unit.Machine.GetAll().Where(u => u.Name == AddDefectSelectMashineComboBox.Text).FirstOrDefault();//Select(u => u.Name == AddDefectSelectMashineComboBox.Text).Single();
            if (f.Validate())
            {
            _unit.MachineTask.Add(machinetask);
            _unit.Complete();
            Close();

            }
        }
    }
}

