using SistemaInventario.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos
{
    internal class UbicacionDA
    {
        public static int CrearUbicacion(int idSeccion, int idEstante, string descripcion)
        {
            using SqlConnection conexion = ConexionBD.ObtenerConexion();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("CrearUbicacion", conexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@SeccionId", idSeccion);
            cmd.Parameters.AddWithValue("@EstanteId", idEstante);
            cmd.Parameters.AddWithValue("@Descripcion", descripcion ?? string.Empty);

            return (int)cmd.ExecuteScalar();
        }

        public static string ObtenerDescripcionUbicacion(int ubicacionId)
        {
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                string query = @"
            SELECT 
                s.nombre AS seccion_nombre,
                e.nombre AS estante_nombre
            FROM ubicacion u
            INNER JOIN secciones s ON u.seccion_id = s.id
            INNER JOIN estantes e ON u.estante_id = e.id
            WHERE u.id = @id";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@id", ubicacionId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string seccion = reader.GetString(reader.GetOrdinal("seccion_nombre"));
                        string estante = reader.GetString(reader.GetOrdinal("estante_nombre"));
                        return $"Sección {seccion}, estante {estante}";
                    }
                }
            }

            return "Ubicación desconocida";
        }

        public static Ubicacion BuscarUbicacion(int? id = null, int? seccionId = null, int? estanteId = null)
        {
            using SqlConnection conexion = ConexionBD.ObtenerConexion();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("BuscarUbicacion", conexion)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@Id", (object?)id ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@SeccionId", (object?)seccionId ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@EstanteId", (object?)estanteId ?? DBNull.Value);

            using SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Ubicacion
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Seccion = reader.GetInt32(reader.GetOrdinal("Seccion_Id")),
                    Estante = reader.GetInt32(reader.GetOrdinal("Estante_Id")),
                    Descripcion = reader["Descripcion"] as string
                };
            }
            return null;
        }

        public static List<CatalogoSimple> ObtenerCatalogoUbicacion(string tipo)
        {
            List<CatalogoSimple> resultado = new();
            using SqlConnection conexion = ConexionBD.ObtenerConexion();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("ObtenerCatalogoUbicacion", conexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@Tipo", tipo);

            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                resultado.Add(new CatalogoSimple
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Nombre = reader.GetString(reader.GetOrdinal("Nombre"))
                });
            }
            return resultado;
        }

        public class CatalogoSimple
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
        }
    }
}
