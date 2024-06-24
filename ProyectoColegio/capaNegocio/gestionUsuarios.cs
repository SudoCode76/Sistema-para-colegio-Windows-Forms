using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoColegio.capaNegocio
{
    public class gestionUsuarios
    {
        private BaseDeDatos baseDeDatos;

        public gestionUsuarios()
        {
            baseDeDatos = new BaseDeDatos();
        }

        public Usuario ValidarUsuario(string nombreUsuario, string contraseña)
        {
            baseDeDatos.AbrirConexion();
            Usuario usuario = baseDeDatos.ValidarUsuario(nombreUsuario, contraseña);
            baseDeDatos.CerrarConexion();
            return usuario;
        }

        public bool AgregarUsuario(string nombreUsuario, string contrasena, string nombre, string apellidoPaterno, string apellidoMaterno, string tipoUsuario)
        {
            BaseDeDatos db = new BaseDeDatos();
            return db.AgregarUsuario(nombreUsuario, contrasena, nombre, apellidoPaterno, apellidoMaterno, tipoUsuario);
        }

        public DataTable ObtenerUsuarios()
        {
            BaseDeDatos db = new BaseDeDatos();
            return db.ObtenerUsuarios();
        }

        public bool ActualizarUsuario(string nombreUsuario, string contrasena, string nombre, string apellidoPaterno, string apellidoMaterno, string tipoUsuario)
        {
            BaseDeDatos db = new BaseDeDatos();
            return db.ActualizarUsuario(nombreUsuario, contrasena, nombre, apellidoPaterno, apellidoMaterno, tipoUsuario);
        }

        public bool EliminarUsuario(string nombreUsuario)
        {
            BaseDeDatos db = new BaseDeDatos();
            return db.EliminarUsuario(nombreUsuario);
        }

    }
}
