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
    public partial class EditMashine : Form
    {
        private Unit _unit;
        private static EditMashine instance;

        private EditMashine(Unit unit)
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
        public static EditMashine Instance(Unit unit)
        {

            if (instance == null)
            {
                instance = new EditMashine(unit);
            }
            instance.BringToFront();
            return instance;

        }

        private void EditMashineNameButton_Click(object sender, EventArgs e)
        {
            // TODO:  Update Mashine Name in DB
        }
    }
}
