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
        public Articulo Articulo { get; set; }
        private int stockOriginal;
        private int stockActual;
        public ArticuloCard(Articulo articulo)
        {
            InitializeComponent();
            Subcategoria subcategoria = CategoriaDA.ObtenerSubcategoriaPorId(articulo.Subcategoria);
            string descripcionUbicacion = UbicacionDA.ObtenerDescripcionUbicacion(articulo.Ubicacion);
            Articulo = articulo;
            lblNombre.Text = articulo.Nombre;
            lblDescripcion.Text = articulo.Descripcion;
            stockOriginal = articulo.Stock;
            stockActual = stockOriginal;
            lblStock.Text = stockActual.ToString();
            lblConteo.Text = ""; 
            lblCategoria.Text = subcategoria.Nombre;
            lblUbicacion.Text = descripcionUbicacion;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            btnActualizarStock.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnEditarArticulo_Click(object sender, EventArgs e)
        {
            FrmEditarArticulo(Articulo);
        }

        private void FrmEditarArticulo(Articulo articulo)
        {
            FrmEditarArticulo frmEditarArticulo = new FrmEditarArticulo(articulo);
            frmEditarArticulo.Show();
        }

        private void btnAñadirStock_Click(object sender, EventArgs e)
        {
            int diferencia = stockActual - stockOriginal;
            ArticuloDA.ActualizarStock(Articulo.Id, diferencia);
            lblConteo.Text = "Stock actualizado";
            lblConteo.ForeColor = Color.Blue;

        }

        private void MostrarCambioVisual()
        {
            int diferencia = stockActual - stockOriginal;

            if (diferencia > 0)
            {
                lblConteo.Text = $"+{diferencia} unidades añadidas";
                lblConteo.ForeColor = Color.Green;
                btnActualizarStock.Enabled = true;
                btnCancelar.Enabled = true;
            }
            else if (diferencia < 0)
            {
                lblConteo.Text = $"{Math.Abs(diferencia)} unidades retiradas";
                lblConteo.ForeColor = Color.Red;
                btnActualizarStock.Enabled = true;
                btnCancelar.Enabled = true;
            }
            else
            {
                lblConteo.Text = "Sin cambios en el stock";
                lblConteo.ForeColor = Color.Gray;
                btnActualizarStock.Enabled = false;
                btnCancelar.Enabled = false;
            }
        }
        private void btnAñadirArticulo_Click(object sender, EventArgs e)
        {
            stockActual++;
            lblStock.Text = stockActual.ToString();
            MostrarCambioVisual();
            
        }

        private void lblStock_Click(object sender, EventArgs e)
        {

        }

        private void btnDarDeBajaArticulo_Click(object sender, EventArgs e)
        {
            if (stockActual > 0)
            {
                stockActual--;
                lblStock.Text = stockActual.ToString();
                MostrarCambioVisual();
            }

        }

        private void lblConteo_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblConteo.Text = string.Empty;
            lblStock.Text = stockOriginal.ToString();
        }
    }
}
