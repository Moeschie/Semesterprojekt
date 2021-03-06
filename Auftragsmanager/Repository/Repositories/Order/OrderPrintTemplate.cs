﻿using Repository.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Repository.Persistence.Templates
{
    public static class OrderPrintTemplate
    {

        public static string GetHtmlTemplate(Order o, bool type)
        {
            string htmlString = "";

            if (!type) htmlString = File.ReadAllText("./printTemplateFolder.html");
            else htmlString = File.ReadAllText("./printTemplate.html");

            return htmlString.replaceKeywords(o); ;
        }

        private static string replaceKeywords(this string htmlString, Order o)
        {


            htmlString = htmlString.Replace("NUMMER".setBrackets(), o.OrderDetails.OrderNumber);
            htmlString = htmlString.Replace("AUFTRAGNAME".setBrackets(), " - " +o.OrderDetails.OrderName);
            htmlString = htmlString.Replace("ZUSATZINFO".setBrackets(), o.OrderDetails.AdditionalInformation);
            htmlString = htmlString.Replace("START".setBrackets(), o.OrderDetails.ProductionStart);
            htmlString = htmlString.Replace("ENDE".setBrackets(), o.OrderDetails.ProductionEnd);
            htmlString = htmlString.Replace("KUNDE".setBrackets(), o.OrderDetails.Customer.Name);
            htmlString = htmlString.Replace("MATERIAL".setBrackets(), o.OrderDetails.Material);
            htmlString = htmlString.Replace("VERARBEITUNG".setBrackets(), o.ProductionActions.getProductiontype());
            htmlString = htmlString.Replace("BEILAGEN".setBrackets(), o.ProductionActions.Insert);
            htmlString = htmlString.Replace("RECHNUNG".setBrackets(), o.OrderDetails.BillTo);
            htmlString = htmlString.Replace("OBJECT".setBrackets(), o.OrderDetails.OrderName);
            htmlString = htmlString.Replace("ANSPRECHPARTNER".setBrackets(), o.OrderDetails.Consultant);
            htmlString = htmlString.Replace("EDVBEARBEITER".setBrackets(), o.OrderDetails.User.Username);
            htmlString = htmlString.Replace("MENGE".setBrackets(), o.OrderDetails.OverallQuantity.ToString());
            htmlString = htmlString.Replace("RESTE".setBrackets(), o.OrderDetails.RemainsToo);
            htmlString = htmlString.Replace("INFO".setBrackets(), o.OrderDetails.AdditionalInformation);
            htmlString = htmlString.Replace("AUSLAND".setBrackets(), o.OrderDetails.SplitForeinLand+"/"+o.OrderDetails.SplitHomeLand);

            htmlString = htmlString.Replace("Action1".setBrackets(), o.EdvActions.Actions.splitAction(0));
            htmlString = htmlString.Replace("Action2".setBrackets(), o.EdvActions.Actions.splitAction(1));
            htmlString = htmlString.Replace("Action3".setBrackets(), o.EdvActions.Actions.splitAction(2));
            htmlString = htmlString.Replace("Action4".setBrackets(), o.EdvActions.Actions.splitAction(3));
            htmlString = htmlString.Replace("Action5".setBrackets(), o.EdvActions.Actions.splitAction(4));
            htmlString = htmlString.Replace("Action6".setBrackets(), o.EdvActions.Actions.splitAction(5));

            htmlString = htmlString.Replace("ProduktionAction1".setBrackets(), o.ProductionActions.value.splitAction(0));
            htmlString = htmlString.Replace("ProduktionAction2".setBrackets(), o.ProductionActions.value.splitAction(1));
            htmlString = htmlString.Replace("ProduktionAction3".setBrackets(), o.ProductionActions.value.splitAction(2));
            htmlString = htmlString.Replace("ProduktionAction4".setBrackets(), o.ProductionActions.value.splitAction(3));
            htmlString = htmlString.Replace("ProduktionAction5".setBrackets(), o.ProductionActions.value.splitAction(4));
            htmlString = htmlString.Replace("ProduktionAction6".setBrackets(), o.ProductionActions.value.splitAction(5));

            htmlString = htmlString.Replace("kuvert".setBrackets(), o.ProductionActions.Kuvert.checkbox());
            htmlString = htmlString.Replace("inken".setBrackets(), o.ProductionActions.Ink.checkbox());
            htmlString = htmlString.Replace("folieren".setBrackets(), o.ProductionActions.folieren.checkbox());

            htmlString = htmlString.Replace("RESTE".setBrackets(), o.OrderDetails.RemainsToo);
            if (o.OrderDetails.Machine != null)
            {
                htmlString = htmlString.Replace("MASCHINE".setBrackets(), o.OrderDetails.Machine.Name);
            }
            else
            {
                htmlString = htmlString.Replace("MASCHINE".setBrackets(), "");
            }

            htmlString = htmlString.tidyUp();

            return htmlString;
        }
         
        private static string checkbox(this bool state)
        {
            if (state) return "Ja"; 
            return "Nein";
        } 

        private static string splitAction(this string s, int number)
        {
            return s.Split('|')[number];
        }
        
        private static string tidyUp(this string s){
            Regex regEx = new Regex(@"(?<={{)(.*)(?=}})");
            s = regEx.Replace(s, "");
            s = s.Replace("{{}}", "");
            return s;
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
