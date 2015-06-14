using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeArchivos
{
    static class Program
    {

        public static Dictionary<string, DateTime> Categorias = new Dictionary<string, DateTime>
        {
            {"Politicas", DateTime.Now.AddYears(1)},
            {"Procedimientos", DateTime.Now.AddMonths(6)},
            {"Resoluciones", DateTime.Now.AddMonths(3)}
        };

        public static DocStore DocStore { get; set; }
            /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DocStore = new DocStore();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
