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

            cbSeccion.DataSource = UbicacionDA.ObtenerSeccionesUbicacion();
            cbSeccion.DisplayMember = "Nombre";
            cbSeccion.ValueMember = "Id";

            cbEstante.DataSource = UbicacionDA.ObtenerEstantesUbicacion();
            cbEstante.DisplayMember = "Nombre";
            cbEstante.ValueMember = "Id";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idCategoria = (int)cbSubcategoria.SelectedValue;
            int idSeccion = (int)cbSeccion.SelectedValue;
            int idEstante = (int)cbEstante.SelectedValue;
            int idUbicacion = UbicacionDA.ObtenerUbicacionId(idSeccion, idEstante);
            if(idUbicacion == -1)
            {
                idUbicacion = UbicacionDA.CrearUbicacion(idSeccion, idEstante, "");
            }

            Articulo art = new Articulo
            {
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Stock = int.Parse(txtCantidad.Text),
                Subcategoria = idCategoria,
                Ubicacion = idUbicacion

            };

            ArticuloValid service = new ArticuloValid();
            bool articuloExiste = ArticuloDA.ComprobarExistenciaDeArticulo(art.Nombre);
            service.RegistrarArticuloService(art, articuloExiste);

            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtCantidad.Text = "";
            cbSubcategoria.SelectedIndex = -1;
            cbSeccion.SelectedIndex = -1;
            cbEstante.SelectedIndex = -1;

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
    }
}
