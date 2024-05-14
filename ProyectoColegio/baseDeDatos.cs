using System;
using System.Data.SqlClient;


namespace ProyectoColegio
{
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string TipoUsuario { get; set; }
    }

    public class BaseDeDatos
    {
        private SqlConnection conexion;

        public BaseDeDatos()
        {
            conexion = new SqlConnection("server=SUDO-DESKTOP\\SQLEXPRESS;database=SistemaColegio; integrated security=true");
        }

        public void AbrirConexion()
        {
            conexion.Open();
        }

        public void CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        public Usuario ValidarUsuario(string usuario, string contrasena)
        {
            string consulta = "SELECT nombreUsuario, nombre, apellidoPaterno, tipoUsuario FROM Usuarios WHERE nombreUsuario=@usuario AND contrasena=@contrasena";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@contrasena", contrasena);

            SqlDataReader lector = comando.ExecuteReader();
            if (lector.Read())
            {
                Usuario usuarioEncontrado = new Usuario()
                {
                    NombreUsuario = lector["nombreUsuario"].ToString(),
                    Nombre = lector["nombre"].ToString(),
                    ApellidoPaterno = lector["apellidoPaterno"].ToString(),
                    TipoUsuario = lector["tipoUsuario"].ToString()
                };
                lector.Close();
                return usuarioEncontrado;
            }
            lector.Close();
            return null;
        }
    }
}
