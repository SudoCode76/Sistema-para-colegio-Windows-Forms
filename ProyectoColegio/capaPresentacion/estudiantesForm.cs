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
            txtNombreCompleto.KeyPress += new KeyPressEventHandler(SoloLetras_KeyPress);
            txtTutor.KeyPress += new KeyPressEventHandler(SoloLetras_KeyPress);
            txtNacionalidad.KeyPress += new KeyPressEventHandler(SoloLetras_KeyPress);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
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
                LimpiarCampos();
            }
        }

        private bool ValidarCampos()
        {
            if (txtNombreCompleto.Text.Any(char.IsDigit))
            {
                MessageBox.Show("El campo 'Nombre Completo' solo debe contener letras.");
                return false;
            }

            if (txtTutor.Text.Any(char.IsDigit))
            {
                MessageBox.Show("El campo 'Tutor' solo debe contener letras.");
                return false;
            }

            if (txtNacionalidad.Text.Any(char.IsDigit))
            {
                MessageBox.Show("El campo 'Nacionalidad' solo debe contener letras.");
                return false;
            }

            return true;
        }


        private void ActualizarDataGrid()
        {
            BaseDeDatos db = new BaseDeDatos();
            dgvEstudiantes.DataSource = db.ObtenerEstudiantes();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (dgvEstudiantes.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvEstudiantes.SelectedRows[0];
                txtCI.Text = filaSeleccionada.Cells["CI"].Value.ToString();
                txtNombreCompleto.Text = filaSeleccionada.Cells["nombreCompleto"].Value.ToString();
                cmbGenero.SelectedItem = filaSeleccionada.Cells["genero"].Value.ToString();
                dtpFechaNacimiento.Value = Convert.ToDateTime(filaSeleccionada.Cells["fechaNacimiento"].Value);
                txtNacionalidad.Text = filaSeleccionada.Cells["nacionalidad"].Value.ToString();
                txtDireccion.Text = filaSeleccionada.Cells["direccion"].Value.ToString();
                txtTutor.Text = filaSeleccionada.Cells["tutor"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un estudiante para editar.");
            }
        }


        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (dgvEstudiantes.SelectedRows.Count > 0 && ValidateChildren() && ValidarCampos())
            {
                DataGridViewRow filaSeleccionada = dgvEstudiantes.SelectedRows[0];
                int idEstudiante = Convert.ToInt32(filaSeleccionada.Cells["idEstudiante"].Value);

                Estudiante estudianteActualizado = new Estudiante()
                {
                    IdEstudiante = idEstudiante,
                    CI = txtCI.Text,
                    NombreCompleto = txtNombreCompleto.Text,
                    Genero = cmbGenero.SelectedItem.ToString(),
                    FechaNacimiento = dtpFechaNacimiento.Value,
                    Nacionalidad = txtNacionalidad.Text,
                    Direccion = txtDireccion.Text,
                    Tutor = txtTutor.Text
                };

                BaseDeDatos db = new BaseDeDatos();
                if (db.ActualizarEstudiante(estudianteActualizado))
                {
                    MessageBox.Show("Estudiante actualizado con éxito.");
                    ActualizarDataGrid();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el estudiante.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un estudiante para actualizar.");
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (dgvEstudiantes.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvEstudiantes.SelectedRows[0];
                int idEstudiante = Convert.ToInt32(filaSeleccionada.Cells["idEstudiante"].Value);

                BaseDeDatos db = new BaseDeDatos();
                if (db.EliminarEstudiante(idEstudiante))
                {
                    MessageBox.Show("Estudiante eliminado con éxito.");
                    ActualizarDataGrid();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el estudiante.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un estudiante para eliminar.");
            }
        }
        private void LimpiarCampos()
        {
            txtCI.Clear();
            txtNombreCompleto.Clear();
            cmbGenero.SelectedIndex = -1;
            dtpFechaNacimiento.Value = DateTime.Now;
            txtNacionalidad.Clear();
            txtDireccion.Clear();
            txtTutor.Clear();
        }

        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras en este campo.");
            }
        }
    }
}
