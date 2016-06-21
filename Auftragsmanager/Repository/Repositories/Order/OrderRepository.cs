using Repository.Core;
using Repository.Models;
using System.Data.Entity;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Configuration;
using SelectPdf;
using Repository.Persistence.Templates;

namespace Repository.Persistence
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        int count = 0;
        public OrderRepository(DataContext context) : base(context)
        {
        }

        public Order GetOrderById(Guid id)
        {
            return new Order();
        }

        public Order GetUserWithId(int id)
        {
            throw new NotImplementedException();
        }

        public void PrintOrder()
        {
            HtmlToPdf converter = new HtmlToPdf();
            converter.Options.PdfPageOrientation = PdfPageOrientation.Landscape;
            PdfDocument doc = converter.ConvertHtmlString(OrderPrintTemplate.GetHtmlTemplate(), null);
            doc.Save(ConfigurationSettings.AppSettings["Path"] + "test1234.pdf");
            doc.Close();
        }

        public DataContext DataContext
        {
            get { return Context as DataContext; }
        }
        public string orderIDgen()
        {
            string timeString = DateTime.Now.ToString("yyyy-MM");
            count = GetAllByGroup().Count(o => o.OrderDetails.OrderNumber.StartsWith(timeString)) + 1;
            string orderID = timeString + "-" + count; 
            return orderID;
        }

        public Order GetOrderById(string orderID)
        {
            string[] substring = orderID.Split('|');
            orderID = substring[0].Replace(" ", string.Empty);
            return GetAllByGroup().Where(u => u.OrderDetails.OrderNumber == orderID).First();

        }

        public List<Order> GetAllByGroup()
        {
            List<Order> GroupOrders = new List<Order>();
            var Groups = GetAll().GroupBy(w => w.OrderDetails.OrderNumber)
                .Select(g => new
                {
                    keyword = g.Key,
                    RecordIDs = g.Select(c => c.Id)
                }).ToList();
            foreach(var i in Groups)
            {
                string kw = i.keyword;
                List<Order> nOList = GetAll().Where(u => u.OrderDetails.OrderNumber == kw).ToList();
                Order newest = nOList.Where(u => u.Versionierung == nOList.Count).Single();
                GroupOrders.Add(newest);
            }
            return SortList(GroupOrders);
        }

        public List<Order> SortList(List<Order> list)
        {
            List<Order> tempList = list;
            Dictionary<int, Order> dic = new Dictionary<int, Order>();
            foreach (var tl in list)
            {
                string s = tl.OrderDetails.OrderNumber.Replace(" ", string.Empty);
                var lastnum = s.Split('-');
                int x;
                if(lastnum.Length >= 3)
                {
                    if(Int32.TryParse(lastnum[2], out x))
                    {
                        dic.Add(x, tl);
                    }
                }
            }
            var sortedDict = from entry in dic orderby entry.Key ascending select entry;
            Debug.WriteLine(sortedDict.Count());
            list.Clear();
            foreach (KeyValuePair<int, Order> entry in sortedDict)
            {
                list.Add(entry.Value);
            }
            return list;
        }

    }
}