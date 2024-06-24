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
    public partial class registroAdministrativaForm : Form
    {
        gestionAdministradores gestionAdministradores = new gestionAdministradores();
        public registroAdministrativaForm()
        {
            InitializeComponent();
        }
        private void registroAdministrativaForm_Load(object sender, EventArgs e)
        {
            CargarDatosAdministradores();
            CargarCargos();
        }
        private void CargarCargos()
        {
            DataTable dtCargos = gestionAdministradores.CargarCargos();
            cargoComboBox.DataSource = dtCargos;
            cargoComboBox.DisplayMember = "nombreCargo";
            cargoComboBox.ValueMember = "nombreCargo";
        }


        private void CargarDatosAdministradores()
        {
            try
            {
                administradoresDataGridView.DataSource = gestionAdministradores.ListarAdministradores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }
        private void registrarButton_Click(object sender, EventArgs e)
        {
            string nombre = nombreTextBox.Text;
            string apellido = apellidoTextBox.Text;
            string cargo = cargoComboBox.SelectedValue.ToString();

            gestionAdministradores.AgregarAdministrador(nombre, apellido, cargo);
            MessageBox.Show("Administrador registrado con éxito");
            nombreTextBox.Clear();
            apellidoTextBox.Clear();

        }

        private void actualizarButton_Click(object sender, EventArgs e)
        {
            CargarDatosAdministradores();
        }

        private void guardarCambiosButton_Click(object sender, EventArgs e)
        {
            if (idAdministradorSeleccionado > -1)
            {
                string nombre = nombreTextBox.Text;
                string apellido = apellidoTextBox.Text;
                string cargo = cargoComboBox.SelectedValue.ToString();

                if (gestionAdministradores.EditarAdministrador(idAdministradorSeleccionado, nombre, apellido, cargo))
                {
                    MessageBox.Show("Administrador actualizado con éxito.");
                    CargarDatosAdministradores(); // Actualiza el DataGridView
                    LimpiarCampos(); // Limpia los campos después de actualizar
                }
                else
                {
                    MessageBox.Show("Error al actualizar el administrador.");
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún administrador para editar.");
            }
        }

        private int idAdministradorSeleccionado = -1;
        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (administradoresDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = administradoresDataGridView.SelectedRows[0];
                idAdministradorSeleccionado = Convert.ToInt32(filaSeleccionada.Cells["idAdministrador"].Value);
                nombreTextBox.Text = filaSeleccionada.Cells["nombre"].Value.ToString();
                apellidoTextBox.Text = filaSeleccionada.Cells["apellido"].Value.ToString();
                cargoComboBox.SelectedValue = filaSeleccionada.Cells["cargo"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un administrador para editar.");
            }
        }

        private void LimpiarCampos()
        {
            nombreTextBox.Clear();
            apellidoTextBox.Clear();
            cargoComboBox.SelectedIndex = -1;
            idAdministradorSeleccionado = -1; // Resetea el id seleccionado
        }
    }
}
