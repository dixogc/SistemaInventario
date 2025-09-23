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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Articulo art = new Articulo
            {
                Nombre = textBox2.Text,
                Descripcion = textBox3.Text,
                StockActual = int.Parse(textBox4.Text),
                Categoria = textBox5.Text,
                Ubicacion = textBox6.Text

            };

            ArticuloService service = new ArticuloService();
            service.RegistrarArticuloService(art);

            MessageBox.Show("Articulo guardado.");
        }
    }
}
