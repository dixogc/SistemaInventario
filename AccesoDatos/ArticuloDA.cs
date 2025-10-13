using SistemaInventario.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#nullable enable

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
                SqlCommand cmd = new SqlCommand("InsertarArticulo", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", art.Nombre);
                cmd.Parameters.AddWithValue("@Marca", (object?)art.Marca ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Modelo", (object?)art.Modelo ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Medidas", (object?)art.Medidas ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Capacidad", (object?)art.Capacidad ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CaracteristicaExtra", (object?)art.CaracteristicaExtra ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Stock", art.Stock);
                cmd.Parameters.AddWithValue("@SubcategoriaId", art.Subcategoria);
                cmd.Parameters.AddWithValue("@UbicacionId", art.Ubicacion);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Artículo guardado");
            }
        }

        //READ

        public enum TipoCoincidencia
        {
            Ninguna,
            Exacta,
            Atributos
        }

        public static TipoCoincidencia ValidarArticuloExistente(Articulo art)
        {
            using SqlConnection conexion = ConexionBD.ObtenerConexion();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("ValidarArticuloExistente", conexion)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@Id", art.Id);
            cmd.Parameters.AddWithValue("@Nombre", art.Nombre);
            cmd.Parameters.AddWithValue("@Marca", (object?)art.Marca ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Modelo", (object?)art.Modelo ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Medidas", (object?)art.Medidas ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Capacidad", (object?)art.Capacidad ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@CaracteristicaExtra", (object?)art.CaracteristicaExtra ?? DBNull.Value);

            using SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string tipo = reader.GetString(reader.GetOrdinal("TipoCoincidencia"));
                return tipo == "Exacto" ? TipoCoincidencia.Exacta : TipoCoincidencia.Atributos;
            }

            return TipoCoincidencia.Ninguna;
        }

        public static List<Articulo> ObtenerTodosLosArticulos()
        {
            List<Articulo> articulos = new();
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                SqlCommand cmd = new("ObtenerTodosLosArticulos", conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };

                using SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    articulos.Add(new Articulo
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                        Marca = reader["Marca"] as string,
                        Modelo = reader["Modelo"] as string,
                        Medidas = reader["Medidas"] as string,
                        Capacidad = reader["Capacidad"] as string,
                        CaracteristicaExtra = reader["Caracteristica_extra"] as string,
                        Stock = reader.GetInt32(reader.GetOrdinal("Stock")),
                        Subcategoria = reader.GetInt32(reader.GetOrdinal("Subcategoria_id")),
                        Ubicacion = reader.GetInt32(reader.GetOrdinal("Ubicacion_id"))
                    });
                }
            }
            return articulos;
        }

        public static List<Articulo> BuscarArticulos(string? nombre, int? idCategoria, int? idSubcategoria)
        {
            List<Articulo> articulos = new();
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("BuscarArticulos", conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@Nombre", (object?)nombre ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@IdCategoria", (object?)idCategoria ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@IdSubcategoria", (object?)idSubcategoria ?? DBNull.Value);

                using SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    articulos.Add(new Articulo
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                        Marca = reader["Marca"] as string,
                        Modelo = reader["Modelo"] as string,
                        Medidas = reader["Medidas"] as string,
                        Capacidad = reader["Capacidad"] as string,
                        CaracteristicaExtra = reader["Caracteristica_extra"] as string,
                        Stock = reader.GetInt32(reader.GetOrdinal("Stock")),
                        Subcategoria = reader.GetInt32(reader.GetOrdinal("Subcategoria_id")),
                        Ubicacion = reader.GetInt32(reader.GetOrdinal("Ubicacion_id"))
                    });
                }
            }
            return articulos;
        }

        public static int ObtenerStockActual(int idArticulo)
        {
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("ObtenerStockActual", conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@ArticuloId", idArticulo);

                using SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetInt32(reader.GetOrdinal("Stock"));
                }
            }
            return 0;
        }

        //UPDATE
        public static Articulo ActualizarStock(int idArticulo, int cantidadCambio)
        {
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("ActualizarStock", conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@ArticuloId", idArticulo);
                cmd.Parameters.AddWithValue("@CantidadCambio", cantidadCambio);

                using SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Articulo
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                        Marca = reader["Marca"] as string,
                        Modelo = reader["Modelo"] as string,
                        Medidas = reader["Medidas"] as string,
                        Capacidad = reader["Capacidad"] as string,
                        CaracteristicaExtra = reader["Caracteristica_extra"] as string,
                        Stock = reader.GetInt32(reader.GetOrdinal("Stock")),
                        Subcategoria = reader.GetInt32(reader.GetOrdinal("Subcategoria_id")),
                        Ubicacion = reader.GetInt32(reader.GetOrdinal("Ubicacion_id"))
                    };
                }
            }
            return null;
        }

        public static Articulo ActualizarArticulo(Articulo art)
        {
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("ActualizarArticulo", conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@Id", art.Id);
                cmd.Parameters.AddWithValue("@Nombre", art.Nombre);
                cmd.Parameters.AddWithValue("@Marca", (object?)art.Marca ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Modelo", (object?)art.Modelo ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Medidas", (object?)art.Medidas ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Capacidad", (object?)art.Capacidad ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CaracteristicaExtra", (object?)art.CaracteristicaExtra ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@SubcategoriaId", art.Subcategoria);
                cmd.Parameters.AddWithValue("@UbicacionId", art.Ubicacion);

                using SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Articulo
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                        Marca = reader["Marca"] as string,
                        Modelo = reader["Modelo"] as string,
                        Medidas = reader["Medidas"] as string,
                        Capacidad = reader["Capacidad"] as string,
                        CaracteristicaExtra = reader["Caracteristica_extra"] as string,
                        Stock = reader.GetInt32(reader.GetOrdinal("Stock")),
                        Subcategoria = reader.GetInt32(reader.GetOrdinal("Subcategoria_id")),
                        Ubicacion = reader.GetInt32(reader.GetOrdinal("Ubicacion_id"))
                    };
                }
            }
            return null;
        }

    }
}
