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
            comboBox1.DataSource = CategoriaDA.ObtenerTodasLasSubCategorias();
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Id";

            comboBox2.DataSource = UbicacionDA.ObtenerSeccionesUbicacion();
            comboBox2.DisplayMember = "Nombre";
            comboBox2.ValueMember = "Id";

            comboBox3.DataSource = UbicacionDA.ObtenerEstantesUbicacion();
            comboBox3.DisplayMember = "Nombre";
            comboBox3.ValueMember = "Id";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idCategoria = (int)comboBox1.SelectedValue;
            int idSeccion = (int)comboBox2.SelectedValue;
            int idEstante = (int)comboBox3.SelectedValue;
            int idUbicacion = UbicacionDA.ObtenerUbicacionId(idSeccion, idEstante);
            if(idUbicacion == -1)
            {
                idUbicacion = UbicacionDA.CrearUbicacion(idSeccion, idEstante, "");
            }

            Articulo art = new Articulo
            {
                Nombre = textBox2.Text,
                Descripcion = textBox3.Text,
                Stock = int.Parse(textBox4.Text),
                Subcategoria = idCategoria,
                Ubicacion = idUbicacion

            };

            ArticuloValid service = new ArticuloValid();
            bool articuloExiste = ArticuloDA.ComprobarExistenciaDeArticulo(art.Nombre);
            service.RegistrarArticuloService(art, articuloExiste);

        }
    

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
