using SistemaInventario.AccesoDatos;
using SistemaInventario.LogicaNegocio;
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
using static SistemaInventario.AccesoDatos.ArticuloDA;
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

            cbSeccion.DataSource = UbicacionDA.ObtenerCatalogoUbicacion("Seccion");
            cbSeccion.DisplayMember = "Nombre";
            cbSeccion.ValueMember = "Id";

            cbEstante.DataSource = UbicacionDA.ObtenerCatalogoUbicacion("Estante");
            cbEstante.DisplayMember = "Nombre";
            cbEstante.ValueMember = "Id";

            Ubicacion ubicacion = UbicacionDA.BuscarUbicacion(articulo.Ubicacion);
            if (ubicacion != null)
            {
                cbSeccion.SelectedValue = ubicacion.Seccion;
                cbEstante.SelectedValue = ubicacion.Estante;
            }

            txtNombre.Text = articulo.Nombre;
            txtMarca.Text = articulo.Marca;
            txtModelo.Text = articulo.Modelo;
            txtMedidas.Text = articulo.Medidas;
            txtCapacidad.Text = articulo.Capacidad;
            txtCaracteristicaE.Text = articulo.CaracteristicaExtra;
            cbCategoria.SelectedValue = articulo.Subcategoria;
            txtTipo.Text = articulo.Tipo;
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public event Action ArticuloEditado;

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int idSubcategoria = (int)cbCategoria.SelectedValue;
            int idSeccion = (int)cbSeccion.SelectedValue;
            int idEstante = (int)cbEstante.SelectedValue;

            Ubicacion ubicacion = UbicacionDA.BuscarUbicacion(null, idSeccion, idEstante);
            int idUbicacion = ubicacion?.Id ?? -1;

            if (idUbicacion == -1)
            {
                idUbicacion = UbicacionDA.CrearUbicacion(idSeccion, idEstante, "");
            }

            bool siHayCambios =
                txtNombre.Text != articuloOriginal.Nombre ||
                txtMarca.Text != articuloOriginal.Marca ||
                txtModelo.Text != articuloOriginal.Modelo ||
                txtMedidas.Text != articuloOriginal.Medidas ||
                txtCapacidad.Text != articuloOriginal.Capacidad ||
                txtCaracteristicaE.Text != articuloOriginal.CaracteristicaExtra ||
                txtTipo.Text != articuloOriginal.Tipo ||
                idSubcategoria != articuloOriginal.Subcategoria ||
                idUbicacion != articuloOriginal.Ubicacion;

            if (siHayCambios)
            {
                Articulo articuloEditado = new Articulo
                {
                    Id = articuloOriginal.Id,
                    Nombre = txtNombre.Text.ToUpperInvariant(),
                    Subcategoria = idSubcategoria,
                    Ubicacion = idUbicacion,
                    Marca = txtMarca.Text.ToUpperInvariant(),
                    Modelo = txtModelo.Text.ToUpperInvariant(),
                    Medidas = txtMedidas.Text.ToUpperInvariant(),
                    Capacidad = txtCapacidad.Text.ToUpperInvariant(),
                    CaracteristicaExtra = txtCaracteristicaE.Text.ToUpperInvariant(),
                    Tipo = txtTipo.Text.ToUpperInvariant()
                };

                TipoCoincidencia coincidencia = ArticuloDA.ValidarArticuloExistente(articuloEditado);

                ArticuloValid service = new ArticuloValid();
                bool resultado = service.EditarArticuloService(articuloEditado, coincidencia);

                if (resultado)
                {
                    MessageBox.Show("Artículo editado con éxito");
                    ArticuloEditado?.Invoke();
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Edita los campos del artículo para actualizar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
