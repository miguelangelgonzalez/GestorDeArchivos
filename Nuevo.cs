using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeArchivos
{
    public partial class Nuevo : Form
    {
        public Nuevo()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Nuevo_Load(object sender, EventArgs e)
        {
            var rootnode = new TreeNode(Program.DirFileServer);

            fServer.Nodes.Add(rootnode);
            FillChildNodes(rootnode);
            fServer.Nodes[0].Expand();


            comboBox1.DataSource = new BindingSource(Program.Categorias, null);
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";
        }

        void FillChildNodes(TreeNode node)
        {
            try
            {
                var currentDir = new DirectoryInfo(node.FullPath);

                foreach (DirectoryInfo dir in currentDir.GetDirectories())
                {
                    var newnode = new TreeNode(dir.Name);
                    node.Nodes.Add(newnode);

                    var files = new List<FileInfo>();
                    files.AddRange(dir.GetFiles("*.txt"));
                    files.AddRange(dir.GetFiles("*.docx"));
                    files.AddRange(dir.GetFiles("*.jpg"));
                    files.AddRange(dir.GetFiles("*.xlsx"));
                    files.AddRange(dir.GetFiles("*.pdf"));

                    foreach (FileInfo file in files)
                    {
                        var child = new TreeNode(file.Name);
                        child.Tag = file; // save full path for later use
                        newnode.Nodes.Add(child);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVigencia.Text = ((KeyValuePair<string, DateTime>)comboBox1.SelectedItem).Value.ToShortDateString();
        }

        private void cbVigenciaOpcional_SelectedIndexChanged(object sender, EventArgs e)
        {
            var m = int.Parse(cbVigenciaOpcional.SelectedItem.ToString());
            txtNuevaVigencia.Text = DateTime.Now.AddMonths(m).ToShortDateString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //TOOD para ale hacer validaciones

            try
            {
                var selectedNode = fServer.SelectedNode;
                var fileInfo = new FileInfo(selectedNode.FullPath);
                var tipo = ((KeyValuePair<string, DateTime>) comboBox1.SelectedItem).Key;

                File.Copy(selectedNode.FullPath, Path.Combine(Program.DirGestor, tipo, string.Concat(txtNombre.Text, fileInfo.Extension)));
            
                using (var uow = new UnitOfWork())
                {
                    var arch = new Archivo
                    {
                        Nombre = txtNombre.Text,
                        Desc = txtDesc.Text,
                        Estado = "Pendiente de Aprobacion",
                        Tipo = tipo,
                        Vigencia = string.IsNullOrEmpty(txtNuevaVigencia.Text) ? txtVigencia.Text : txtNuevaVigencia.Text
                    };

                    uow.Session.Store(arch, Guid.NewGuid().ToString());
                    uow.Session.SaveChanges();
                }

                var res = MessageBox.Show("El archivo fue cargado con exito!", "Alert", MessageBoxButtons.OK);

                if (res == DialogResult.OK)
                {
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado", "Alert", MessageBoxButtons.OK);    
            }
            
        }
    }


}
