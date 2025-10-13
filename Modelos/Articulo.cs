using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable enable

namespace SistemaInventario.Modelos
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string? Medidas { get; set; }
        public string? Capacidad { get; set; }
        public string? CaracteristicaExtra { get; set; }
        public int Subcategoria { get; set; }
        public int Ubicacion {  get; set; }

        public string DescripcionCompleta =>
    string.Join(" ", new[] { Nombre, Marca, Modelo, Medidas, Capacidad, CaracteristicaExtra }
        .Where(s => !string.IsNullOrWhiteSpace(s))).ToUpperInvariant();
    }

}

    

