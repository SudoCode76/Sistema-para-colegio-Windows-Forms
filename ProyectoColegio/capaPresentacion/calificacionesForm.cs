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
    public partial class calificacionesForm : Form
    {
        GestionCalificaciones gestionCalificaciones = new GestionCalificaciones();

        public calificacionesForm()
        {
            InitializeComponent();
            CargarEstudiantes();
            CargarMaterias();

        }

        private void CargarEstudiantes()
        {
            //método en la capa de datos que devuelve una lista de estudiantes
            cmbEstudiantes.DataSource = new BaseDeDatos().ObtenerEstudiantes();
            cmbEstudiantes.DisplayMember = "NombreCompleto"; // Asegúrate que el objeto Estudiante tenga esta propiedad
            cmbEstudiantes.ValueMember = "IdEstudiante";
        }

        private void CargarMaterias()
        {
            //método en la capa de datos que devuelve una lista de Cursos

            cmbMateria.DataSource = new BaseDeDatos().ObtenerMateria();
            cmbMateria.DisplayMember = "Nombre"; 
            cmbMateria.ValueMember = "IdMateria";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int idEstudiante = Convert.ToInt32(cmbEstudiantes.SelectedValue);
            dataGridViewCalificaciones.DataSource = gestionCalificaciones.ConsultarCalificaciones(idEstudiante);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int idEstudiante = Convert.ToInt32(cmbEstudiantes.SelectedValue);
            int idMateria = Convert.ToInt32(cmbMateria.SelectedValue);
            decimal primerTrimestre = decimal.Parse(txtPrimerTrimestre.Text);
            decimal segundoTrimestre = decimal.Parse(txtSegundoTrimestre.Text);
            decimal tercerTrimestre = decimal.Parse(txtTercerTrimestre.Text);
            if (gestionCalificaciones.AgregarCalificacion(idEstudiante, idMateria, primerTrimestre, segundoTrimestre, tercerTrimestre))
            {
                MessageBox.Show("Calificación agregada correctamente");
            }
            else
            {
                MessageBox.Show("Error al agregar calificación");
            }
        }
    }
}
