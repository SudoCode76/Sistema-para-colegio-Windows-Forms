using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoColegio.capaNegocio
{
    public class UsuarioNegocio
    {
        private BaseDeDatos baseDeDatos;

        public UsuarioNegocio()
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
    }
}
