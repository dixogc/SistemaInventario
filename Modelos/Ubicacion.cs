using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    internal class Ubicacion
    {
        public int Id {  get; set; }
        public int Seccion { get; set; }
        public int Estante { get; set; }
        public string Descripcion { get; set; }

    }
}
