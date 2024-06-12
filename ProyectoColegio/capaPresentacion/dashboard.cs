using ProyectoColegio.capaPresentacion;
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
    public partial class dashboard : Form
    {
        private Usuario usuario;


        public dashboard(Usuario usuario)
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.usuario = usuario;
            labelCargo.Text = $"Cargo: {usuario.TipoUsuario}";
            labelNombre.Text = $"Nombre: {usuario.Nombre}";
            labelApellido.Text = $"Apellido: {usuario.ApellidoPaterno}";

            // Cambia el estilo del botón a plano
            //TestMenu.FlatStyle = FlatStyle.Flat;
            // Elimina el borde del botón
            //TestMenu.FlatAppearance.BorderSize = 0;
        }
        bool menuExpand = false;

        private void timerMenuTransicon_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                panelGestionAcademica.Height += 10;
                if (panelGestionAcademica.Height >= 275)
                {
                    timerMenuTransicon.Stop();
                    menuExpand = true;

                }
                

            }
            else
            {
                panelGestionAcademica.Height -= 10;
                if (panelGestionAcademica.Height <= 57)
                {
                    timerMenuTransicon.Stop();
                    menuExpand = false;
                }
                
                
            }

        }

        private void timerGestAdmin_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                panelGestionAdministrativa.Height += 10;
                if (panelGestionAdministrativa.Height >= 275)
                {
                    timerGestAdmin.Stop();
                    menuExpand = true;

                }

            }
            else
            {
                
                panelGestionAdministrativa.Height -= 10;
                if (panelGestionAdministrativa.Height <= 57)
                {
                    timerGestAdmin.Stop();
                    menuExpand = false;
                }
            }
        }

        private void timerReportAdmin_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                panelReportAdmin.Height += 10;
                if (panelReportAdmin.Height >= 278)
                {
                    timerReportAdmin.Stop();
                    menuExpand = true;

                }

            }
            else
            {

                panelReportAdmin.Height -= 10;
                if (panelReportAdmin.Height <= 57)
                {
                    timerReportAdmin.Stop();
                    menuExpand = false;
                }
            }

        }


        bool sidebarExpand = true;



        private void iconButtonGestAcademica_Click(object sender, EventArgs e)
        {
            timerMenuTransicon.Start();

        }



        private void iconButtonEstudiantes_Click(object sender, EventArgs e)
        {
            panelDashboard.Controls.Clear();
            estudiantesForm estudiantesForm = new estudiantesForm();
            estudiantesForm.TopLevel = false;
            estudiantesForm.Dock = DockStyle.Fill;
            panelDashboard.Controls.Add(estudiantesForm);
            estudiantesForm.Show();

        }

        private void iconButtonRegistroProfesores_Click(object sender, EventArgs e)
        {
            panelDashboard.Controls.Clear();
            registroProfesoresForm forselect= new registroProfesoresForm();
            forselect.TopLevel = false;
            forselect.Dock = DockStyle.Fill;
            panelDashboard.Controls.Add(forselect);
            forselect.Show();


        }

        private void iconButtonCalificaciones_Click(object sender, EventArgs e)
        {
            panelDashboard.Controls.Clear();
            calificacionesForm forselect = new calificacionesForm();
            forselect.TopLevel = false;
            forselect.Dock = DockStyle.Fill;
            panelDashboard.Controls.Add(forselect);
            forselect.Show();

        }

        private void iconButtonInscrAlumnos_Click(object sender, EventArgs e)
        {
            panelDashboard.Controls.Clear();
            inscripAlumnosForm forselect = new inscripAlumnosForm();
            forselect.TopLevel = false;
            forselect.Dock = DockStyle.Fill;
            panelDashboard.Controls.Add(forselect);
            forselect.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            timerGestAdmin.Start();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            panelDashboard.Controls.Clear();
            registroAdministrativaForm forselect = new registroAdministrativaForm();
            forselect.TopLevel = false;
            forselect.Dock = DockStyle.Fill;
            panelDashboard.Controls.Add(forselect);
            forselect.Show();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            panelDashboard.Controls.Clear();
            materiasForm forselect = new materiasForm();
            forselect.TopLevel = false;
            forselect.Dock = DockStyle.Fill;
            panelDashboard.Controls.Add(forselect);
            forselect.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            panelDashboard.Controls.Clear();
            mensualidadesForm forselect = new mensualidadesForm();
            forselect.TopLevel = false;
            forselect.Dock = DockStyle.Fill;
            panelDashboard.Controls.Add(forselect);
            forselect.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            panelDashboard.Controls.Clear();
            cursosForms forselect = new cursosForms();
            forselect.TopLevel = false;
            forselect.Dock = DockStyle.Fill;
            panelDashboard.Controls.Add(forselect);
            forselect.Show();
        }


        private void iconButton7_Click(object sender, EventArgs e)
        {
            timerReportAdmin.Start();
        }
        private void iconButton9_Click(object sender, EventArgs e)
        {
            panelDashboard.Controls.Clear();
            reportePagosForms forselect = new reportePagosForms();
            forselect.TopLevel = false;
            forselect.Dock = DockStyle.Fill;
            panelDashboard.Controls.Add(forselect);
            forselect.Show();

        }

        private void iconButton13_Click(object sender, EventArgs e)
        {
            panelDashboard.Controls.Clear();
            reporteInscripcionForms forselect = new reporteInscripcionForms();
            forselect.TopLevel = false;
            forselect.Dock = DockStyle.Fill;
            panelDashboard.Controls.Add(forselect);
            forselect.Show();
        }

        private void iconButton14_Click(object sender, EventArgs e)
        {
            panelDashboard.Controls.Clear();
            reporteNotasForms forselect = new reporteNotasForms();
            forselect.TopLevel = false;
            forselect.Dock = DockStyle.Fill;
            panelDashboard.Controls.Add(forselect);
            forselect.Show();
        }

        private void iconButton15_Click(object sender, EventArgs e)
        {
            panelDashboard.Controls.Clear();
            reporteMateriasForms forselect = new reporteMateriasForms();
            forselect.TopLevel = false;
            forselect.Dock = DockStyle.Fill;
            panelDashboard.Controls.Add(forselect);
            forselect.Show();
        }
    }
}
