using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace ProyectoBDConsulta02.Datos
{
    internal class ConsultasBD
    {

        public static DataTable consultargenero(string g)///consulta  por genero devuelve el dt
        {
            try
            {
                conexion conex = new conexion();
                string sql = "select * from Consulta_Genero where Genero like'" + g + "'";
                SqlCommand comando = new SqlCommand(sql, conexion.conectar());
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable tabla = new DataTable();
                tabla.Load(dr);//Permite cargar la información que lea de la bd          
                conexion.desconectar();//se desconecta
                return tabla;//retorna la tabla
            }
            catch (Exception ex)
            {
                return null;
            }


        }///fin de la consulta


        public static DataTable consultarestado(string g)///consulta  por estado devuelve el dt
        {
            try
            {
                conexion conex = new conexion();
                string sql = "select * FROM Consulta_Contrato where Estado_contrato like  '" + g + "'";
                SqlCommand comando = new SqlCommand(sql, conexion.conectar());
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable tabla = new DataTable();
                tabla.Load(dr);//Permite cargar la información que lea de la bd          
                conexion.desconectar();//se desconecta
                return tabla;//retorna la tabla
            }
            catch (Exception ex)
            {
                return null;
            }


        }///fin de la consulta


        public static DataTable consultaeducacion(string g)///consulta  por estado devuelve el dt
        {
            try
            {
                conexion conex = new conexion();
                string sql = "select * from Consulta_Educacion where Educacion like '" + g + "'";
                SqlCommand comando = new SqlCommand(sql, conexion.conectar());
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable tabla = new DataTable();
                tabla.Load(dr);//Permite cargar la información que lea de la bd          
                conexion.desconectar();//se desconecta
                return tabla;//retorna la tabla
            }
            catch (Exception ex)
            {
                return null;
            }


        }///fin de la consulta
        public static DataTable consultadia(string g)///consulta  por estado devuelve el dt
        {
            try
            {
                conexion conex = new conexion();
                string sql = "select * from Consulta_Mes where Dia_inicio like '" + g + "'";
                SqlCommand comando = new SqlCommand(sql, conexion.conectar());
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable tabla = new DataTable();
                tabla.Load(dr);//Permite cargar la información que lea de la bd          
                conexion.desconectar();//se desconecta
                return tabla;//retorna la tabla
            }
            catch (Exception ex)
            {
                return null;
            }


        }///fin de la consulta


        public static DataTable consultaTipocliente(string g)///consulta  por estado devuelve el dt
        {
            try
            {
                conexion conex = new conexion();
                string sql = "select * from Consulta_Tipo_Cliente where Tipo_cliente like '" + g + "'";
                SqlCommand comando = new SqlCommand(sql, conexion.conectar());
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable tabla = new DataTable();
                tabla.Load(dr);//Permite cargar la información que lea de la bd          
                conexion.desconectar();//se desconecta
                return tabla;//retorna la tabla
            }
            catch (Exception ex)
            {
                return null;
            }


        }///fin de la consulta

        public static ArrayList grafico1()
        {
            try
            {
                conexion conex = new conexion();
                string sql = "select * from grafico_genero";
                SqlCommand comando = new SqlCommand(sql, conexion.conectar());
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                ArrayList lista = new ArrayList();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        lista.Add(dr[0]);
                        lista.Add(dr[1]);
                    }
                }
                return lista;
                conexion.desconectar();//se desconecta

            }
            catch (Exception ex)
            {
                return null;
            }


        }///fin de la consulta
        public static ArrayList grafico2()
        {
            try
            {
                conexion conex = new conexion();
                string sql = "select COUNT(1) as Cantidad,Estado_contrato FROM Consulta_Contrato group by Estado_contrato";
                SqlCommand comando = new SqlCommand(sql, conexion.conectar());
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                ArrayList lista = new ArrayList();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        lista.Add(dr[0]);
                        lista.Add(dr[1]);
                    }
                }
                return lista;
                conexion.desconectar();//se desconecta

            }
            catch (Exception ex)
            {
                return null;
            }


        }///fin de la consulta
        public static ArrayList grafico3()
        {
            try
            {
                conexion conex = new conexion();
                string sql = "select Count(1) as Dia,Dia_inicio from Consulta_Mes group by Dia_inicio";
                SqlCommand comando = new SqlCommand(sql, conexion.conectar());
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                ArrayList lista = new ArrayList();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        lista.Add(dr[0]);
                        lista.Add(dr[1]);
                    }
                }
                return lista;
                conexion.desconectar();//se desconecta

            }
            catch (Exception ex)
            {
                return null;
            }


        }///fin de la consulta
        public static ArrayList grafico4()
        {
            try
            {
                conexion conex = new conexion();
                string sql = "select count(1),Educacion from Consulta_Educacion group by Educacion";
                SqlCommand comando = new SqlCommand(sql, conexion.conectar());
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                ArrayList lista = new ArrayList();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        lista.Add(dr[0]);
                        lista.Add(dr[1]);
                    }
                }
                return lista;
                conexion.desconectar();//se desconecta

            }
            catch (Exception ex)
            {
                return null;
            }


        }///fin de la consulta
        public static ArrayList grafico5()
        {
            try
            {
                conexion conex = new conexion();
                string sql = "select count(1),Tipo_cliente from Consulta_Tipo_Cliente group by Tipo_cliente";
                SqlCommand comando = new SqlCommand(sql, conexion.conectar());
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                ArrayList lista = new ArrayList();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        lista.Add(dr[0]);
                        lista.Add(dr[1]);
                    }
                }
                return lista;
                conexion.desconectar();//se desconecta

            }
            catch (Exception ex)
            {
                return null;
            }


        }///fin de la consulta
    }

}

