using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repository.Persistence.Utilities
{
    public class FormValidation
    {
        private bool validate = true;
        private string errorMessage;
        public Func<TextBox, bool> IsInt = m =>
        {
            int value;
            bool success = int.TryParse(m.Text, out value);
            return success;
        };

        public Func<TextBox, bool> MinLength(int length){ return m => m.Text.Length >= length; }
        public Func<TextBox, bool> MaxLength(int length){ return m => m.Text.Length < length; }
        public void AddRule(TextBox box, string message, Func<TextBox, bool> condition)
        {
            if (!condition(box) && validate)
            {
                validate = !validate;
                errorMessage = message;

            }
        }
        public void AddRule(TextBox box, string message){ AddRule(box, message, MinLength(1)); }

        public bool Validate()
        {
            if(!validate)
                MessageBox.Show(errorMessage, @"Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return validate;
        }
    }
}
