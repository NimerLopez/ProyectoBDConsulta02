namespace ProyectoBDConsulta02
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btngrafica = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Paneldatos = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProyectoBDConsulta02.Properties.Resources.Nuevo_proyecto__2_;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btngrafica);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 840);
            this.panel1.TabIndex = 0;
            // 
            // btngrafica
            // 
            this.btngrafica.BackColor = System.Drawing.Color.Aqua;
            this.btngrafica.BackgroundImage = global::ProyectoBDConsulta02.Properties.Resources.diagrama;
            this.btngrafica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngrafica.Location = new System.Drawing.Point(-10, 455);
            this.btngrafica.Name = "btngrafica";
            this.btngrafica.Size = new System.Drawing.Size(176, 128);
            this.btngrafica.TabIndex = 1;
            this.btngrafica.UseVisualStyleBackColor = false;
            this.btngrafica.Click += new System.EventHandler(this.btngrafica_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.BackgroundImage = global::ProyectoBDConsulta02.Properties.Resources.base_de_datos;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(-2, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 138);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Paneldatos
            // 
            this.Paneldatos.BackgroundImage = global::ProyectoBDConsulta02.Properties.Resources.Nuevo_proyecto__2_;
            this.Paneldatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Paneldatos.Location = new System.Drawing.Point(192, 25);
            this.Paneldatos.Name = "Paneldatos";
            this.Paneldatos.Size = new System.Drawing.Size(1357, 798);
            this.Paneldatos.TabIndex = 1;
            this.Paneldatos.Paint += new System.Windows.Forms.PaintEventHandler(this.Paneldatos_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::ProyectoBDConsulta02.Properties.Resources.Nuevo_proyecto__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1561, 835);
            this.Controls.Add(this.Paneldatos);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btngrafica;
        private System.Windows.Forms.Panel Paneldatos;
        //private System.Windows.Forms.Panel AbrirFormHija;
    }
}

