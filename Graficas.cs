using ProyectoBDConsulta02.Datos;
using System;
using System.Collections;
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
    public partial class Graficas : Form
    {
        public Graficas()
        {
            InitializeComponent();
        }

        private void Graficas_Load(object sender, EventArgs e)
        {
            llenargrafico1();
            llenargrafico2();
            llenargrafico3();
            llenargrafico4();
            llenargrafico5();
        }
        private void llenargrafico1() 
        {
            ArrayList datosSalon1 = ConsultasBD.grafico1();
            chart1.Series["S1"].IsValueShownAsLabel = true;

            chart1.Series["S1"].Points.AddXY(datosSalon1[1], datosSalon1[0]);
            chart1.Series["S1"].Points.AddXY(datosSalon1[3], datosSalon1[2]);
        }
        private void llenargrafico2()
        {
            ArrayList grafico2 = ConsultasBD.grafico2();
            chart2.Series["S1"].IsValueShownAsLabel = true;

            chart2.Series["S1"].Points.AddXY(grafico2[1], grafico2[0]);
            chart2.Series["S1"].Points.AddXY(grafico2[3], grafico2[2]);
            chart2.Series["S1"].Points.AddXY(grafico2[5], grafico2[4]);
            chart2.Series["S1"].Points.AddXY(grafico2[7], grafico2[6]);
        }
        private void llenargrafico3()
        {
            ArrayList grafico3 = ConsultasBD.grafico3();
            chart3.Series["S1"].IsValueShownAsLabel = true;

            chart3.Series["S1"].Points.AddXY(grafico3[1], grafico3[0]);
            chart3.Series["S1"].Points.AddXY(grafico3[3], grafico3[2]);
            chart3.Series["S1"].Points.AddXY(grafico3[5], grafico3[4]);
            chart3.Series["S1"].Points.AddXY(grafico3[7], grafico3[6]);
            chart3.Series["S1"].Points.AddXY(grafico3[9], grafico3[8]);
            chart3.Series["S1"].Points.AddXY(grafico3[11], grafico3[10]);
            chart3.Series["S1"].Points.AddXY(grafico3[13], grafico3[12]);
        }
        private void llenargrafico4()
        {
            ArrayList grafico3 = ConsultasBD.grafico4();
            
            chart4.Series["S1"].IsValueShownAsLabel = true;

            chart4.Series["S1"].Points.AddXY(grafico3[1], grafico3[0]);
            chart4.Series["S1"].Points.AddXY(grafico3[3], grafico3[2]);
            chart4.Series["S1"].Points.AddXY(grafico3[5], grafico3[4]);
            chart4.Series["S1"].Points.AddXY(grafico3[7], grafico3[6]);
            chart4.Series["S1"].Points.AddXY(grafico3[9], grafico3[8]);
            chart4.Series["S1"].Points.AddXY(grafico3[11], grafico3[10]);
            chart4.Series["S1"].Points.AddXY(grafico3[13], grafico3[12]);
            chart4.Series["S1"].Points.AddXY(grafico3[15], grafico3[14]);
            chart4.Series["S1"].Points.AddXY(grafico3[17], grafico3[16]);
            chart4.Series["S1"].Points.AddXY(grafico3[19], grafico3[18]);
        }
        private void llenargrafico5()
        {
            ArrayList grafico5 = ConsultasBD.grafico5();

            chart5.Series["S1"].IsValueShownAsLabel = true;

            chart5.Series["S1"].Points.AddXY(grafico5[1], grafico5[0]);
            chart5.Series["S1"].Points.AddXY(grafico5[3], grafico5[2]);
            chart5.Series["S1"].Points.AddXY(grafico5[5], grafico5[4]);
            chart5.Series["S1"].Points.AddXY(grafico5[7], grafico5[6]);
        }
    }
}
