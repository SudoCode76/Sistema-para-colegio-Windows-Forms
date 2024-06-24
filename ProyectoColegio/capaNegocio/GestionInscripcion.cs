using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoColegio.capaNegocio
{
    public class GestionInscripcion
    {
        BaseDeDatos db = new BaseDeDatos();

        public void InscribirEstudiante(int idEstudiante, int idCurso)
        {
            db.InscribirEstudianteACurso(idEstudiante, idCurso);
        }


        
    }
}
