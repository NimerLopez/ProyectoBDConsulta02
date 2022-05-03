using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBDConsulta02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void addformulario(Form f)
        {
            if (this.Paneldatos.Controls.Count > 0)
            {
                this.Paneldatos.Controls.RemoveAt(0);
            }
           
            f.TopLevel = false;
            this.Paneldatos.Controls.Add(f);
            f.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //AbrirFormHija(new ProyectoBDConsulta02.Consultas());
            Consultas f=new Consultas();
            addformulario(f);


        }

        private void AbrirFormHija_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Paneldatos_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btngrafica_Click(object sender, EventArgs e)
        {
            Graficas f = new Graficas();
            addformulario(f);
        }
    }
}
