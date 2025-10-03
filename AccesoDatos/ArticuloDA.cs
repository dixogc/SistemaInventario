using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaInventario.Modelos;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace SistemaInventario.AccesoDatos
{
    internal class ArticuloDA
    {

        //CRUD DE Artículos
        //CREATE
        public static void InsertarArticulo(Articulo art)
        {
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                //try
                //{
                    string query = "INSERT INTO articulos (nombre, descripcion, stock, subcategoria_id, ubicacion_id) VALUES (@n, @d, @s, @su, @u)";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@n", art.Nombre);
                    cmd.Parameters.AddWithValue("@d", art.Descripcion);
                    cmd.Parameters.AddWithValue("@s", art.Stock);
                    cmd.Parameters.AddWithValue("@su", art.Subcategoria);
                    cmd.Parameters.AddWithValue("@u", art.Ubicacion);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Articulo guardado");
                //}
                //catch(Exception ex)
                //{
                //    MessageBox.Show("Error, articulo no guardado");
                //}
                
            }
                
        }

        //READ

        //Devolver los articulos existentes en caso de haber resultados
        public static bool ComprobarExistenciaDeArticulo(string articuloBuscado)
        {
            bool articuloExiste = false;

            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                string query = "SELECT * FROM articulos WHERE nombre LIKE @nombreArticulo";
                SqlCommand cmd = new SqlCommand (query, conexion);
                cmd.Parameters.AddWithValue("@nombreArticulo", articuloBuscado);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        articuloExiste = true;
                    }
                }
            }
            return articuloExiste;
        }

        public static Articulo ObtenerArticuloPorId(int id)
        {
            Articulo articulos = null;
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string query = "SELECT id, nombre, descripcion, stock_actual, subcategoria_id, ubicacion_id FROM articulos WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@id", id);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        articulos = new Articulo
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id")),
                            Nombre = reader.GetString(reader.GetOrdinal("nombre")),
                            Descripcion = reader.GetString(reader.GetOrdinal("descripcion")),
                            Stock = reader.GetInt32(reader.GetOrdinal("stock")),
                            Subcategoria = reader.GetInt32(reader.GetOrdinal("Subsubcategoria_id")),
                            Ubicacion = reader.GetInt32(reader.GetOrdinal("ubicacion_id"))
                        };
                    }
                    return articulos;
                }
            }
        }

        public static List<Articulo> ObtenerArticulos(string nombreArticulo)
        {
            List<Articulo> articulos = new List<Articulo>();
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                string query = "SELECT * FROM articulos WHERE nombre LIKE @nombreBuscado";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("nombreBuscado", "%" + nombreArticulo + "%");
                
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        articulos.Add(new Articulo
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id")),
                            Nombre = reader.GetString(reader.GetOrdinal("nombre")),
                            Descripcion = reader.GetString(reader.GetOrdinal("descripcion")),
                            Stock = reader.GetInt32(reader.GetOrdinal("stock")),
                            Subcategoria = reader.GetInt32(reader.GetOrdinal("subcategoria_id")),
                            Ubicacion = reader.GetInt32(reader.GetOrdinal("ubicacion_id"))
                        });
                    }
                }
                return articulos;
            }
        }

        public static int ObtenerStockActual(int idArticulo)
        {
            int stock = 0;
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                string query = "SELECT stock FROM articulos WHERE id = @idArticulo";
                SqlCommand cmd = new SqlCommand( query, conexion);
                cmd.Parameters.AddWithValue("@id", idArticulo);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        stock = reader.GetInt32(reader.GetOrdinal("stock"));
                    }
                }
                return stock;
            }
        }

        //UPDATE
        public static Articulo ActualizarStock(int idArticulo, int stockAñadido)
        {
            Articulo articulo = null;

            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string updateQuery = "UPDATE articulos SET stock = @s WHERE id = @id";
                SqlCommand updateCmd = new SqlCommand(updateQuery, conexion);
                updateCmd.Parameters.AddWithValue("@s", stockAñadido);
                updateCmd.Parameters.AddWithValue("@id", idArticulo);
                updateCmd.ExecuteNonQuery();

                string selectQuery = "SELECT * FROM articulos WHERE id = @id";
                SqlCommand selectCmd = new SqlCommand(selectQuery, conexion);
                selectCmd.Parameters.AddWithValue("@id", idArticulo);

                using (SqlDataReader reader = selectCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        articulo = new Articulo
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id")),
                            Nombre = reader.GetString(reader.GetOrdinal("nombre")),
                            Descripcion = reader.GetString(reader.GetOrdinal("descripcion")),
                            Stock = reader.GetInt32(reader.GetOrdinal("stock_actual")),
                            Subcategoria = reader.GetInt32(reader.GetOrdinal("categoria_id")),
                            Ubicacion = reader.GetInt32(reader.GetOrdinal("ubicacion_id"))
                        };
                    }
                }
            }
            return articulo;
        }

        public static Articulo ActualizarArticulo(int idArticulo)
        {
            Articulo articulo = null;

            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string query = "UPDATE articulos SET nombre = @n, descripcion = @d, stock = @s, subcategoria_id = @c, ubicacion_id = @u WHERE id = @id";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@n", articulo.Nombre);
                cmd.Parameters.AddWithValue("@d", articulo.Descripcion);
                cmd.Parameters.AddWithValue("@s", articulo.Stock);
                cmd.Parameters.AddWithValue("@c", articulo.Subcategoria);
                cmd.Parameters.AddWithValue("@u", articulo.Ubicacion);
                cmd.Parameters.AddWithValue("@id", articulo.Id);
                cmd.ExecuteNonQuery();

                string selectQuery = "SELECT * FROM articulos WHERE id = @id";
                SqlCommand selectCmd = new SqlCommand(selectQuery, conexion);
                selectCmd.Parameters.AddWithValue("@id", idArticulo);

                using (SqlDataReader reader = selectCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        articulo = new Articulo
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id")),
                            Nombre = reader.GetString(reader.GetOrdinal("nombre")),
                            Descripcion = reader.GetString(reader.GetOrdinal("descripcion")),
                            Stock = reader.GetInt32(reader.GetOrdinal("stock_actual")),
                            Subcategoria = reader.GetInt32(reader.GetOrdinal("subcategoria_id")),
                            Ubicacion = reader.GetInt32(reader.GetOrdinal("ubicacion_id"))
                        };
                    }
                }
                return articulo;
            }
        }

    }
}
