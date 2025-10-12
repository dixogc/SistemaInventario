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

        private void FrmEditarArticulo_Load(object sender, EventArgs e)
        {

        }

        private Articulo articuloOriginal;

        public FrmEditarArticulo(Articulo articulo)
        {
            InitializeComponent();

            articuloOriginal = articulo;

            cbCategoria.DataSource = CategoriaDA.ObtenerTodasLasSubCategorias();
            cbCategoria.DisplayMember = "Nombre";
            cbCategoria.ValueMember = "Id";

            cbSeccion.DataSource = UbicacionDA.ObtenerSeccionesUbicacion();
            cbSeccion.DisplayMember = "Nombre";
            cbSeccion.ValueMember = "Id";

            cbEstante.DataSource = UbicacionDA.ObtenerEstantesUbicacion();
            cbEstante.DisplayMember = "Nombre";
            cbEstante.ValueMember = "Id";

            int ubicacionId = articulo.Ubicacion;
            int seccion = UbicacionDA.ObtenerSeccionPorIdUbicacion(ubicacionId);
            int estante = UbicacionDA.ObtenerEstantePorIdUbicacion(ubicacionId);
            txtNombre.Text = articulo.Nombre;
            txtDescripcion.Text = articulo.Descripcion;
            cbCategoria.SelectedValue = articulo.Subcategoria;
            cbSeccion.SelectedValue = seccion;
            cbEstante.SelectedValue = estante;

        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int idCategoria = (int)cbCategoria.SelectedValue;
            int idSeccion = (int)cbSeccion.SelectedValue;
            int idEstante = (int)cbEstante.SelectedValue;
            int idUbicacion = UbicacionDA.ObtenerUbicacionId(idSeccion, idEstante);
            if (idUbicacion == -1)
            {
                idUbicacion = UbicacionDA.CrearUbicacion(idSeccion, idEstante, "");
            }

            bool siHayCambios =
            txtNombre.Text != articuloOriginal.Nombre ||
            txtDescripcion.Text != articuloOriginal.Descripcion ||
            idCategoria != articuloOriginal.Subcategoria ||
            idUbicacion != articuloOriginal.Ubicacion;


            if (siHayCambios)
            {
                Articulo articuloEditado = new Articulo
                {
                    Id = articuloOriginal.Id, 
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text,
                    Subcategoria = idCategoria,
                    Ubicacion = idUbicacion
                };

                ArticuloDA.ActualizarArticulo(articuloEditado);
                MessageBox.Show("Artículo actualizado.");
            }
            else MessageBox.Show("Edita los campos del artículo para actualizar");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
