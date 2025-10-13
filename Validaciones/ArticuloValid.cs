using SistemaInventario.AccesoDatos;
using SistemaInventario.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SistemaInventario.AccesoDatos.ArticuloDA;

namespace SistemaInventario.LogicaNegocio
{
    internal class ArticuloValid
    {
        public bool RegistrarArticuloService(Articulo articulo, TipoCoincidencia coincidencia)
        {
            if (string.IsNullOrWhiteSpace(articulo.Nombre))
            {
                MessageBox.Show("El nombre es obligatorio");
                return false;
            }
            if (articulo.Stock <= 0)
            {
                MessageBox.Show("La cantidad no debe ser negativa o cero");
                return false;
            }

            if (articulo.Subcategoria == 0)
            {
                MessageBox.Show("Debe seleccionar una categoría");
                return false;
            }

            if (articulo.Ubicacion == 0)
            {
                MessageBox.Show("Debe seleccionar una ubicación");
                return false;
            }

            if (coincidencia == TipoCoincidencia.Exacta)
            {
                MessageBox.Show("Ya existe un artículo con este nombre y características.");
                return false;
            }

            if (coincidencia == TipoCoincidencia.Atributos)
            {
                DialogResult result = MessageBox.Show(
                    "Ya existe un artículo con estas características pero con otro nombre. ¿Deseas continuar?",
                    "Advertencia de duplicado parcial",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                    return false;
            }

            ArticuloDA.InsertarArticulo(articulo);
            return true;
        }

        public bool EditarArticuloService(Articulo articulo, TipoCoincidencia coincidencia)
        {
            if (string.IsNullOrWhiteSpace(articulo.Nombre))
            {
                MessageBox.Show("El nombre es obligatorio");
                return false;
            }

            if (articulo.Subcategoria == 0)
            {
                MessageBox.Show("Debe seleccionar una categoría");
                return false;
            }

            if (articulo.Ubicacion == 0)
            {
                MessageBox.Show("Debe seleccionar una ubicación");
                return false;
            }

            if (coincidencia == TipoCoincidencia.Exacta)
            {
                MessageBox.Show("Ya existe un artículo con este nombre y características.");
                return false;
            }

            if (coincidencia == TipoCoincidencia.Atributos)
            {
                DialogResult result = MessageBox.Show(
                    "Ya existe un artículo con estas características pero con otro nombre. ¿Deseas continuar?",
                    "Advertencia de duplicado parcial",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                    return false;
            }

            ArticuloDA.ActualizarArticulo(articulo);
            return true;
        }
    }
}
