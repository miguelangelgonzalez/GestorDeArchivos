using System;
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
            if (txtUser.Text == "" && txtPass.Text == "")
            {
                var form = new Consulta();

                form.Show();

                this.Hide();
            }

        }
    }
}
