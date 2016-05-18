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
                var users = unit.User.GetAll();
                //   var oders = unit.Order.GetOrderById();
                // var adresses = unit.Adress.GetAll();
                Random random = new Random();
                int randomNumber = random.Next(0, 100);

                var albert = new Repository.Model.User();
                    albert.Id = Guid.NewGuid();
                    albert.Name = "Albert";
                unit.User.Add(albert);
                try
                {
                    unit.Complete();
                }
                catch (Exception ec)
                {
                    Console.WriteLine(ec.Message);
                }
                

                foreach(var user in unit.User.GetAll())
                    Console.Write(user.Name);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainFrame());
            }
        }
    }
}
