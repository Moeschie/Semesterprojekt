using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Persistence.Templates
{
    public static class OrderPrintTemplate
    {
 
        public static string GetHtmlTemplate()
        {
            return File.ReadAllText("./printTemplate.html");
        }
    }
}
