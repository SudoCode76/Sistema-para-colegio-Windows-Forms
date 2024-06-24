using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoColegio.capaNegocio
{
    public class gestionProfesores
    {
        public bool AgregarNuevoProfesor(string nombre, string apellido, string direccion, string telefono, string email, string estado)
        {
            BaseDeDatos db = new BaseDeDatos();
            return db.AgregarProfesor(nombre, apellido, direccion, telefono, email, estado);
        }

        public DataTable ObtenerProfesoresSinMateria()
        {
            BaseDeDatos db = new BaseDeDatos();
            return db.ObtenerProfesoresSinMateria();
        }

        public bool AsignarMateriaAProfesor(int idProfesor, int idMateria)
        {
            BaseDeDatos db = new BaseDeDatos();
            return db.AsignarMateriaAProfesor(idProfesor, idMateria);
        }

        public DataTable ObtenerTodosLosProfesores()
        {
            BaseDeDatos db = new BaseDeDatos();
            return db.ObtenerTodosLosProfesores();
        }
        public DataTable ObtenerMateria()
        {
            BaseDeDatos db = new BaseDeDatos();
            return db.ObtenerMateriasProfesores();
        }

        public bool EliminarProfesor(int idProfesor)
        {
            BaseDeDatos db = new BaseDeDatos();
            return db.EliminarProfesor(idProfesor);
        }

        public bool ActualizarProfesor(int idProfesor, string nombre, string apellido, string direccion, string telefono, string email, string estado)
        {
            BaseDeDatos db = new BaseDeDatos();
            return db.ActualizarProfesor(idProfesor, nombre, apellido, direccion, telefono, email, estado);
        }

    }
}
