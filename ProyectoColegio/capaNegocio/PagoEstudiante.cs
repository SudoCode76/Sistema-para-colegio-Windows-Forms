using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoColegio.capaNegocio
{
    public class PagoEstudiante
    {
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public string Observacion { get; set; }
    }
}
