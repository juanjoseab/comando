using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace comando.Controllers
{
    public class Datos
    {
        SqlConnection conexion;
       public  String[] roles = new String[6];

        public Datos()  
        {
            roles[1] = "Super Administrador";
            roles[2] = "Administrador";
            roles[3] = "Operador";
            roles[4] = "Mayorista";
            roles[5] = "Cliente";
        }

        private void conectar()
        {
            
            String direccion = "server=GISIELA-HP\\SQLEXPRESS;" +
                                 "Trusted_Connection=yes;" +
                                 "database=comando.Models.modeloDbContext;" +
                                 "connection timeout=15";
            conexion = new SqlConnection(direccion);
            try
            {
                conexion.Open();
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
         

        }

        private void desconectar()
        {
            conexion.Close();

        }

        public int getID(int codigo) 
        {
            conectar();
            String tmp ="";
            int respuesta = 0;
            SqlDataReader lector = null;
            String query = "SELECT ID FROM roles WHERE name LIKE '" + roles[codigo] + "'";
            SqlCommand comand = new SqlCommand(query, conexion);
            lector = comand.ExecuteReader();
            while (lector.Read())
            {
                tmp = lector[0].ToString();
            }
            desconectar();
            respuesta = Convert.ToInt16(tmp);
            return respuesta;
        }

        public String getnameRol(int id) 
        {
            string respuesta = "";
            conectar();
            SqlDataReader lector = null;
            string query = "select name from roles where ID ="+id;
            SqlCommand comand = new SqlCommand(query, conexion);
            lector = comand.ExecuteReader();
            while (lector.Read())
            {
                respuesta = lector[0].ToString();
            }
            desconectar();
            return respuesta;
        }
        //CIERRA LA CLASE 
    }
}