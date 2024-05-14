using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoColegio
{
    public partial class login : Form
    {
        private BaseDeDatos baseDeDatos;
        public login()
        {
            InitializeComponent();
            baseDeDatos = new BaseDeDatos();
            textBoxContraseña.PasswordChar = '*';
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //?
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }





        private void btningresar_Click(object sender, EventArgs e)
        {
            baseDeDatos.AbrirConexion();
            Usuario usuario = baseDeDatos.ValidarUsuario(textBoxUsuario.Text, textBoxContraseña.Text);
            if (usuario != null)
            {
                dashboard dashboard = new dashboard(usuario);
                this.Hide();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Error");
            }
            baseDeDatos.CerrarConexion();


        }

    }
}
