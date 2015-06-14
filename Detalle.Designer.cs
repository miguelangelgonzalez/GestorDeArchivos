namespace GestorDeArchivos
{
    partial class Detalle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVigencia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAbrirArch = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de documento";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(133, 19);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.ReadOnly = true;
            this.txtDocumento.Size = new System.Drawing.Size(242, 20);
            this.txtDocumento.TabIndex = 1;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(62, 58);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(113, 20);
            this.txtTipo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo";
            // 
            // txtVigencia
            // 
            this.txtVigencia.Location = new System.Drawing.Point(244, 58);
            this.txtVigencia.Name = "txtVigencia";
            this.txtVigencia.ReadOnly = true;
            this.txtVigencia.Size = new System.Drawing.Size(131, 20);
            this.txtVigencia.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vigencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descripcion";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(15, 128);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(360, 71);
            this.txtDesc.TabIndex = 7;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(133, 220);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(242, 20);
            this.txtEstado.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estado del documento";
            // 
            // btnAbrirArch
            // 
            this.btnAbrirArch.Location = new System.Drawing.Point(15, 264);
            this.btnAbrirArch.Name = "btnAbrirArch";
            this.btnAbrirArch.Size = new System.Drawing.Size(122, 23);
            this.btnAbrirArch.TabIndex = 10;
            this.btnAbrirArch.Text = "Abrir documento";
            this.btnAbrirArch.UseVisualStyleBackColor = true;
            this.btnAbrirArch.Click += new System.EventHandler(this.btnAbrirArch_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 299);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAbrirArch);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVigencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label1);
            this.Name = "Detalle";
            this.Text = "Detalle";
            this.Load += new System.EventHandler(this.Detalle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVigencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAbrirArch;
        private System.Windows.Forms.Button button2;
    }
}