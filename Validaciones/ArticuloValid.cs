using SistemaInventario.AccesoDatos;
using SistemaInventario.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInventario.LogicaNegocio
{
    internal class ArticuloValid
    {
        public void RegistrarArticuloService(Articulo art, bool articuloExiste)
        {
            if (string.IsNullOrWhiteSpace(art.Nombre))
                MessageBox.Show("El nombre es obligatorio");
            if (string.IsNullOrWhiteSpace(art.Descripcion))
                MessageBox.Show("La descripcion es obligatoria");
            if (art.Stock < 0)
                MessageBox.Show("El stock debe ser mayor que cero");
            if (articuloExiste == true)
            {
                MessageBox.Show("El articulo ya existe");

            }
            else ArticuloDA.InsertarArticulo(art);
        }

        public void ObtenerArticuloService(int idArticulo)
        {
            if (idArticulo != 0)
            {
                ArticuloDA.ObtenerArticuloPorId(idArticulo);
            }
        }

        public void ObtenerListaArticulosService(string nombreArticulos)
        {
            if (string.IsNullOrWhiteSpace(nombreArticulos))
            {
                throw new Exception("La barra de búsqueda no puede estar vacía");
            }
            ArticuloDA.ObtenerArticulosPorNombre(nombreArticulos);
        }

        public void ActualizarStockService(Articulo articulo)
        {
            int stockActualizado = ArticuloDA.ObtenerStockActual(articulo.Id) + articulo.Stock;
        }
    }
}
