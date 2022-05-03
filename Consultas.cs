using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBDConsulta02.Datos;

namespace ProyectoBDConsulta02
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
            Genero.Visible = false;
            estado.Visible = false;
            educacion.Visible = false;
            dia.Visible = false;
            tcliente.Visible = false;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //limpiar
            int index = Genero.SelectedIndex;
            int cout = Genero.Items.Count;
            for(int i = 0; i < cout; i++)
            {

                if(i != index)
                {
                    Genero.SetItemChecked(i,false);
                }//fin if
            }//fin for

            if(index != -1) //valida si esta vacio
            {
                string valor=Genero.Items[index].ToString();
                
                //llenar grid
                DataTable informacion = ConsultasBD.consultargenero(valor);
                if (informacion == null)
                {
                    MessageBox.Show("No se puede acceder a la información");
                    // consultado = true;
                }
                else
                {
                    dgvgenero.DataSource = informacion.DefaultView;//Toma la lista como está en la BD
                    /// consultado = false;
                }



                ///fin llenar grid





            }//fin if para validar si esta vacio



        }

        private void btngenero_Click(object sender, EventArgs e)
        {
            Genero.Visible = true;
        }

        private void btnestado_Click(object sender, EventArgs e)
        {           
            estado.Visible = true;
        }

        private void estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //limpiar
            int index = estado.SelectedIndex;
            int cout = estado.Items.Count;
            for (int i = 0; i < cout; i++)
            {

                if (i != index)
                {
                    estado.SetItemChecked(i, false);
                }//fin if
            }//fin for

            if (index != -1) //valida si esta vacio
            {
                string valor = estado.Items[index].ToString();

                //llenar grid
                DataTable informacion = ConsultasBD.consultarestado(valor);
                if (informacion == null)
                {
                    MessageBox.Show("No se puede acceder a la información");
                    // consultado = true;
                }
                else
                {
                    dgvgenero.DataSource = informacion.DefaultView;//Toma la lista como está en la BD
                    /// consultado = false;
                }



                ///fin llenar grid





            }//fin if para validar si esta vacio



        }//fin estado

        private void btneduacion_Click(object sender, EventArgs e)
        {
            educacion.Visible = true;
        }

        private void educacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //limpiar
            int index = educacion.SelectedIndex;
            int cout = educacion.Items.Count;
            for (int i = 0; i < cout; i++)
            {

                if (i != index)
                {
                    educacion.SetItemChecked(i, false);
                }//fin if
            }//fin for

            if (index != -1) //valida si esta vacio
            {
                string valor = educacion.Items[index].ToString();

                //llenar grid
                DataTable informacion = ConsultasBD.consultaeducacion(valor);
                if (informacion == null)
                {
                    MessageBox.Show("No se puede acceder a la información");
                    // consultado = true;
                }
                else
                {
                    dgvgenero.DataSource = informacion.DefaultView;//Toma la lista como está en la BD
                    /// consultado = false;
                }



                ///fin llenar grid





            }//fin if para validar si esta vacio



        }//fin educacion

        private void btndia_Click(object sender, EventArgs e)
        {
            dia.Visible = true;
        }

        private void dia_SelectedIndexChanged(object sender, EventArgs e)
        {

            //limpiar
            int index = dia.SelectedIndex;
            int cout = dia.Items.Count;
            for (int i = 0; i < cout; i++)
            {

                if (i != index)
                {
                    dia.SetItemChecked(i, false);
                }//fin if
            }//fin for

            if (index != -1) //valida si esta vacio
            {
                string valor = dia.Items[index].ToString();

                //llenar grid
                DataTable informacion = ConsultasBD.consultadia(valor);
                if (informacion == null)
                {
                    MessageBox.Show("No se puede acceder a la información");
                    // consultado = true;
                }
                else
                {
                    dgvgenero.DataSource = informacion.DefaultView;//Toma la lista como está en la BD
                    /// consultado = false;
                }



                ///fin llenar grid





            }//fin if para validar si esta vacio



        }//fin dia

        private void tcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //limpiar
            int index = tcliente.SelectedIndex;
            int cout = tcliente.Items.Count;
            for (int i = 0; i < cout; i++)
            {

                if (i != index)
                {
                    tcliente.SetItemChecked(i, false);
                }//fin if
            }//fin for

            if (index != -1) //valida si esta vacio
            {
                string valor = tcliente.Items[index].ToString();

                //llenar grid
                DataTable informacion = ConsultasBD.consultaTipocliente(valor);
                if (informacion == null)
                {
                    MessageBox.Show("No se puede acceder a la información");
                    // consultado = true;
                }
                else
                {
                    dgvgenero.DataSource = informacion.DefaultView;//Toma la lista como está en la BD
                    /// consultado = false;
                }



                ///fin llenar grid





            }//fin if para validar si esta vacio



        }

        private void btntipocl_Click(object sender, EventArgs e)
        {
            tcliente.Visible = true;
        }
        ///FIN TIPO CLIENTE

        ///fin de genero
    }
}
