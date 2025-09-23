using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaInventario.Modelos;

namespace SistemaInventario.AccesoDatos
{
    internal class ArticuloDAO
    {
        public static void InsertarArticulo(Articulo art)
        {
            MySqlConnection conexion = ConexionBD.ObtenerConexion();
            conexion.Open();
            string query = "INSERT INTO articulos (nombre, descripcion, stock_actual, categoria_id, ubicacion_id) VALUES (@n, @d, @s, @c, @u)";
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@n", art.Nombre);
            cmd.Parameters.AddWithValue("@d", art.Descripcion);
            cmd.Parameters.AddWithValue("@s", art.StockActual);
            cmd.Parameters.AddWithValue("@c", art.Categoria);
            cmd.Parameters.AddWithValue("@u", art.Ubicacion);
            cmd.ExecuteNonQuery();
            conexion.Close();   
        }
    }
}
