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
    public partial class FrmDashboard : Form
    {
        

        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            cbCategorias.SelectedIndexChanged -= cbCategorias_SelectedIndexChanged;
            cbCategorias.DataSource = CategoriaDA.ObtenerTodasLasCategorias();
            cbCategorias.DisplayMember = "Nombre";
            cbCategorias.ValueMember = "Id";
            cbCategorias.SelectedIndex = -1;
            cbCategorias.SelectedIndexChanged += cbCategorias_SelectedIndexChanged;

            ckBoxMostrarTodo.Checked = true;
            cbCategorias.Enabled = true;
            cbSubcategorias.Enabled = false;


            string articuloBuscado = txtBuscar.Text;

            List<Articulo> resultadosSinFiltro = ArticuloDA.ObtenerArticulosPorNombre(articuloBuscado);

            flowLayoutPanel1.Controls.Clear();

            foreach (var articulo in resultadosSinFiltro)
            {
                var card = new ArticuloCard(articulo);
                flowLayoutPanel1.Controls.Add(card);
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbCategorias.Enabled = false;
            cbSubcategorias.Enabled = false;

            List<Articulo> resultados = ArticuloDA.ObtenerTodosLosArticulos();

            flowLayoutPanel1.Controls.Clear();

            foreach (var articulo in resultados)
            {
                var card = new ArticuloCard(articulo);
                flowLayoutPanel1.Controls.Add(card);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            FrmAltaArticulo frmAltaArticulo = new FrmAltaArticulo();
            frmAltaArticulo.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategorias.SelectedIndex != -1)
            {
                ckBoxMostrarTodo.Checked = false;
                cbSubcategorias.Enabled = true;
                int idCategoria = (int)cbCategorias.SelectedValue;
                cbSubcategorias.DataSource = CategoriaDA.ObtenerSubcategoriasPorIdCategoria(idCategoria);
                cbSubcategorias.DisplayMember = "Nombre";
                cbSubcategorias.ValueMember = "Id";
                cbSubcategorias.SelectedIndex = -1;
            }
            else cbSubcategorias.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string articuloBuscado = txtBuscar.Text;
            int idCategoria = (int)cbCategorias.SelectedValue;

            if (cbCategorias.SelectedIndex != -1 && cbSubcategorias.SelectedIndex == -1)
            {
                List<Articulo> resultadosConCategoria = ArticuloDA.ObtenerArticulosPorCategoria(articuloBuscado, idCategoria);

                flowLayoutPanel1.Controls.Clear();

                foreach (var articulo in resultadosConCategoria)
                {
                    var card = new ArticuloCard(articulo);
                    flowLayoutPanel1.Controls.Add(card);
                }
            }
            if (cbCategorias.SelectedIndex != -1 && cbSubcategorias.SelectedIndex != -1)
            {
                int idSubcategoria = (int)cbSubcategorias.SelectedValue;
                List<Articulo> resultadosConSubcategoria = ArticuloDA.ObtenerArticulosPorSubcategoria(articuloBuscado, idSubcategoria);

                flowLayoutPanel1.Controls.Clear();

                foreach (var articulo in resultadosConSubcategoria)
                {
                    var card = new ArticuloCard(articulo);
                    flowLayoutPanel1.Controls.Add(card);
                }
            }
        }

        private void ckBoxMostrarTodo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxMostrarTodo.Checked)
            {
                cbCategorias.SelectedIndex = -1;
                cbSubcategorias.SelectedIndex = -1;
                cbSubcategorias.Enabled = false;

                string articuloBuscado = txtBuscar.Text;

                List<Articulo> resultadosSinFiltro = ArticuloDA.ObtenerArticulosPorNombre(articuloBuscado);

                flowLayoutPanel1.Controls.Clear();

                foreach (var articulo in resultadosSinFiltro)
                {
                    var card = new ArticuloCard(articulo);
                    flowLayoutPanel1.Controls.Add(card);
                }
            }
        }
    }
}
