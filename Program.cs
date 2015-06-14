using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeArchivos
{
    class Usuario
    {
        public string Nombre { get; set; }
        public string Clave { get; set; }
    }


    static class Program
    {

        public static Dictionary<string, DateTime> Categorias = new Dictionary<string, DateTime>
        {
            {"Politicas", DateTime.Now.AddYears(1)},
            {"Procedimientos", DateTime.Now.AddMonths(6)},
            {"Resoluciones", DateTime.Now.AddMonths(3)}
        };

        public static DocStore DocStore { get; set; }

        public static string DirGestor
        {
            get { return string.Concat(AppDomain.CurrentDomain.BaseDirectory, "raiz"); }
        }

        public static string DirFileServer
        {
            get { return string.Concat(AppDomain.CurrentDomain.BaseDirectory, "FILESERVER"); }
        }

        public static Usuario UsuarioActual { get; set; }

        public static List<Usuario> Usuarios = new List<Usuario>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DocStore = new DocStore();

            Usuarios = new List<Usuario>
            {
                new Usuario{Nombre = "consultor", Clave = "1234"},
                new Usuario{Nombre = "respcarga", Clave = "1234"}
            };


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
