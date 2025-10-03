using SistemaInventario.AccesoDatos;
using SistemaInventario.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInventario.Presentación
{
    public partial class ArticuloCard : UserControl
    {
        public ArticuloCard(Articulo articulo)
        {
            InitializeComponent();
            Subcategoria subcategoria = CategoriaDA.ObtenerSubcategoriaPorId(articulo.Subcategoria);
            string descripcionUbicacion = UbicacionDA.ObtenerDescripcionUbicacion(articulo.Ubicacion);
            lblNombre.Text = articulo.Nombre;
            lblDescripcion.Text = articulo.Descripcion;
            lblStock.Text = articulo.Stock.ToString();
            lblCategoria.Text = subcategoria.Nombre;
            lblUbicacion.Text = descripcionUbicacion;

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
