using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeArchivos
{
    public partial class Detalle : Form
    {
        public TreeNode Node { get; set; }

        public Detalle()
        {
            InitializeComponent();
        }

        private void Detalle_Load(object sender, EventArgs e)
        {
            try
            {
                var fileinfo = new FileInfo(Node.FullPath);

                using (var uow = new UnitOfWork())
                {
                    var arch = uow.Session.Query<Archivo>().Single(x => x.Nombre == Path.GetFileNameWithoutExtension(fileinfo.Name));

                    txtDocumento.Text = arch.Nombre;
                    txtTipo.Text = arch.Tipo;
                    txtDesc.Text = arch.Desc;
                    txtVigencia.Text = arch.Vigencia;
                    txtEstado.Text = arch.Estado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay informacion sobre este archivo o ha ocurrido un error inexperado", "Alert", MessageBoxButtons.OK);
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAbrirArch_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Node.FullPath);
        }
    }
}
