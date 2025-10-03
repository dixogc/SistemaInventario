using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaInventario.AccesoDatos
{
    internal class ConexionBD
    {
        private static string baseDeDatos = "Data Source=(localdb)\\MSSQLLocalDB;Database=almacen;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;TrustServerCertificate=False;Application Name=\"SQL Server Management Studio\"";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(baseDeDatos);
        }
    }
}
