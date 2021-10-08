
namespace practica230921
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAñadir = new System.Windows.Forms.Button();
            this.txtdocumento = new System.Windows.Forms.Label();
            this.txtDocumentoId = new System.Windows.Forms.TextBox();
            this.Datos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnAñadir.Location = new System.Drawing.Point(644, 289);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(100, 28);
            this.btnAñadir.TabIndex = 0;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // txtdocumento
            // 
            this.txtdocumento.AutoSize = true;
            this.txtdocumento.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.txtdocumento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtdocumento.Location = new System.Drawing.Point(16, 121);
            this.txtdocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(23, 19);
            this.txtdocumento.TabIndex = 1;
            this.txtdocumento.Text = "ID";
            // 
            // txtDocumentoId
            // 
            this.txtDocumentoId.BackColor = System.Drawing.Color.White;
            this.txtDocumentoId.ForeColor = System.Drawing.Color.Black;
            this.txtDocumentoId.Location = new System.Drawing.Point(151, 121);
            this.txtDocumentoId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDocumentoId.Name = "txtDocumentoId";
            this.txtDocumentoId.Size = new System.Drawing.Size(132, 22);
            this.txtDocumentoId.TabIndex = 2;
            // 
            // Datos
            // 
            this.Datos.BackColor = System.Drawing.Color.White;
            this.Datos.FormattingEnabled = true;
            this.Datos.ItemHeight = 16;
            this.Datos.Location = new System.Drawing.Point(307, 108);
            this.Datos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(891, 132);
            this.Datos.TabIndex = 3;
            this.Datos.SelectedIndexChanged += new System.EventHandler(this.Datos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(16, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(16, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripcion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.White;
            this.txtTitulo.Location = new System.Drawing.Point(151, 162);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(132, 22);
            this.txtTitulo.TabIndex = 8;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.BackColor = System.Drawing.Color.White;
            this.txtdescripcion.Location = new System.Drawing.Point(151, 208);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(132, 22);
            this.txtdescripcion.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(327, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 46);
            this.label6.TabIndex = 20;
            this.label6.Text = "Orden";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1215, 554);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.txtDocumentoId);
            this.Controls.Add(this.txtdocumento);
            this.Controls.Add(this.btnAñadir);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Label txtdocumento;
        private System.Windows.Forms.TextBox txtDocumentoId;
        private System.Windows.Forms.ListBox Datos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label6;
    }
}

