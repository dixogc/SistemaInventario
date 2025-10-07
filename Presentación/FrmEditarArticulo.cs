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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaInventario.Presentación
{
    public partial class FrmEditarArticulo : Form
    {
        public FrmEditarArticulo(Articulo articulo)
        {
            InitializeComponent();
            int ubicacionId = articulo.Ubicacion;
            int seccion = UbicacionDA.ObtenerSeccionPorIdUbicacion(ubicacionId);
            int estante = UbicacionDA.ObtenerEstantePorIdUbicacion(ubicacionId);
            txtNombre.Text = articulo.Nombre;
            txtDescripcion.Text = articulo.Descripcion;
            cbCategoria.SelectedValue = articulo.Subcategoria;
            cbSeccion.SelectedValue = seccion;
            cbEstante.SelectedValue = estante;
        }

        private void FrmEditarArticulo_Load(object sender, EventArgs e)
        {
            cbCategoria.DataSource = CategoriaDA.ObtenerTodasLasSubCategorias();
            cbCategoria.DisplayMember = "Nombre";
            cbCategoria.ValueMember = "Id";

            cbSeccion.DataSource = UbicacionDA.ObtenerSeccionesUbicacion();
            cbSeccion.DisplayMember = "Nombre";
            cbSeccion.ValueMember = "Id";

            cbEstante.DataSource = UbicacionDA.ObtenerEstantesUbicacion();
            cbEstante.DisplayMember = "Nombre";
            cbEstante.ValueMember = "Id";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
