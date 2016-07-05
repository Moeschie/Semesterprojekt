using Repository.Models;
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
 
        public static string GetHtmlTemplate(Order o)
        {
            string htmlString = File.ReadAllText("./printTemplate.html");

            htmlString = htmlString.Replace("NUMMER".setBrackets(), o.OrderDetails.OrderNumber);

            htmlString = htmlString.Replace("START".setBrackets(), o.OrderDetails.ProductionStart);
            htmlString = htmlString.Replace("ENDE".setBrackets(), o.OrderDetails.ProductionEnd);
            htmlString = htmlString.Replace("KUNDE".setBrackets(), o.OrderDetails.Customer.Name);
            htmlString = htmlString.Replace("MATERIAL".setBrackets(), o.OrderDetails.Material);
            htmlString = htmlString.Replace("VERARBEITUNG".setBrackets(), o.ProductionActions.getProductiontype());
            htmlString = htmlString.Replace("BEILAGEN".setBrackets(), o.ProductionActions.Insert);
            if (o.EdvActions.Machine.Count > 0)
            {
                htmlString = htmlString.Replace("MASCHINE".setBrackets(), o.EdvActions.Machine.First().Name);
            }
            else
            {
                htmlString = htmlString.Replace("MASCHINE".setBrackets(), "");
            }
            return htmlString;
        }


        private static string setBrackets(this string s)
        {
            return "{{" + s + "}}";            
        }
        private static string getProductiontype(this ProductionActions pa)
        {
            string s="";
            if (pa.folieren)s += "Folieren ";
            if (pa.Ink)s += "Inken ";
            if (pa.Kuvert)s += "Kuvertieren ";
            return s;
        }
    }
}
