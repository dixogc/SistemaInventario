using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SistemaInventario.AccesoDatos
{
    internal class ConexionBD
    {
        private static string baseDeDatos = "server=localhost;user=root;password=4305;database=almacen;";

        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(baseDeDatos);
        }
    }
}
