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
                    albert.Name = "Albert";
           
                var auftrag = new Repository.Model.Contract();
                auftrag.Name = "Auftrag";
            
                data.User.Add(albert);
                data.Contract.Add(auftrag);

                data.Complete();

                foreach (var user in users)
                    Console.Write(user.Name);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainFrame());
            }
        }
    }
}
