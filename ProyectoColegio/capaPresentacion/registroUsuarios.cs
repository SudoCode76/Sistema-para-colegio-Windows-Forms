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
    public partial class registroUsuarios : Form
    {
        public registroUsuarios()
        {
            InitializeComponent();
        }

        private void registroUsuarios_Load(object sender, EventArgs e)
        {
            cmbTipoUsuario.Items.AddRange(new string[] { "Administrador", "Profesor", "Estandar" });
            ActualizarDataGridUsuarios();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (ValidarCamposUsuario())
            {
                string nombreUsuario = txtNombreUsuario.Text;
                string contrasena = txtContrasena.Text;
                string nombre = txtNombre.Text;
                string apellidoPaterno = txtApellidoPaterno.Text;
                string apellidoMaterno = txtApellidoMaterno.Text;
                string tipoUsuario = cmbTipoUsuario.SelectedItem.ToString();

                BaseDeDatos db = new BaseDeDatos();
                if (db.AgregarUsuario(nombreUsuario, contrasena, nombre, apellidoPaterno, apellidoMaterno, tipoUsuario))
                {
                    MessageBox.Show("Usuario agregado con éxito.");
                    ActualizarDataGridUsuarios();
                    LimpiarCamposUsuario();
                }
                else
                {
                    MessageBox.Show("Error al agregar el usuario.");
                }
            }
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvUsuarios.SelectedRows[0];
                txtNombreUsuario.Text = filaSeleccionada.Cells["nombreUsuario"].Value.ToString();
                txtContrasena.Text = filaSeleccionada.Cells["contrasena"].Value.ToString();
                txtNombre.Text = filaSeleccionada.Cells["nombre"].Value.ToString();
                txtApellidoPaterno.Text = filaSeleccionada.Cells["apellidoPaterno"].Value.ToString();
                txtApellidoMaterno.Text = filaSeleccionada.Cells["apellidoMaterno"].Value.ToString();
                cmbTipoUsuario.SelectedItem = filaSeleccionada.Cells["tipoUsuario"].Value.ToString();

                txtNombreUsuario.Enabled = false; // No se puede cambiar el nombre de usuario
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para editar.");
            }
        }

        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0 && ValidarCamposUsuario())
            {
                string nombreUsuario = txtNombreUsuario.Text;
                string contrasena = txtContrasena.Text;
                string nombre = txtNombre.Text;
                string apellidoPaterno = txtApellidoPaterno.Text;
                string apellidoMaterno = txtApellidoMaterno.Text;
                string tipoUsuario = cmbTipoUsuario.SelectedItem.ToString();

                BaseDeDatos db = new BaseDeDatos();
                if (db.ActualizarUsuario(nombreUsuario, contrasena, nombre, apellidoPaterno, apellidoMaterno, tipoUsuario))
                {
                    MessageBox.Show("Usuario actualizado con éxito.");
                    ActualizarDataGridUsuarios();
                    LimpiarCamposUsuario();
                    txtNombreUsuario.Enabled = true; // Permitir cambiar el nombre de usuario para nuevos registros
                }
                else
                {
                    MessageBox.Show("Error al actualizar el usuario.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para actualizar.");
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvUsuarios.SelectedRows[0];
                string nombreUsuario = filaSeleccionada.Cells["nombreUsuario"].Value.ToString();

                BaseDeDatos db = new BaseDeDatos();
                if (db.EliminarUsuario(nombreUsuario))
                {
                    MessageBox.Show("Usuario eliminado con éxito.");
                    ActualizarDataGridUsuarios();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el usuario.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para eliminar.");
            }
        }

        private void ActualizarDataGridUsuarios()
        {
            BaseDeDatos db = new BaseDeDatos();
            dgvUsuarios.DataSource = db.ObtenerUsuarios();
        }

        private void LimpiarCamposUsuario()
        {
            txtNombreUsuario.Clear();
            txtContrasena.Clear();
            txtNombre.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            cmbTipoUsuario.SelectedIndex = -1;
        }

        private bool ValidarCamposUsuario()
        {
            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContrasena.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoPaterno.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoMaterno.Text) ||
                cmbTipoUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return false;
            }

            if (txtNombre.Text.Any(char.IsDigit))
            {
                MessageBox.Show("El campo 'Nombre' solo debe contener letras.");
                return false;
            }

            if (txtApellidoPaterno.Text.Any(char.IsDigit))
            {
                MessageBox.Show("El campo 'Apellido Paterno' solo debe contener letras.");
                return false;
            }

            if (txtApellidoMaterno.Text.Any(char.IsDigit))
            {
                MessageBox.Show("El campo 'Apellido Materno' solo debe contener letras.");
                return false;
            }

            return true;
        }


    }
}
