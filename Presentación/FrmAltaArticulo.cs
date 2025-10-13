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

namespace SistemaInventario.Presentación
{
    public partial class FrmAltaArticulo : Form
    {
        public FrmAltaArticulo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbSubcategoria.DataSource = CategoriaDA.ObtenerTodasLasSubCategorias();
            cbSubcategoria.DisplayMember = "Nombre";
            cbSubcategoria.ValueMember = "Id";

            cbSeccion.DataSource = UbicacionDA.ObtenerCatalogoUbicacion("Seccion");
            cbSeccion.DisplayMember = "Nombre";
            cbSeccion.ValueMember = "Id";

            cbEstante.DataSource = UbicacionDA.ObtenerCatalogoUbicacion("Estante");
            cbEstante.DisplayMember = "Nombre";
            cbEstante.ValueMember = "Id";

            cbSubcategoria.SelectedIndex = -1;
            cbSeccion.SelectedIndex = -1;
            cbEstante.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idSubcategoria = (int)cbSubcategoria.SelectedValue;
            int idSeccion = (int)cbSeccion.SelectedValue;
            int idEstante = (int)cbEstante.SelectedValue;

            Ubicacion ubicacion = UbicacionDA.BuscarUbicacion(null, idSeccion, idEstante);
            int idUbicacion = ubicacion?.Id ?? -1;

            if (idUbicacion == -1)
            {
                idUbicacion = UbicacionDA.CrearUbicacion(idSeccion, idEstante, "");
            }

            Articulo art = new Articulo
            {
                Nombre = txtNombre.Text.ToUpperInvariant(),
                Stock = int.Parse(txtCantidad.Text),
                Subcategoria = idSubcategoria,
                Ubicacion = idUbicacion,
                Marca = txtMarca.Text.ToUpperInvariant(),
                Modelo = txtModelo.Text.ToUpperInvariant(),
                Medidas = txtMedidas.Text.ToUpperInvariant(),
                Capacidad = txtCapacidad.Text.ToUpperInvariant(),
                CaracteristicaExtra = txtCaracteristicaE.Text.ToUpperInvariant()
            };

            TipoCoincidencia coincidencia = ArticuloDA.ValidarArticuloExistente(art);

            ArticuloValid service = new ArticuloValid();
            bool resultado = service.RegistrarArticuloService(art, coincidencia);

            if (resultado)
            {
                MessageBox.Show("Artículo dado de alta exitosamente");
                this.Close();
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
