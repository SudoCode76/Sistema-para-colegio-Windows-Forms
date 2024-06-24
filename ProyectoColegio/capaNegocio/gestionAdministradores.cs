using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoColegio.capaNegocio
{
    public class gestionAdministradores
    {
        public void AgregarAdministrador(string nombre, string apellido, string cargo)
        {
            BaseDeDatos db = new BaseDeDatos();
            db.RegistrarAdministrador(nombre, apellido, cargo);
        }

        public DataTable ListarAdministradores()
        {
            BaseDeDatos db = new BaseDeDatos();
            return db.ObtenerAdministradores();
        }
        public bool EditarAdministrador(int idAdministrador, string nombre, string apellido, string cargo)
        {
            BaseDeDatos db = new BaseDeDatos();
            return db.ActualizarAdministrador(idAdministrador, nombre, apellido, cargo);
        }

        public DataTable CargarCargos()
        {
            BaseDeDatos db = new BaseDeDatos();
            return db.ObtenerCargos();
        }



    }
}
