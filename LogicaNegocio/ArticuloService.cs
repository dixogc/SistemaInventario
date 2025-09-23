using SistemaInventario.AccesoDatos;
using SistemaInventario.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.LogicaNegocio
{
    internal class ArticuloService
    {
        public void RegistrarArticuloService(Articulo art)
        {
            if (string.IsNullOrWhiteSpace(art.Nombre))
                throw new Exception("El nombre es obligatorio");
            if (string.IsNullOrWhiteSpace(art.Descripcion))
                throw new Exception("La descripcion es obligatoria");
            if (art.StockActual < 0)
                throw new Exception("El stock debe ser mayor que cero");
            if (string.IsNullOrWhiteSpace(art.Categoria))
                throw new Exception("La categoria es obligatoria");
            if (string.IsNullOrWhiteSpace(art.Ubicacion))
                throw new Exception("La ubicacion es obligatoria");
            ArticuloDAO.InsertarArticulo(art);
        }
    }
}
