using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaInventario.Modelos;

namespace SistemaInventario.AccesoDatos
{
    internal class UbicacionDA
    {
        public static int CrearUbicacion(int idSeccion, int idEstante, string descripcion)
        {
            int idGenerado = -1;
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                string query = "INSERT INTO ubicacion (seccion_id, estante_id, descripcion) OUTPUT INSERTED.id VALUES (@s, @e, @d)";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@s", idSeccion);
                cmd.Parameters.AddWithValue("@e", idEstante);
                cmd.Parameters.AddWithValue("d", descripcion ?? string.Empty);
                idGenerado = (int) cmd.ExecuteScalar();
            }
            return idGenerado;
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

        public static int ObtenerUbicacionId(int idSeccion, int idEstante)
        {
            Ubicacion ubicacion = null;
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                string query = "SELECT id, seccion_id, estante_id, descripcion FROM ubicacion WHERE seccion_id = @s AND estante_id = @e";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@s", idSeccion);
                cmd.Parameters.AddWithValue("@e", idEstante);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ubicacion = new Ubicacion
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Seccion = reader.GetInt32(reader.GetOrdinal("seccion_id")),
                            Estante = reader.GetInt32(reader.GetOrdinal("estante_id")),
                            Descripcion = reader.GetString(reader.GetOrdinal("descripcion"))
                        };
                    }
                }
            }
            if (ubicacion != null)
            {
                return ubicacion.Id;
            }
            else return -1;
        }

        public static List<Seccion> ObtenerSeccionesUbicacion()
        {
            List<Seccion> secciones = new List<Seccion>();
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                string query = "SELECT id, nombre FROM secciones";
                SqlCommand cmd = new SqlCommand (query, conexion);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        secciones.Add(new Seccion
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Nombre = reader.GetString(reader.GetOrdinal("nombre"))
                        });
                    }
                }
            }
            return secciones;
        }

        public static List<Estante> ObtenerEstantesUbicacion()
        {
            List<Estante> estantes = new List<Estante>();
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                string query = "SELECT id, nombre FROM estantes";
                SqlCommand cmd = new SqlCommand (query, conexion);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        estantes.Add(new Estante
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Nombre = reader.GetString(reader.GetOrdinal("nombre"))
                        });
                    }
                }

            }
            return estantes;
        }
    }
}
