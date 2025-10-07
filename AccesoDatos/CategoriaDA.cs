using SistemaInventario.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos
{
    internal class CategoriaDA
    {
        public static Subcategoria ObtenerSubcategoriaPorId(int idSubcategoria)
        {
            Subcategoria subcategoria = new Subcategoria();
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                string query = "SELECT id, nombre, categoria_id FROM subcategoria WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@id", idSubcategoria);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        subcategoria = new Subcategoria
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id")),
                            Nombre = reader.GetString(reader.GetOrdinal("nombre")),
                            Categoria = reader.GetInt32(reader.GetOrdinal("categoria_id"))
                        };
                    }
                }
            }
            return subcategoria;
        }
        public static List<Subcategoria> ObtenerSubcategoriasPorIdCategoria(int idCategoria)
        {
            List<Subcategoria> subcategorias = new List<Subcategoria>();
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                string query = "SELECT id, nombre, categoria_id FROM subcategoria WHERE categoria_id = @id";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@id", idCategoria);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        subcategorias.Add(new Subcategoria
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id")),
                            Nombre = reader.GetString(reader.GetOrdinal("nombre")),
                            Categoria = reader.GetInt32(reader.GetOrdinal("categoria_id"))
                        });
                    }
                }
            }
            return subcategorias;
        }

        public static List<Categoria> ObtenerTodasLasCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                string query = "SELECT id, nombre FROM categoria";
                SqlCommand cmd = new SqlCommand(query, conexion);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categorias.Add(new Categoria
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id")),
                            Nombre = reader.GetString(reader.GetOrdinal("nombre"))
                        });
                    }
                }
            }
            return categorias;
        }

        public static List<Subcategoria> ObtenerTodasLasSubCategorias()
        {
            List<Subcategoria> subcategorias = new List<Subcategoria>();
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                string query = "SELECT id, nombre, categoria_id FROM subcategoria";
                SqlCommand cmd = new SqlCommand(query, conexion);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        subcategorias.Add(new Subcategoria
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id")),
                            Nombre = reader.GetString(reader.GetOrdinal("nombre")),
                            Categoria = reader.GetInt32(reader.GetOrdinal("categoria_id"))
                        });
                    }
                }
            }
            return subcategorias;
        } 
    }
}
