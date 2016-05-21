using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Persistence.Utilities
{
    public class TextStrings
    {
        // String Klasse für häufig genutze Texte.
        public string ENTRY_REQUIRED = "Alle Felder die mit '*' gekennzeichnet sind müssen ausgefüllt werden.";

        public string MIN_CHARS_REQUIRED(string fieldname, int chars)
        {
            return fieldname +" muss mindestens " + chars.ToString() + " Zeichen lang sein.";
        }

    }
}
