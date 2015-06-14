using System;
using System.Linq;
using System.Windows.Forms;

namespace GestorDeArchivos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (Program.Usuarios.Any(x => x.Nombre == txtUser.Text && x.Clave == txtPass.Text))
            {
                Program.UsuarioActual = Program.Usuarios.First(x => x.Nombre == txtUser.Text);
                
                var form = new Consulta();

                form.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o clave incorrecta");
            }

        }
    }
}
