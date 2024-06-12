using ProyectoColegio.capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoColegio.capaPresentacion
{
    public partial class inscripAlumnosForm : Form
    {
        GestionInscripcion gestionInscripcion = new GestionInscripcion();

        public inscripAlumnosForm()
        {
            InitializeComponent();
            CargarEstudiantes();
            CargarCursos();
            ActualizarDgvCursosInscritos();
            ActualizarDgvPagos();


        }
        private void CargarEstudiantes()
        {
            //método en la capa de datos que devuelve una lista de estudiantes
            cmbEstudiantes.DataSource = new BaseDeDatos().ObtenerEstudiantes();
            cmbEstudiantes.DisplayMember = "NombreCompleto"; // Asegúrate que el objeto Estudiante tenga esta propiedad
            cmbEstudiantes.ValueMember = "IdEstudiante";
        }

        private void CargarCursos()
        {
            //método en la capa de datos que devuelve una lista de Cursos

            cmbCursos.DataSource = new BaseDeDatos().ObtenerCursos();
            cmbCursos.DisplayMember = "Nombre"; // Asegúrate que el objeto Curso tenga esta propiedad
            cmbCursos.ValueMember = "IdCurso";
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            int idEstudiante = Convert.ToInt32(cmbEstudiantes.SelectedValue);
            int idCurso = Convert.ToInt32(cmbCursos.SelectedValue);

            gestionInscripcion.InscribirEstudiante(idEstudiante, idCurso);
            MessageBox.Show("Estudiante inscrito correctamente en el curso.");
            ActualizarDgvCursosInscritos();
        }
        private void ActualizarDgvCursosInscritos()
        {
            // Este método debe llamar a una función que obtenga los cursos inscritos del estudiante seleccionado y actualizar el DataGridView
            dgvCursosInscritos.DataSource = new BaseDeDatos().ObtenerCursosInscritos(Convert.ToInt32(cmbEstudiantes.SelectedValue));
        }

        private void ActualizarDgvPagos()
        {
            // Este método debe llamar a una función que obtenga los pagos realizados del estudiante seleccionado y actualizar el DataGridView
            dgvPagos.DataSource = new BaseDeDatos().ObtenerPagosEstudiante(Convert.ToInt32(cmbEstudiantes.SelectedValue));
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            int idEstudiante = Convert.ToInt32(cmbEstudiantes.SelectedValue);
            decimal monto = Convert.ToDecimal(txtMonto.Text);
            string observacion = txtObservacionPago.Text;

            gestionInscripcion.ProcesarPago(idEstudiante, monto, observacion);
            MessageBox.Show("Pago registrado correctamente.");
            ActualizarDgvPagos();
        }
    }
}
