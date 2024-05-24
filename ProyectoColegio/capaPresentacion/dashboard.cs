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

        private void TestMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
