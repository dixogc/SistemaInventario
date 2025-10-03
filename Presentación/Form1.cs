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
    public partial class Form1 : Form
    {
        List<string> categoriasSeleccionadas = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnMostrarTodo.Checked = true;
            string articuloBuscado = textBox1.Text;

            List<Articulo> resultados = ArticuloDA.ObtenerArticulos(articuloBuscado);

            flowLayoutPanel1.Controls.Clear();

            foreach (var articulo in resultados)
            {
                var card = new ArticuloCard(articulo);
                flowLayoutPanel1.Controls.Add(card);
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Button btn in flowCategorias.Controls)
            {
                btn.Click += BtnCategoriaToggle_Click;
            }
        }

        private void BtnCategoriaToggle_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            string categoria = btn.Text;

            if (categoriasSeleccionadas.Contains(categoria))
            {
                categoriasSeleccionadas.Remove(categoria);
                btn.BackColor = SystemColors.Control;
            }
            else
            {
                categoriasSeleccionadas.Add(categoria);
                btn.BackColor = Color.LightBlue;
            }

            btnMostrarTodo.Checked = false;

            if (categoriasSeleccionadas.Count == 1)
            {
                panelSubcategorias.Visible = true;
                var subcategorias = CategoriaDA.ObtenerTodasLasSubCategorias(categoriasSeleccionadas);
                clbSubcategorias.Items.Clear();
                clbSubcategorias.Items.AddRange(subcategorias.ToArray);
                panelSubcategorias.Visible = true;
            }
            else
            {
                panelSubcategorias.Visible = false;
                clbSubcategorias.Items.Clear();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmAltaArticulo frmAltaArticulo = new FrmAltaArticulo();
            frmAltaArticulo.MdiParent = this;
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

        private void btnMostrarTodo_CheckedChanged(object sender, EventArgs e)
        {
            if(btnMostrarTodo.Checked)
            {
                categoriasSeleccionadas.Clear();
                foreach (Button btn in flowCategorias.Controls)
                    btn.BackColor = SystemColors.Window;
                panelSubcategorias.Visible=false;
                clbSubcategorias.Items.Clear();
            }
        }
    }
}
