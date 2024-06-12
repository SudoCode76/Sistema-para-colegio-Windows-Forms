using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoColegio.capaNegocio
{
    public class Estudiante
    {
        public int IdEstudiante { get; set; }
        public string CI { get; set; }
        public string NombreCompleto { get; set; }
        public string Genero { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string Direccion { get; set; }
        public string Tutor { get; set; }
    }
}
