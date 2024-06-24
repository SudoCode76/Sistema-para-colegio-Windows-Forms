using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoColegio.capaNegocio
{
    public class gestionCurso
    {
        public int IdCurso { get; set; }
        public string Nombre { get; set; }

        public bool AgregarNuevoCurso(string nombre, string nivel, string estado)
        {
            BaseDeDatos db = new BaseDeDatos();
            return db.AgregarCurso(nombre, nivel, estado);
        }

        public bool EditarCurso(int idCurso, string nombre, string nivel, string estado)
        {
            BaseDeDatos db = new BaseDeDatos();
            return db.ActualizarCurso(idCurso, nombre, nivel, estado);
        }

        public bool EliminarCurso(int idCurso)
        {
            BaseDeDatos db = new BaseDeDatos();
            return db.EliminarCurso(idCurso);
        }

        public DataTable ObtenerTodosLosCursos()
        {
            BaseDeDatos db = new BaseDeDatos();
            return db.ObtenerCursos1();
        }

    }

}
