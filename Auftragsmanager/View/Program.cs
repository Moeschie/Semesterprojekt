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

                if (!unit.User.CheckUserExists("admin"))
                {
                    var admin = new Repository.Model.User();
                    admin.Password = "admin";
                    admin.Username = "admin";
                    admin.AccessLevel = 9999;
                    unit.User.Add(admin);
                    unit.Complete();
                }


                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                LoginFrame login = new LoginFrame(unit);
                Application.Run();

            }
        }

    }
}