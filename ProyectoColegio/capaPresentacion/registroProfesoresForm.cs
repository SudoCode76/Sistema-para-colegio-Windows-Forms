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
    public partial class registroProfesoresForm : Form
    {
        gestionProfesores gestionProfesores = new gestionProfesores();
        public registroProfesoresForm()
        {
            InitializeComponent();
        }

        private void registroProfesoresForm_Load(object sender, EventArgs e)
        {
            CargarProfesoresSinMateria();
            CargarMateriasDisponibles();
            CargarTodosLosProfesores();

            telefonoProfesorTextBox.Validating += new System.ComponentModel.CancelEventHandler(telefonoProfesorTextBox_Validating);
            emailProfesorTextBox.Validating += new System.ComponentModel.CancelEventHandler(emailProfesorTextBox_Validating);
        }

        private void CargarProfesoresSinMateria()
        {
            profesoresSinMateriaComboBox.DataSource = gestionProfesores.ObtenerProfesoresSinMateria();
            profesoresSinMateriaComboBox.DisplayMember = "nombreCompleto";
            profesoresSinMateriaComboBox.ValueMember = "idProfesor";
        }

        private void CargarMateriasDisponibles()
        {
            materiasDisponiblesComboBox.DataSource = gestionProfesores.ObtenerMateria();
            materiasDisponiblesComboBox.DisplayMember = "nombreMateria";
            materiasDisponiblesComboBox.ValueMember = "idMateria";
        }

        private void CargarTodosLosProfesores()
        {
            profesoresDataGridView.DataSource = gestionProfesores.ObtenerTodosLosProfesores();
        }

        private void telefonoProfesorTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (telefonoProfesorTextBox.Text.Length != 8 || !telefonoProfesorTextBox.Text.All(char.IsDigit))
            {
                e.Cancel = true;
                MessageBox.Show("El número de teléfono debe tener exactamente 8 dígitos y solo contener números.");
                telefonoProfesorTextBox.SelectAll();
            }
        }

        private void emailProfesorTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!emailProfesorTextBox.Text.Contains("@"))
            {
                e.Cancel = true;
                MessageBox.Show("El correo electrónico debe contener un '@'.");
                emailProfesorTextBox.SelectAll();
            }
        }



        private void agregarProfesorButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()) // Esto llamará a los eventos Validating de los controles
            {
                string nombre = nombreProfesorTextBox.Text;
                string apellido = apellidoProfesorTextBox.Text;
                string direccion = direccionProfesorTextBox.Text;
                string telefono = telefonoProfesorTextBox.Text;
                string email = emailProfesorTextBox.Text;
                string estado = "Sin Asignar";

                if (gestionProfesores.AgregarNuevoProfesor(nombre, apellido, direccion, telefono, email, estado))
                {
                    MessageBox.Show("Profesor agregado con éxito.");
                    CargarProfesoresSinMateria();
                    CargarTodosLosProfesores();
                    LimpiarCamposProfesor();
                }
                else
                {
                    MessageBox.Show("Error al agregar el profesor.");
                }
            }
        }
        private void LimpiarCamposProfesor()
        {
            nombreProfesorTextBox.Clear();
            apellidoProfesorTextBox.Clear();
            direccionProfesorTextBox.Clear();
            telefonoProfesorTextBox.Clear();
            emailProfesorTextBox.Clear();
        }

        private void asignarMateriaButton_Click(object sender, EventArgs e)
        {
            if (profesoresSinMateriaComboBox.SelectedValue != null && materiasDisponiblesComboBox.SelectedValue != null)
            {
                int idProfesor = Convert.ToInt32(profesoresSinMateriaComboBox.SelectedValue);
                int idMateria = Convert.ToInt32(materiasDisponiblesComboBox.SelectedValue);

                if (gestionProfesores.AsignarMateriaAProfesor(idProfesor, idMateria))
                {
                    MessageBox.Show("Materia asignada con éxito.");
                    CargarProfesoresSinMateria();
                    CargarTodosLosProfesores();
                }
                else
                {
                    MessageBox.Show("Error al asignar la materia.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un profesor y una materia.");
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (profesoresDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = profesoresDataGridView.SelectedRows[0];
                int idProfesor = Convert.ToInt32(filaSeleccionada.Cells["idProfesor"].Value);

                if (gestionProfesores.EliminarProfesor(idProfesor))
                {
                    MessageBox.Show("Profesor eliminado con éxito.");
                    CargarProfesoresSinMateria();
                    CargarTodosLosProfesores();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el profesor.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un profesor para eliminar.");
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (profesoresDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = profesoresDataGridView.SelectedRows[0];
                int idProfesor = Convert.ToInt32(filaSeleccionada.Cells["idProfesor"].Value);
                nombreProfesorTextBox.Text = filaSeleccionada.Cells["nombre"].Value.ToString();
                apellidoProfesorTextBox.Text = filaSeleccionada.Cells["apellido"].Value.ToString();
                direccionProfesorTextBox.Text = filaSeleccionada.Cells["direccion"].Value.ToString();
                telefonoProfesorTextBox.Text = filaSeleccionada.Cells["telefono"].Value.ToString();
                emailProfesorTextBox.Text = filaSeleccionada.Cells["email"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un profesor para editar.");
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (profesoresDataGridView.SelectedRows.Count > 0 && ValidateChildren())
            {
                DataGridViewRow filaSeleccionada = profesoresDataGridView.SelectedRows[0];
                int idProfesor = Convert.ToInt32(filaSeleccionada.Cells["idProfesor"].Value);
                string nombre = nombreProfesorTextBox.Text;
                string apellido = apellidoProfesorTextBox.Text;
                string direccion = direccionProfesorTextBox.Text;
                string telefono = telefonoProfesorTextBox.Text;
                string email = emailProfesorTextBox.Text;
                string estado = filaSeleccionada.Cells["estado"].Value.ToString();

                if (gestionProfesores.ActualizarProfesor(idProfesor, nombre, apellido, direccion, telefono, email, estado))
                {
                    MessageBox.Show("Profesor actualizado con éxito.");
                    CargarProfesoresSinMateria();
                    CargarTodosLosProfesores();
                    LimpiarCamposProfesor();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el profesor.");
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún profesor para editar.");
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (profesoresDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = profesoresDataGridView.SelectedRows[0];
                int idProfesor = Convert.ToInt32(filaSeleccionada.Cells["idProfesor"].Value);

                profesoresSinMateriaComboBox.DataSource = null;
                profesoresSinMateriaComboBox.Items.Clear();
                profesoresSinMateriaComboBox.Items.Add(new { nombreCompleto = filaSeleccionada.Cells["nombre"].Value.ToString() + " " + filaSeleccionada.Cells["apellido"].Value.ToString(), idProfesor = idProfesor });
                profesoresSinMateriaComboBox.DisplayMember = "nombreCompleto";
                profesoresSinMateriaComboBox.ValueMember = "idProfesor";
                profesoresSinMateriaComboBox.SelectedIndex = 0;
                profesoresSinMateriaComboBox.Enabled = false;

                // Manejar el caso donde idMateria podría ser nulo
                if (filaSeleccionada.Cells["idMateria"].Value != DBNull.Value)
                {
                    materiasDisponiblesComboBox.SelectedValue = Convert.ToInt32(filaSeleccionada.Cells["idMateria"].Value);
                }
                else
                {
                    materiasDisponiblesComboBox.SelectedIndex = -1; // Sin selección si no hay materia asignada
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un profesor para editar su asignación.");
            }
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            int idProfesor = -1;
            if (!profesoresSinMateriaComboBox.Enabled && profesoresSinMateriaComboBox.Items.Count > 0)
            {
                var itemSeleccionado = profesoresSinMateriaComboBox.Items[0];
                idProfesor = (int)itemSeleccionado.GetType().GetProperty("idProfesor").GetValue(itemSeleccionado, null);
            }
            else if (profesoresSinMateriaComboBox.SelectedValue != null)
            {
                idProfesor = Convert.ToInt32(profesoresSinMateriaComboBox.SelectedValue);
            }

            if (idProfesor != -1 && materiasDisponiblesComboBox.SelectedValue != null)
            {
                int idMateria = Convert.ToInt32(materiasDisponiblesComboBox.SelectedValue);

                if (gestionProfesores.AsignarMateriaAProfesor(idProfesor, idMateria))
                {
                    MessageBox.Show("Asignación de materia actualizada con éxito.");
                    CargarProfesoresSinMateria();
                    CargarTodosLosProfesores();
                    profesoresSinMateriaComboBox.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error al actualizar la asignación de la materia.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un profesor y una materia.");
            }
        }
    }
}
