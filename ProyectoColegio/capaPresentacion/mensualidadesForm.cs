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
    public partial class mensualidadesForm : Form
    {
        gestionMensualidad gestionMensualidad = new gestionMensualidad();
        public mensualidadesForm()
        {
            InitializeComponent();
        }
        private void mensualidadesForm_Load(object sender, EventArgs e)
        {
            estadoComboBox.Items.Add("Pagado");
            estadoComboBox.Items.Add("No Pagado");
            estadoComboBox.SelectedIndex = 0; // Por defecto mostrar estudiantes que pagaron

            fechaDateTimePicker.Format = DateTimePickerFormat.Custom;
            fechaDateTimePicker.CustomFormat = "MMMM yyyy";
            fechaDateTimePicker.ShowUpDown = true;

            CargarEstudiantes();
            CargarEstudiantesNoPago();

        }

        private void mostrarButton_Click(object sender, EventArgs e)
        {
            CargarEstudiantes();

        }




        private void CargarEstudiantes()
        {
            bool pagado = estadoComboBox.SelectedItem.ToString() == "Pagado";
            DateTime fecha = fechaDateTimePicker.Value;
            int mes = fecha.Month;
            int anio = fecha.Year;

            estudiantesDataGridView.DataSource = gestionMensualidad.ObtenerEstudiantesPorEstadoYFecha(pagado, mes, anio);
        }
        private void CargarEstudiantesNoPago()
        {
            DateTime fecha = fechaDateTimePicker.Value;
            int mes = fecha.Month;
            int anio = fecha.Year;

            DataTable dtEstudiantesNoPago = gestionMensualidad.ObtenerEstudiantesPorEstadoYFecha(false, mes, anio);
            estudianteNoPagoComboBox.DataSource = dtEstudiantesNoPago;
            estudianteNoPagoComboBox.DisplayMember = "nombreCompleto";
            estudianteNoPagoComboBox.ValueMember = "idEstudiante";
        }

        


        private void pagarButton_Click(object sender, EventArgs e)
        {
            if (estudianteNoPagoComboBox.SelectedValue != null)
            {
                int idEstudiante = Convert.ToInt32(estudianteNoPagoComboBox.SelectedValue);
                decimal monto;
                if (!decimal.TryParse(montoTextBox.Text, out monto))
                {
                    MessageBox.Show("Por favor, ingrese un monto válido.");
                    return;
                }

                string observacion = observacionTextBox.Text;

                gestionMensualidad.RegistrarPagoEstudiante(idEstudiante, monto, observacion);
                MessageBox.Show("Pago registrado con éxito.");

                CargarEstudiantes(); // Actualiza la lista de estudiantes
                CargarEstudiantesNoPago(); // Actualiza el comboBox de estudiantes que no pagaron
                LimpiarCamposPago(); // Limpia los campos de entrada
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un estudiante que no haya pagado.");
            }


        }
        private void LimpiarCamposPago()
        {
            montoTextBox.Clear();
            observacionTextBox.Clear();
            estudianteNoPagoComboBox.SelectedIndex = -1;
        }

        
    }
}
