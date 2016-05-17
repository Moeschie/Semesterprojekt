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
            using (var data = new Unit(new DataContext()))
            {
                var users = data.User.GetAll();

                var albert = new Repository.Model.User();
                    albert.Id = 1;
                    albert.Name = "Albert";

                data.User.Add(albert);
                data.Complete();

                foreach(var user in users)
                    Console.Write(user.Name);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainFrame());
            }
        }
    }
}
