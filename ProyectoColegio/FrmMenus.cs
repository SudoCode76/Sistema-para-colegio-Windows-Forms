using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoColegio
{
    public partial class dashBoardForm : Form
    {
        private Usuario usuario;
        public dashBoardForm(Usuario usuario)
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            perzonalizardiseño();
            this.usuario = usuario;
            labelCargo.Text = $"Cargo: {usuario.TipoUsuario}";
            labelNombre.Text = $"Nombre: {usuario.Nombre}";
            labelApellido.Text = $"Apellido: {usuario.ApellidoPaterno}";
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //personlizacion del diseño
        private void perzonalizardiseño()
        { 
            panelgestionacademica.Visible = false;
            panelgestionadministrativa.Visible = false; 
            //panelgestionafinanciera.Visible = false;    
            panelgestioncomunicacion.Visible = false;
            panelreportesacademicos.Visible = false;
            panelreporteadmin.Visible = false;  
            panelconfiguracion.Visible = false;
        }
        private void ocultarsubmenu()
        {
            if(panelgestionacademica.Visible==true)
                panelgestionacademica.Visible=false;
            if(panelgestionadministrativa.Visible==true)
                panelgestionadministrativa.Visible=false;
            if(panelgestioncomunicacion .Visible==true)
                panelgestioncomunicacion.Visible=false;
            if(panelreportesacademicos.Visible==true)
                panelreportesacademicos .Visible=false;  
            if(panelreporteadmin.Visible==true)
                panelreporteadmin.Visible= false;
            if (panelconfiguracion.Visible == true)
                panelconfiguracion.Visible = false;
        }
        private void mostrarsubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarsubmenu();
                subMenu.Visible = true; 
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btngestionacademica_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelgestionacademica);
        }

        

        private void btnregistroprofesores_Click(object sender, EventArgs e)
        {
            abrirformularios(new registrarProfesor());
            ocultarsubmenu();
        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            abrirformularios(new registrarCalificacion());
            ocultarsubmenu();
        }

        

        private void panelsuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelcargo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btncerrarsistema_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
            }
        }

        private void btnmaximo_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState ^= FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btngestionadm_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelgestionadministrativa);
        }

        private void btnregconpersonal_Click(object sender, EventArgs e)
        {
            abrirformularios(new registrarAdministrativo());
            ocultarsubmenu();
        }


        private void btncontrolinvsumistro_Click(object sender, EventArgs e)
        {
            //mostrar nuevo formulario

            //---------------------
            ocultarsubmenu();
        }

        //private void btngestionfinanciera_Click(object sender, EventArgs e)
        //{
        //    mostrarsubmenu(panelgestionafinanciera);
        //}

        private void btngestioncomunicacion_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelgestioncomunicacion);
        }

        private void btncomunicacioninterna_Click(object sender, EventArgs e)
        {
            //mostrar nuevo formulario

            //---------------------
            ocultarsubmenu();
        }

        private void btncomupadres_Click(object sender, EventArgs e)
        {
            //mostrar nuevo formulario

            //---------------------
            ocultarsubmenu();
        }


        //METODOS PARA PODER ABRIR OTROS FORMULARIOS

        private Form activeForms = null;
        private void abrirformularios(Form Formulariohijo)
        {
            if (activeForms != null)
                activeForms.Close();
            activeForms = Formulariohijo;
            Formulariohijo.TopLevel = false;
            Formulariohijo.FormBorderStyle= FormBorderStyle.None;
            Formulariohijo.Dock = DockStyle.Fill;   
            Formulariohijo.BringToFront();
            Formulariohijo.Show();
        }

        private void btncerrarseccion_Click(object sender, EventArgs e)
        {
            login cerrar = new login();
            cerrar.Show();
            this.Hide();
        }

        private void fecha_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btninforme_Click(object sender, EventArgs e)
        {
            //mostrar nuevo formulario

            //---------------------
            ocultarsubmenu();
        }

        private void btninscripcion_Click(object sender, EventArgs e)
        {
            abrirformularios(new registrarInscripcion());
            ocultarsubmenu();
        }

        private void btnprogramacion_Click(object sender, EventArgs e)
        {
            abrirformularios(new registrarProgramacion());
            ocultarsubmenu();
        }

        private void btngestionescolar_Click(object sender, EventArgs e)
        {
            abrirformularios(new registrarGestion());
            ocultarsubmenu();
        }

        private void btnmateria_Click(object sender, EventArgs e)
        {
            abrirformularios(new registrarMateria());
            ocultarsubmenu();
        }

        private void btngrupo_Click(object sender, EventArgs e)
        {
            abrirformularios(new registrarGrupo());
            ocultarsubmenu();
        }

        private void btnMensualidad_Click(object sender, EventArgs e)
        {
            abrirformularios(new registrarMensualidad());
            ocultarsubmenu();
        }

        private void btncursos_Click(object sender, EventArgs e)
        {
            abrirformularios(new regisrarCursos());
            ocultarsubmenu();
        }

        private void btncargo_Click(object sender, EventArgs e)
        {
            //mostrar nuevo formulario

            //---------------------
            ocultarsubmenu();
        }

        private void btnregistropadre_Click(object sender, EventArgs e)
        {
            abrirformularios(new registrarPadre());
            ocultarsubmenu();
        }

        private void btnreportesacademicos_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelreportesacademicos);
        }

        private void btnreporteinscripcion_Click(object sender, EventArgs e)
        {
            //mostrar nuevo formulario

            //---------------------
            ocultarsubmenu();
        }

        private void btnreportenotas_Click(object sender, EventArgs e)
        {
            //mostrar nuevo formulario

            //---------------------
            ocultarsubmenu();
        }

        private void btnrangofechainscripcion_Click(object sender, EventArgs e)
        {
            //mostrar nuevo formulario

            //---------------------
            ocultarsubmenu();
        }

        private void btnreportematerias_Click(object sender, EventArgs e)
        {
            //mostrar nuevo formulario

            //---------------------
            ocultarsubmenu();
        }

        private void btnreporteadministrativo_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelreporteadmin);
        }

        private void btnreporteprofesores_Click(object sender, EventArgs e)
        {
            //mostrar nuevo formulario

            //---------------------
            ocultarsubmenu();
        }

        private void btnreporteprogramacion_Click(object sender, EventArgs e)
        {
            //mostrar nuevo formulario

            //---------------------
            ocultarsubmenu();
        }

       

        private void btnreportepagos_Click(object sender, EventArgs e)
        {
            //mostrar nuevo formulario

            //---------------------
            ocultarsubmenu();
        }

        private void btnconfiguracion_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelconfiguracion);
        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
            abrirformularios(new registrarUsuario());
            ocultarsubmenu();
        }

        private void btnactualizacion_Click(object sender, EventArgs e)
        {
            Actualizaciones actualizaciones = new Actualizaciones();
            actualizaciones.Show();
            ocultarsubmenu();
        }

        private void btnacercadenosotros_Click(object sender, EventArgs e)
        {
            AcercaDeNosotro acercaNosotros = new AcercaDeNosotro();
            acercaNosotros.Show();
            ocultarsubmenu();
        }

        private void btnsoportetecnico_Click(object sender, EventArgs e)
        {
            //abrir pagina web de soporte tecnico
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=XgtmiWBZk2c");
            ocultarsubmenu();
        }

        private void btnreportedocente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnfechapago_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
        }

        private void btnreporteadmin_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
        }


        //botones que abren formulario
        private void btnregistroestudiantes_Click(object sender, EventArgs e)
        {
            panelDashboard.Controls.Clear();
            estudiantesForm formEstudiantes = new estudiantesForm();
            formEstudiantes.TopLevel = false;
            formEstudiantes.Dock = DockStyle.Fill;
            panelDashboard.Controls.Add(formEstudiantes);
            panelDashboard.Show();
            //---------------------
            ocultarsubmenu();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }


    }
}
