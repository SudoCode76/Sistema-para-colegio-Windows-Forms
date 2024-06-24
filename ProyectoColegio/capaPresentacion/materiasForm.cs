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
    public partial class materiasForm : Form
    {
        gestionMaterias gestionMaterias = new gestionMaterias();
        public materiasForm()
        {
            InitializeComponent();
            CargarMaterias();
        }
        private int idMateriaSeleccionada = -1;
        private void CargarMaterias()
        {
            try
            {
                materiasDataGridView.DataSource = gestionMaterias.ObtenerTodasLasMaterias();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }
        private void agregarMateriaButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()) // Esto llama al evento Validating de los controles del formulario
            {
                string nombreMateria = nombreMateriaTextBox.Text;
                string gestion = gestionTextBox.Text;

                if (gestionMaterias.AgregarNuevaMateria(nombreMateria, gestion))
                {
                    MessageBox.Show("Materia agregada con éxito.");
                    CargarMaterias();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("La materia ya existe. No se pueden agregar materias duplicadas.");
                }
            }

        }

        private void editarMateriaButton_Click(object sender, EventArgs e)
        {
            if (materiasDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = materiasDataGridView.SelectedRows[0];
                idMateriaSeleccionada = Convert.ToInt32(filaSeleccionada.Cells["idMateria"].Value);
                nombreMateriaTextBox.Text = filaSeleccionada.Cells["nombreMateria"].Value.ToString();
                gestionTextBox.Text = filaSeleccionada.Cells["gestion"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una materia para editar.");
            }
        }

        private void guardarCambiosMateriaButton_Click(object sender, EventArgs e)
        {
            if (idMateriaSeleccionada > -1 && ValidateChildren())
            {
                string nombreMateria = nombreMateriaTextBox.Text;
                string gestion = gestionTextBox.Text;

                if (gestionMaterias.EditarMateria(idMateriaSeleccionada, nombreMateria, gestion))
                {
                    MessageBox.Show("Materia actualizada con éxito.");
                    CargarMaterias(); // Actualiza el DataGridView
                    LimpiarCampos(); // Limpia los campos después de actualizar
                }
                else
                {
                    MessageBox.Show("Error al actualizar la materia.");
                }
            }
            else if (idMateriaSeleccionada == -1)
            {
                MessageBox.Show("No se ha seleccionado ninguna materia para editar.");
            }
        }

        private void eliminarMateriaButton_Click(object sender, EventArgs e)
        {
            if (materiasDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = materiasDataGridView.SelectedRows[0];
                int idMateria = Convert.ToInt32(filaSeleccionada.Cells["idMateria"].Value);

                if (gestionMaterias.EliminarMateria(idMateria))
                {
                    MessageBox.Show("Materia eliminada con éxito.");
                    CargarMaterias();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la materia.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una materia para eliminar.");
            }
        }







        private void LimpiarCampos()
        {
            nombreMateriaTextBox.Clear();
            gestionTextBox.Clear();
            idMateriaSeleccionada = -1; // Resetea el id seleccionado
        }

        private void gestionTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(gestionTextBox.Text, out int gestion) || gestion < 1900 || gestion > DateTime.Now.Year)
            {
                e.Cancel = true;
                MessageBox.Show("Por favor, ingrese un año válido entre 1900 y el año actual.");
                gestionTextBox.SelectAll();
            }
        }
    }
}
