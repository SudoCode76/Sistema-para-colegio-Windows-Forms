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
    public partial class cursosForms : Form
    {
        gestionCurso gestionCurso = new gestionCurso();
        public cursosForms()
        {
            InitializeComponent();
        }
        private int idCursoSeleccionado = -1;
        private void cursosForms_Load(object sender, EventArgs e)
        {
            nivelComboBox.Items.Add("Primaria");
            nivelComboBox.Items.Add("Secundaria");

            estadoComboBox.Items.Add("Activo");
            estadoComboBox.Items.Add("Inactivo");

            CargarCursos();

        }
        private void CargarCursos()
        {
            cursosDataGridView.DataSource = gestionCurso.ObtenerTodosLosCursos();
        }
        

        private void agregarCursoButton_Click(object sender, EventArgs e)
        {
            string nombre = nombreCursoTextBox.Text;
            string nivel = nivelComboBox.SelectedItem.ToString();
            string estado = estadoComboBox.SelectedItem.ToString();

            if (gestionCurso.AgregarNuevoCurso(nombre, nivel, estado))
            {
                MessageBox.Show("Curso agregado con éxito.");
                CargarCursos();
                LimpiarCamposCurso();
            }
            else
            {
                MessageBox.Show("Error al agregar el curso.");
            }

        }

        private void LimpiarCamposCurso()
        {
            nombreCursoTextBox.Clear();
            nivelComboBox.SelectedIndex = -1;
            estadoComboBox.SelectedIndex = -1;
            idCursoSeleccionado = -1;
        }

        private void editarCursoButton_Click(object sender, EventArgs e)
        {
            if (cursosDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = cursosDataGridView.SelectedRows[0];
                idCursoSeleccionado = Convert.ToInt32(filaSeleccionada.Cells["idCurso"].Value);
                nombreCursoTextBox.Text = filaSeleccionada.Cells["nombre"].Value.ToString();
                nivelComboBox.SelectedItem = filaSeleccionada.Cells["nivel"].Value.ToString();
                estadoComboBox.SelectedItem = filaSeleccionada.Cells["estado"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un curso para editar.");
            }
        }

        private void actualizarCursoButton_Click(object sender, EventArgs e)
        {
            if (idCursoSeleccionado > -1)
            {
                string nombre = nombreCursoTextBox.Text;
                string nivel = nivelComboBox.SelectedItem.ToString();
                string estado = estadoComboBox.SelectedItem.ToString();

                if (gestionCurso.EditarCurso(idCursoSeleccionado, nombre, nivel, estado))
                {
                    MessageBox.Show("Curso actualizado con éxito.");
                    CargarCursos(); 
                    LimpiarCamposCurso();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el curso.");
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún curso para editar.");
            }
        }

        private void eliminarCursoButton_Click(object sender, EventArgs e)
        {
            if (cursosDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = cursosDataGridView.SelectedRows[0];
                int idCurso = Convert.ToInt32(filaSeleccionada.Cells["idCurso"].Value);

                if (gestionCurso.EliminarCurso(idCurso))
                {
                    MessageBox.Show("Curso eliminado con éxito.");
                    CargarCursos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el curso.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un curso para eliminar.");
            }
        }
    }
}
