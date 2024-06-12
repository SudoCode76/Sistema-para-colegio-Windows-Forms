using ProyectoColegio.capaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
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
            //pc de mesa
            conexion = new SqlConnection("server=SUDO-DESKTOP\\SQLEXPRESS;database=SistemaColegio; integrated security=true");
            //laptop
            //conexion = new SqlConnection("server=DESKTOP-SO23BMP\\SQLEXPRESS;database=SistemaColegio; integrated security=true");

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

        public void RegistrarEstudiante(Estudiante estudiante)
        {
            string consulta = @"INSERT INTO Estudiantes (CI, nombreCompleto, genero, fechaNacimiento, nacionalidad, direccion, tutor) 
                        VALUES (@CI, @nombreCompleto, @genero, @fechaNacimiento, @nacionalidad, @direccion, @tutor)";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@CI", estudiante.CI);
            comando.Parameters.AddWithValue("@nombreCompleto", estudiante.NombreCompleto);
            comando.Parameters.AddWithValue("@genero", estudiante.Genero);
            comando.Parameters.AddWithValue("@fechaNacimiento", estudiante.FechaNacimiento);
            comando.Parameters.AddWithValue("@nacionalidad", estudiante.Nacionalidad);
            comando.Parameters.AddWithValue("@direccion", estudiante.Direccion);
            comando.Parameters.AddWithValue("@tutor", estudiante.Tutor);

            AbrirConexion();
            comando.ExecuteNonQuery();
            CerrarConexion();
        }

        public List<Estudiante> ObtenerEstudiantes()
        {
            List<Estudiante> listaEstudiantes = new List<Estudiante>();
            string consulta = "SELECT * FROM Estudiantes";
            SqlCommand comando = new SqlCommand(consulta, conexion);

            AbrirConexion();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                listaEstudiantes.Add(new Estudiante()
                {
                    IdEstudiante = Convert.ToInt32(lector["idEstudiante"]),
                    CI = lector["CI"].ToString(),
                    NombreCompleto = lector["nombreCompleto"].ToString(),
                    Genero = lector["genero"].ToString(),
                    FechaNacimiento = Convert.ToDateTime(lector["fechaNacimiento"]),
                    Nacionalidad = lector["nacionalidad"].ToString(),
                    Direccion = lector["direccion"].ToString(),
                    Tutor = lector["tutor"].ToString()
                });
            }
            lector.Close();
            CerrarConexion();

            return listaEstudiantes;
        }
        public List<Curso> ObtenerCursos()
        {
            List<Curso> cursos = new List<Curso>();
            string consulta = "SELECT IdCurso, Nombre FROM Cursos";
            SqlCommand comando = new SqlCommand(consulta, conexion);

            AbrirConexion();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                cursos.Add(new Curso()
                {
                    IdCurso = lector.GetInt32(0),
                    Nombre = lector.GetString(1)
                });
            }
            lector.Close();
            CerrarConexion();

            return cursos;
        }
        public List<Materia> ObtenerMateria()
        {
            List<Materia> materias = new List<Materia>();
            string consulta = "SELECT IdMateria, nombreMateria FROM Materia";
            SqlCommand comando = new SqlCommand(consulta, conexion);

            AbrirConexion();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                materias.Add(new Materia()
                {
                    IdMateria = lector.GetInt32(0),
                    Nombre = lector.GetString(1)
                });
            }
            lector.Close();
            CerrarConexion();

            return materias;
        }



        public void InscribirEstudianteACurso(int idEstudiante, int idCurso)
        {
            string consulta = "INSERT INTO Inscripcion (idEstudiante, idCurso, fechaInscripcion) VALUES (@idEstudiante, @idCurso, GETDATE())";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@idEstudiante", idEstudiante);
            comando.Parameters.AddWithValue("@idCurso", idCurso);

            AbrirConexion();
            comando.ExecuteNonQuery();
            CerrarConexion();
        }

        public void RegistrarPago(int idEstudiante, decimal monto, string observacion)
        {
            string consulta = "INSERT INTO Mensualidades (idEstudiante, monto, observacion, fechaPago, estado) VALUES (@idEstudiante, @monto, @observacion, GETDATE(), 'Pagado')";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@idEstudiante", idEstudiante);
            comando.Parameters.AddWithValue("@monto", monto);
            comando.Parameters.AddWithValue("@observacion", observacion);

            AbrirConexion();
            comando.ExecuteNonQuery();
            CerrarConexion();
        }

        public bool InsertarCalificacion(int idEstudiante, int idMateria, decimal primerTrimestre, decimal segundoTrimestre, decimal tercerTrimestre)
        {
            string consulta = @"INSERT INTO Notas (idEstudiante, idMateria, primerTrimestre, segundoTrimestre, tercerTrimestre)VALUES (@IdEstudiante, @IdMateria, @PrimerTrimestre, @SegundoTrimestre, @TercerTrimestre)";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@IdEstudiante", idEstudiante);
            comando.Parameters.AddWithValue("@IdMateria", idMateria);
            comando.Parameters.AddWithValue("@PrimerTrimestre", primerTrimestre);
            comando.Parameters.AddWithValue("@SegundoTrimestre", segundoTrimestre);
            comando.Parameters.AddWithValue("@TercerTrimestre", tercerTrimestre);

            AbrirConexion();
            int filasAfectadas = comando.ExecuteNonQuery();
            CerrarConexion();

            return filasAfectadas > 0;
        }

        public DataTable ObtenerCalificaciones(int idEstudiante)
        {
            string consulta = @"
        SELECT M.nombreMateria, N.primerTrimestre, N.segundoTrimestre, N.tercerTrimestre
        FROM Notas N
        INNER JOIN Materia M ON N.idMateria = M.idMateria
        WHERE N.idEstudiante = @idEstudiante";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@idEstudiante", idEstudiante);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable resultado = new DataTable();
            AbrirConexion();
            adaptador.Fill(resultado);
            CerrarConexion();

            return resultado;
        }




        public List<CursoInscrito> ObtenerCursosInscritos(int idEstudiante)
        {
            List<CursoInscrito> cursosInscritos = new List<CursoInscrito>();
            string consulta = "SELECT c.IdCurso, c.Nombre, i.fechaInscripcion FROM Inscripcion i INNER JOIN Cursos c ON i.idCurso = c.IdCurso WHERE i.idEstudiante = @idEstudiante";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@idEstudiante", idEstudiante);

            AbrirConexion();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                cursosInscritos.Add(new CursoInscrito()
                {
                    IdCurso = lector.GetInt32(0),
                    Nombre = lector.GetString(1),
                    FechaInscripcion = lector.GetDateTime(2)
                });
            }
            lector.Close();
            CerrarConexion();

            return cursosInscritos;
        }

        public List<PagoEstudiante> ObtenerPagosEstudiante(int idEstudiante)
        {
            List<PagoEstudiante> pagosEstudiante = new List<PagoEstudiante>();
            string consulta = "SELECT monto, fechaPago, observacion FROM Mensualidades WHERE idEstudiante = @idEstudiante";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@idEstudiante", idEstudiante);

            AbrirConexion();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                pagosEstudiante.Add(new PagoEstudiante()
                {
                    Monto = lector.GetDecimal(0),
                    FechaPago = lector.GetDateTime(1),
                    Observacion = lector.GetString(2)
                });
            }
            lector.Close();
            CerrarConexion();

            return pagosEstudiante;
        }






    }
}
