using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.ViewUtilities
{
    class FormValidation
    {
        private bool validate = true;
        private string errorMessage;
        internal Func<TextBox, bool> IsInt = m =>
        {
            int value;
            bool success = int.TryParse(m.Text, out value);
            return success;
        };

        internal Func<TextBox, bool> MinLength(int length){ return m => m.Text.Length >= length; }
        internal Func<TextBox, bool> MaxLength(int length){ return m => m.Text.Length < length; }
        internal void AddRule(TextBox box, string message, Func<TextBox, bool> condition)
        {
            if (!condition(box) && validate)
            {
                validate = !validate;
                errorMessage = message;

            }
        }
        internal void AddRule(TextBox box, string message){ AddRule(box, message, MinLength(1)); }

        internal bool Validate()
        {
            if(!validate)
                MessageBox.Show(errorMessage, @"Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return validate;
        }
    }
}
