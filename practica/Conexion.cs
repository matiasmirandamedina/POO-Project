using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace practica
{
    internal class Conexion
    {
        private MySqlConnection conexion;
        private string server = "localhost";
        private string port = "3306";
        private string database = "mini_home_banking";
        private string user = "root";
        private string password = "";
        private string cadenaConexion;

        public Conexion()
        {
            cadenaConexion = $"server = {server}; port = {port}; database = {database}; user = {user}; password = {password}";
        }

        public MySqlConnection getConexion()
        {
            if (conexion == null)
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
            }

            return conexion;
        }
    }
}