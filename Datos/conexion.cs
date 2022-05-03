using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoBDConsulta02.Datos
{
    internal class conexion
    {
        public static SqlConnection con;
        public conexion()
        {
            con = new SqlConnection("Data Source=NIMER;Initial Catalog=ProyectoaBD;Integrated Security=True");

        }
        ///METODO CONECTAR
        public static SqlConnection conectar()
        {
            try
            {
                con.Open();
                return con;
            }
            catch (Exception ex)
            {
                return null;
            }


        }//fin conectar
        public static bool desconectar()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }//fin conectar

    }
}
