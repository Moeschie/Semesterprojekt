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
using System.IO;

namespace Repository.Persistence
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        int count = 0;
        DataContext _context;
        public OrderRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public Order GetOrderById(Guid id)
        {
            return new Order();
        }

        public Order GetUserWithId(int id)
        {
            throw new NotImplementedException();
        }

        public void PrintOrder(String orderID, bool type)
        {
            string file = "";
            if (type) file = "Laufzettel";
            else file = "Auftrag";


            orderID = SplitOrderID(orderID);
            HtmlToPdf converter = new HtmlToPdf();
            converter.Options.PdfPageOrientation = PdfPageOrientation.Landscape;
            Order o = GetOrderById(orderID);
            PdfDocument doc = converter.ConvertHtmlString(OrderPrintTemplate.GetHtmlTemplate(o, type), null);
            doc.Save(Path.Combine(ConfigurationSettings.AppSettings["Path"], orderID, file+"_"+orderID+".pdf"));
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
            string[] orderIDArr = orderID.Split('-');
            if (orderIDArr[2].Length < 2) orderIDArr[2] = "0" + orderIDArr[2];
            if (orderIDArr[2].Length < 3) orderIDArr[2] = "0" + orderIDArr[2];

            orderID = orderIDArr[0] + "-" + orderIDArr[1] + "-" + orderIDArr[2];

            return orderID;
        }
        public Order GetOrderById(string orderID)
        {
            orderID = SplitOrderID(orderID);
            if (orderExists(orderID))
            {
                return GetAllByGroup().Where(u => u.OrderDetails.OrderNumber == orderID).First();
            }
            return null;
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
            var sortedDict = from entry in dic orderby entry.Key descending select entry;
            list.Clear();
            foreach (KeyValuePair<int, Order> entry in sortedDict)
            {
                list.Add(entry.Value);
            }
            return list;
        }
        public bool Occupied(string orderID)
        {
            if (orderExists(orderID))
                return GetOrderById(orderID).Occupied;

            return false;
        }
        public void SetOccupied(string orderID)
        {
            if (orderExists(orderID))
            { 
                GetOrderById(orderID).Occupied = !GetOrderById(orderID).Occupied;
                _context.SaveChanges();   
            }
        }
        public bool orderExists(string orderID)
        {
            if (GetAll().Where(o => o.OrderDetails.OrderNumber == orderID).Count() > 0)
                return true;
            return false;
        }

        public string SplitOrderID(string orderID)
        {
            string[] substring = orderID.Split('|');
            return substring[0].Replace(" ", string.Empty);
        }
    }
}