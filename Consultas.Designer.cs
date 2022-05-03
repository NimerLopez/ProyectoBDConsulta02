namespace ProyectoBDConsulta02
{
    partial class Consultas
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
            this.dgvgenero = new System.Windows.Forms.DataGridView();
            this.Genero = new System.Windows.Forms.CheckedListBox();
            this.btngenero = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.estado = new System.Windows.Forms.CheckedListBox();
            this.btnestado = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.educacion = new System.Windows.Forms.CheckedListBox();
            this.btneduacion = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dia = new System.Windows.Forms.CheckedListBox();
            this.btndia = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tcliente = new System.Windows.Forms.CheckedListBox();
            this.btntipocl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgenero)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvgenero
            // 
            this.dgvgenero.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgvgenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgenero.GridColor = System.Drawing.Color.DodgerBlue;
            this.dgvgenero.Location = new System.Drawing.Point(43, 515);
            this.dgvgenero.Name = "dgvgenero";
            this.dgvgenero.Size = new System.Drawing.Size(1388, 279);
            this.dgvgenero.TabIndex = 0;
            // 
            // Genero
            // 
            this.Genero.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Genero.CheckOnClick = true;
            this.Genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genero.FormattingEnabled = true;
            this.Genero.Items.AddRange(new object[] {
            "F",
            "M"});
            this.Genero.Location = new System.Drawing.Point(29, 84);
            this.Genero.Name = "Genero";
            this.Genero.Size = new System.Drawing.Size(178, 199);
            this.Genero.TabIndex = 1;
            this.Genero.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btngenero
            // 
            this.btngenero.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btngenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenero.Location = new System.Drawing.Point(29, 19);
            this.btngenero.Name = "btngenero";
            this.btngenero.Size = new System.Drawing.Size(178, 47);
            this.btngenero.TabIndex = 2;
            this.btngenero.Text = "Genero";
            this.btngenero.UseVisualStyleBackColor = false;
            this.btngenero.Click += new System.EventHandler(this.btngenero_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.Genero);
            this.panel1.Controls.Add(this.btngenero);
            this.panel1.Location = new System.Drawing.Point(43, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 309);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.estado);
            this.panel2.Controls.Add(this.btnestado);
            this.panel2.Location = new System.Drawing.Point(296, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 309);
            this.panel2.TabIndex = 4;
            // 
            // estado
            // 
            this.estado.BackColor = System.Drawing.SystemColors.HotTrack;
            this.estado.CheckOnClick = true;
            this.estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado.FormattingEnabled = true;
            this.estado.Items.AddRange(new object[] {
            "Approved",
            "Refused",
            "Canceled",
            "Unused offer"});
            this.estado.Location = new System.Drawing.Point(29, 84);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(178, 191);
            this.estado.TabIndex = 1;
            this.estado.SelectedIndexChanged += new System.EventHandler(this.estado_SelectedIndexChanged);
            // 
            // btnestado
            // 
            this.btnestado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnestado.Location = new System.Drawing.Point(29, 19);
            this.btnestado.Name = "btnestado";
            this.btnestado.Size = new System.Drawing.Size(178, 47);
            this.btnestado.TabIndex = 2;
            this.btnestado.Text = "Estado";
            this.btnestado.UseVisualStyleBackColor = false;
            this.btnestado.Click += new System.EventHandler(this.btnestado_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.educacion);
            this.panel3.Controls.Add(this.btneduacion);
            this.panel3.Location = new System.Drawing.Point(547, 176);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 309);
            this.panel3.TabIndex = 5;
            // 
            // educacion
            // 
            this.educacion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.educacion.CheckOnClick = true;
            this.educacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.educacion.FormattingEnabled = true;
            this.educacion.Items.AddRange(new object[] {
            "Academic degree",
            "Commercial associate",
            "Higher education",
            "Incomplete higher",
            "Lower secondary",
            "Maternity leave",
            "Pensioner",
            "Secondary / secondary special",
            "State servant",
            "Working"});
            this.educacion.Location = new System.Drawing.Point(29, 84);
            this.educacion.Name = "educacion";
            this.educacion.Size = new System.Drawing.Size(178, 191);
            this.educacion.TabIndex = 1;
            this.educacion.SelectedIndexChanged += new System.EventHandler(this.educacion_SelectedIndexChanged);
            // 
            // btneduacion
            // 
            this.btneduacion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btneduacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneduacion.Location = new System.Drawing.Point(29, 19);
            this.btneduacion.Name = "btneduacion";
            this.btneduacion.Size = new System.Drawing.Size(178, 47);
            this.btneduacion.TabIndex = 2;
            this.btneduacion.Text = "Educacion_cliente";
            this.btneduacion.UseVisualStyleBackColor = false;
            this.btneduacion.Click += new System.EventHandler(this.btneduacion_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel4.Controls.Add(this.dia);
            this.panel4.Controls.Add(this.btndia);
            this.panel4.Location = new System.Drawing.Point(800, 176);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(233, 309);
            this.panel4.TabIndex = 4;
            // 
            // dia
            // 
            this.dia.BackColor = System.Drawing.SystemColors.HotTrack;
            this.dia.CheckOnClick = true;
            this.dia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dia.FormattingEnabled = true;
            this.dia.Items.AddRange(new object[] {
            "MONDAY",
            "THURSDAY",
            "WEDNESDAY",
            "SATURDAY",
            "FRIDAY",
            "SUNDAY",
            "TUESDAY"});
            this.dia.Location = new System.Drawing.Point(29, 84);
            this.dia.Name = "dia";
            this.dia.Size = new System.Drawing.Size(178, 191);
            this.dia.TabIndex = 1;
            this.dia.SelectedIndexChanged += new System.EventHandler(this.dia_SelectedIndexChanged);
            // 
            // btndia
            // 
            this.btndia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndia.Location = new System.Drawing.Point(29, 19);
            this.btndia.Name = "btndia";
            this.btndia.Size = new System.Drawing.Size(178, 47);
            this.btndia.TabIndex = 2;
            this.btndia.Text = "Dia";
            this.btndia.UseVisualStyleBackColor = false;
            this.btndia.Click += new System.EventHandler(this.btndia_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel5.Controls.Add(this.tcliente);
            this.panel5.Controls.Add(this.btntipocl);
            this.panel5.Location = new System.Drawing.Point(1063, 176);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(233, 309);
            this.panel5.TabIndex = 6;
            // 
            // tcliente
            // 
            this.tcliente.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tcliente.CheckOnClick = true;
            this.tcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcliente.FormattingEnabled = true;
            this.tcliente.Items.AddRange(new object[] {
            "XNA",
            "Cash through the bank",
            "Non-cash from your account",
            "Cashless from the account of the employer"});
            this.tcliente.Location = new System.Drawing.Point(3, 84);
            this.tcliente.Name = "tcliente";
            this.tcliente.Size = new System.Drawing.Size(227, 191);
            this.tcliente.TabIndex = 1;
            this.tcliente.SelectedIndexChanged += new System.EventHandler(this.tcliente_SelectedIndexChanged);
            // 
            // btntipocl
            // 
            this.btntipocl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btntipocl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntipocl.Location = new System.Drawing.Point(29, 19);
            this.btntipocl.Name = "btntipocl";
            this.btntipocl.Size = new System.Drawing.Size(178, 47);
            this.btntipocl.TabIndex = 2;
            this.btntipocl.Text = "Tipo_Cliente";
            this.btntipocl.UseVisualStyleBackColor = false;
            this.btntipocl.Click += new System.EventHandler(this.btntipocl_Click);
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoBDConsulta02.Properties.Resources.Nuevo_proyecto__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1496, 829);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvgenero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consultas";
            this.Text = "Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvgenero)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvgenero;
        private System.Windows.Forms.CheckedListBox Genero;
        private System.Windows.Forms.Button btngenero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckedListBox estado;
        private System.Windows.Forms.Button btnestado;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckedListBox educacion;
        private System.Windows.Forms.Button btneduacion;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckedListBox dia;
        private System.Windows.Forms.Button btndia;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckedListBox tcliente;
        private System.Windows.Forms.Button btntipocl;
    }
}