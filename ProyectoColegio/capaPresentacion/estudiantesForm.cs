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

namespace ProyectoColegio
{
    public partial class estudiantesForm : Form
    {
        public estudiantesForm()
        {
            InitializeComponent();
            ActualizarDataGrid();

        }
        private void FormRegistrarEstudiante_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Estudiante nuevoEstudiante = new Estudiante()
            {
                CI = txtCI.Text,
                NombreCompleto = txtNombreCompleto.Text,
                Genero = cmbGenero.SelectedItem.ToString(),
                FechaNacimiento = dtpFechaNacimiento.Value,
                Nacionalidad = txtNacionalidad.Text,
                Direccion = txtDireccion.Text,
                Tutor = txtTutor.Text
            };

            BaseDeDatos db = new BaseDeDatos();
            db.RegistrarEstudiante(nuevoEstudiante);
            MessageBox.Show("Estudiante registrado con éxito.");
            ActualizarDataGrid();
        }
        private void ActualizarDataGrid()
        {
            BaseDeDatos db = new BaseDeDatos();
            dgvEstudiantes.DataSource = db.ObtenerEstudiantes();
        }
    }
}
