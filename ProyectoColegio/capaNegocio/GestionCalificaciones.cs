using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoColegio.capaNegocio
{

    public class GestionCalificaciones
    {
        private BaseDeDatos db = new BaseDeDatos();

        public DataTable ConsultarCalificaciones(int idEstudiante)
        {
            return db.ObtenerCalificaciones(idEstudiante);
        }

        public bool AgregarCalificacion(int idEstudiante, int idMateria, decimal primerTrimestre, decimal segundoTrimestre, decimal tercerTrimestre)
        {
            return db.InsertarCalificacion(idEstudiante, idMateria, primerTrimestre, segundoTrimestre, tercerTrimestre);
        }
    }
}
