using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoColegio.capaNegocio
{
    public class gestionReportes
    {
        public DataTable ObtenerInscripcionesPorFecha(int mes, int anio)
        {
            BaseDeDatos db = new BaseDeDatos();
            return db.ObtenerInscripcionesPorFecha(mes, anio);
        }

        public DataTable ObtenerPagosPorFecha(int mes, int anio, bool pagado)
        {
            BaseDeDatos db = new BaseDeDatos();
            return db.ObtenerPagosPorFecha(mes, anio, pagado);
        }

        public DataTable ObtenerPagosPorAnio(int anio, bool pagado)
        {
            BaseDeDatos db = new BaseDeDatos();
            return db.ObtenerPagosPorAnio(anio, pagado);
        }

    }
}
