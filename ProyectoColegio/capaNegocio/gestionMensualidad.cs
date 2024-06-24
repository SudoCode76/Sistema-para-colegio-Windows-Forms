using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoColegio.capaNegocio
{
    public class gestionMensualidad
    {
        public DataTable ObtenerEstudiantesPorEstadoYFecha(bool pagado, int mes, int anio)
        {
            BaseDeDatos db = new BaseDeDatos();
            return db.ObtenerEstudiantesPorEstadoYFecha(pagado, mes, anio);
        }
        public void RegistrarPagoEstudiante(int idEstudiante, decimal monto, string observacion)
        {
            BaseDeDatos db = new BaseDeDatos();
            db.RegistrarPago(idEstudiante, monto, observacion);
        }


    }
}
