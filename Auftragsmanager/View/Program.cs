using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository.Persistence;

namespace View
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var unit = new Unit(new DataContext()))
            {

                //    var users = unit.User.GetAll();
                //    //   var oders = unit.Order.GetOrderById();
                //    // var adresses = unit.Adress.GetAll();

                    var albert = new Repository.Model.User();
                        albert.Name = "tester";
                        unit.User.Add(albert);
                        unit.Complete();

                    foreach(var user in unit.User.GetAll())
                        Console.WriteLine(user.Id);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainFrame());
            }
        
        }
    }
}
