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
    internal class CategoriaDA
    {
        public static Subcategoria ObtenerSubcategoriaPorId(int idSubcategoria)
        {
            using SqlConnection conexion = ConexionBD.ObtenerConexion();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("ObtenerSubcategoriaPorId", conexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@Id", idSubcategoria);

            using SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Subcategoria
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                    Categoria = reader.GetInt32(reader.GetOrdinal("Categoria_Id"))
                };
            }
            return null;
        }
        public static List<Subcategoria> ObtenerSubcategoriasPorIdCategoria(int idCategoria)
        {
            List<Subcategoria> subcategorias = new();
            using SqlConnection conexion = ConexionBD.ObtenerConexion();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("ObtenerSubcategoriasPorIdCategoria", conexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);

            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                subcategorias.Add(new Subcategoria
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                    Categoria = reader.GetInt32(reader.GetOrdinal("Categoria_Id"))
                });
            }
            return subcategorias;
        }

        public static List<Categoria> ObtenerTodasLasCategorias()
        {
            List<Categoria> categorias = new();
            using SqlConnection conexion = ConexionBD.ObtenerConexion();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("ObtenerTodasLasCategorias", conexion)
            {
                CommandType = CommandType.StoredProcedure
            };

            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                categorias.Add(new Categoria
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Nombre = reader.GetString(reader.GetOrdinal("Nombre"))
                });
            }
            return categorias;
        }

        public static List<Subcategoria> ObtenerTodasLasSubCategorias()
        {
            List<Subcategoria> subcategorias = new();
            using SqlConnection conexion = ConexionBD.ObtenerConexion();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("ObtenerTodasLasSubcategorias", conexion)
            {
                CommandType = CommandType.StoredProcedure
            };

            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                subcategorias.Add(new Subcategoria
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                    Categoria = reader.GetInt32(reader.GetOrdinal("Categoria_Id"))
                });
            }
            return subcategorias;
        }
    }
}
