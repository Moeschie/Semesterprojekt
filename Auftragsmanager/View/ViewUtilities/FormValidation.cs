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
        //  internal Func<TextBox, bool> isString = m => m.Text is string;
        //  internal Func<TextBox, bool> isDateTime = m => m.Text is DateTime;
        internal Func<TextBox, bool> MinLength(int length){ return m => m.Text.Length >= length; }
        internal Func<TextBox, bool> MaxLength(int length){ return m => m.Text.Length < length; }
        internal void AddRule(TextBox box, string message, Func<TextBox, bool> condition)
        {
            if (!condition(box) && validate)
                validate = false;
        }
        internal void AddRule(TextBox box, string message){ AddRule(box, message, MinLength(1)); }

        internal bool Validate()
        {
            MessageBox.Show("", @"Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return validate;
        }
    }
}
