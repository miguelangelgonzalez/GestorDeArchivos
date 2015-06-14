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
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var nuevo = new Nuevo();

            nuevo.Show();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            var det = new Detalle();

            det.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            var path = string.Concat(AppDomain.CurrentDomain.BaseDirectory, "raiz");
            TreeNode rootnode = new TreeNode(path);
//            rootnode.Text = "Gestor";
            DirGestor.Nodes.Add(rootnode);
            FillChildNodes(rootnode);
            DirGestor.Nodes[0].Expand();
        }

        void FillChildNodes(TreeNode node)
        {
            try
            {
                DirectoryInfo dirs = new DirectoryInfo(node.FullPath);
                foreach (DirectoryInfo dir in dirs.GetDirectories())
                {
                    TreeNode newnode = new TreeNode(dir.Name);
                    node.Nodes.Add(newnode);

                    List<FileInfo> files = new List<FileInfo>();
                    files.AddRange(dir.GetFiles("*.txt"));
                    files.AddRange(dir.GetFiles("*.docx"));
                    files.AddRange(dir.GetFiles("*.jpg"));
                    files.AddRange(dir.GetFiles("*.xlsx"));
                    files.AddRange(dir.GetFiles("*.pdf"));

                    foreach (FileInfo file in files)
                    {
                        TreeNode child = new TreeNode(file.Name);
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
    }
}
