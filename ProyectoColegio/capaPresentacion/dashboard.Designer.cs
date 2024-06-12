namespace ProyectoColegio
{
    partial class dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCargo = new System.Windows.Forms.Label();
            this.ptbUsuario = new System.Windows.Forms.PictureBox();
            this.panelGestionAcademica = new System.Windows.Forms.Panel();
            this.iconButtonInscrAlumnos = new FontAwesome.Sharp.IconButton();
            this.iconButtonGestAcademica = new FontAwesome.Sharp.IconButton();
            this.iconButtonCalificaciones = new FontAwesome.Sharp.IconButton();
            this.iconButtonEstudiantes = new FontAwesome.Sharp.IconButton();
            this.iconButtonRegistroProfesores = new FontAwesome.Sharp.IconButton();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.timerMenuTransicon = new System.Windows.Forms.Timer(this.components);
            this.panelGestionAdministrativa = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.panelReportAdmin = new System.Windows.Forms.Panel();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.iconButton9 = new FontAwesome.Sharp.IconButton();
            this.timerGestAdmin = new System.Windows.Forms.Timer(this.components);
            this.timerReportAdmin = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.iconButton10 = new FontAwesome.Sharp.IconButton();
            this.iconButton11 = new FontAwesome.Sharp.IconButton();
            this.iconButton12 = new FontAwesome.Sharp.IconButton();
            this.iconButton13 = new FontAwesome.Sharp.IconButton();
            this.iconButton14 = new FontAwesome.Sharp.IconButton();
            this.iconButton15 = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsuario)).BeginInit();
            this.panelGestionAcademica.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.panelGestionAdministrativa.SuspendLayout();
            this.panelReportAdmin.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(112)))));
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panelGestionAcademica);
            this.flowLayoutPanel1.Controls.Add(this.panelGestionAdministrativa);
            this.flowLayoutPanel1.Controls.Add(this.panelReportAdmin);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(223, 690);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 42);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(25, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelApellido);
            this.panel2.Controls.Add(this.labelNombre);
            this.panel2.Controls.Add(this.labelCargo);
            this.panel2.Controls.Add(this.ptbUsuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 100);
            this.panel2.TabIndex = 1;
            // 
            // labelApellido
            // 
            this.labelApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.ForeColor = System.Drawing.Color.White;
            this.labelApellido.Location = new System.Drawing.Point(86, 61);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(48, 15);
            this.labelApellido.TabIndex = 20;
            this.labelApellido.Text = "Apellido";
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(86, 37);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(49, 15);
            this.labelNombre.TabIndex = 19;
            this.labelNombre.Text = "Nombre";
            // 
            // labelCargo
            // 
            this.labelCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCargo.AutoSize = true;
            this.labelCargo.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCargo.ForeColor = System.Drawing.Color.White;
            this.labelCargo.Location = new System.Drawing.Point(86, 12);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(47, 15);
            this.labelCargo.TabIndex = 18;
            this.labelCargo.Text = "Cargo:";
            // 
            // ptbUsuario
            // 
            this.ptbUsuario.Image = ((System.Drawing.Image)(resources.GetObject("ptbUsuario.Image")));
            this.ptbUsuario.Location = new System.Drawing.Point(9, 3);
            this.ptbUsuario.Name = "ptbUsuario";
            this.ptbUsuario.Size = new System.Drawing.Size(71, 82);
            this.ptbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbUsuario.TabIndex = 3;
            this.ptbUsuario.TabStop = false;
            // 
            // panelGestionAcademica
            // 
            this.panelGestionAcademica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(112)))));
            this.panelGestionAcademica.Controls.Add(this.iconButtonInscrAlumnos);
            this.panelGestionAcademica.Controls.Add(this.iconButtonGestAcademica);
            this.panelGestionAcademica.Controls.Add(this.iconButtonCalificaciones);
            this.panelGestionAcademica.Controls.Add(this.iconButtonEstudiantes);
            this.panelGestionAcademica.Controls.Add(this.iconButtonRegistroProfesores);
            this.panelGestionAcademica.Location = new System.Drawing.Point(0, 154);
            this.panelGestionAcademica.Margin = new System.Windows.Forms.Padding(0);
            this.panelGestionAcademica.Name = "panelGestionAcademica";
            this.panelGestionAcademica.Size = new System.Drawing.Size(223, 57);
            this.panelGestionAcademica.TabIndex = 1;
            // 
            // iconButtonInscrAlumnos
            // 
            this.iconButtonInscrAlumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.iconButtonInscrAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButtonInscrAlumnos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonInscrAlumnos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButtonInscrAlumnos.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
            this.iconButtonInscrAlumnos.IconColor = System.Drawing.Color.White;
            this.iconButtonInscrAlumnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonInscrAlumnos.IconSize = 30;
            this.iconButtonInscrAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonInscrAlumnos.Location = new System.Drawing.Point(0, 220);
            this.iconButtonInscrAlumnos.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonInscrAlumnos.Name = "iconButtonInscrAlumnos";
            this.iconButtonInscrAlumnos.Size = new System.Drawing.Size(223, 55);
            this.iconButtonInscrAlumnos.TabIndex = 5;
            this.iconButtonInscrAlumnos.Text = "Inscripcion de Alumnos";
            this.iconButtonInscrAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonInscrAlumnos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonInscrAlumnos.UseVisualStyleBackColor = false;
            this.iconButtonInscrAlumnos.Click += new System.EventHandler(this.iconButtonInscrAlumnos_Click);
            // 
            // iconButtonGestAcademica
            // 
            this.iconButtonGestAcademica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.iconButtonGestAcademica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButtonGestAcademica.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonGestAcademica.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButtonGestAcademica.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.iconButtonGestAcademica.IconColor = System.Drawing.Color.White;
            this.iconButtonGestAcademica.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonGestAcademica.IconSize = 30;
            this.iconButtonGestAcademica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonGestAcademica.Location = new System.Drawing.Point(0, 0);
            this.iconButtonGestAcademica.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonGestAcademica.Name = "iconButtonGestAcademica";
            this.iconButtonGestAcademica.Size = new System.Drawing.Size(223, 55);
            this.iconButtonGestAcademica.TabIndex = 0;
            this.iconButtonGestAcademica.Text = "Gestion Academica";
            this.iconButtonGestAcademica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonGestAcademica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonGestAcademica.UseVisualStyleBackColor = false;
            this.iconButtonGestAcademica.Click += new System.EventHandler(this.iconButtonGestAcademica_Click);
            // 
            // iconButtonCalificaciones
            // 
            this.iconButtonCalificaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.iconButtonCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButtonCalificaciones.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCalificaciones.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButtonCalificaciones.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
            this.iconButtonCalificaciones.IconColor = System.Drawing.Color.White;
            this.iconButtonCalificaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCalificaciones.IconSize = 30;
            this.iconButtonCalificaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCalificaciones.Location = new System.Drawing.Point(0, 165);
            this.iconButtonCalificaciones.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonCalificaciones.Name = "iconButtonCalificaciones";
            this.iconButtonCalificaciones.Size = new System.Drawing.Size(223, 55);
            this.iconButtonCalificaciones.TabIndex = 4;
            this.iconButtonCalificaciones.Text = "Calificaciones";
            this.iconButtonCalificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCalificaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCalificaciones.UseVisualStyleBackColor = false;
            this.iconButtonCalificaciones.Click += new System.EventHandler(this.iconButtonCalificaciones_Click);
            // 
            // iconButtonEstudiantes
            // 
            this.iconButtonEstudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.iconButtonEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButtonEstudiantes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonEstudiantes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButtonEstudiantes.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
            this.iconButtonEstudiantes.IconColor = System.Drawing.Color.White;
            this.iconButtonEstudiantes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEstudiantes.IconSize = 30;
            this.iconButtonEstudiantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonEstudiantes.Location = new System.Drawing.Point(0, 55);
            this.iconButtonEstudiantes.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonEstudiantes.Name = "iconButtonEstudiantes";
            this.iconButtonEstudiantes.Size = new System.Drawing.Size(223, 55);
            this.iconButtonEstudiantes.TabIndex = 2;
            this.iconButtonEstudiantes.Text = "Estudiantes";
            this.iconButtonEstudiantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonEstudiantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonEstudiantes.UseVisualStyleBackColor = false;
            this.iconButtonEstudiantes.Click += new System.EventHandler(this.iconButtonEstudiantes_Click);
            // 
            // iconButtonRegistroProfesores
            // 
            this.iconButtonRegistroProfesores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.iconButtonRegistroProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButtonRegistroProfesores.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonRegistroProfesores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButtonRegistroProfesores.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
            this.iconButtonRegistroProfesores.IconColor = System.Drawing.Color.White;
            this.iconButtonRegistroProfesores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonRegistroProfesores.IconSize = 30;
            this.iconButtonRegistroProfesores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonRegistroProfesores.Location = new System.Drawing.Point(0, 110);
            this.iconButtonRegistroProfesores.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonRegistroProfesores.Name = "iconButtonRegistroProfesores";
            this.iconButtonRegistroProfesores.Size = new System.Drawing.Size(223, 55);
            this.iconButtonRegistroProfesores.TabIndex = 3;
            this.iconButtonRegistroProfesores.Text = "Registro Profesores";
            this.iconButtonRegistroProfesores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonRegistroProfesores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonRegistroProfesores.UseVisualStyleBackColor = false;
            this.iconButtonRegistroProfesores.Click += new System.EventHandler(this.iconButtonRegistroProfesores_Click);
            // 
            // panelDashboard
            // 
            this.panelDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.panelDashboard.Controls.Add(this.panel3);
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboard.Location = new System.Drawing.Point(223, 0);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(925, 690);
            this.panelDashboard.TabIndex = 1;
            // 
            // timerMenuTransicon
            // 
            this.timerMenuTransicon.Interval = 10;
            this.timerMenuTransicon.Tick += new System.EventHandler(this.timerMenuTransicon_Tick);
            // 
            // panelGestionAdministrativa
            // 
            this.panelGestionAdministrativa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(112)))));
            this.panelGestionAdministrativa.Controls.Add(this.iconButton1);
            this.panelGestionAdministrativa.Controls.Add(this.iconButton2);
            this.panelGestionAdministrativa.Controls.Add(this.iconButton3);
            this.panelGestionAdministrativa.Controls.Add(this.iconButton4);
            this.panelGestionAdministrativa.Controls.Add(this.iconButton5);
            this.panelGestionAdministrativa.Location = new System.Drawing.Point(0, 211);
            this.panelGestionAdministrativa.Margin = new System.Windows.Forms.Padding(0);
            this.panelGestionAdministrativa.Name = "panelGestionAdministrativa";
            this.panelGestionAdministrativa.Size = new System.Drawing.Size(223, 57);
            this.panelGestionAdministrativa.TabIndex = 6;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 220);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(223, 55);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Cursos";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 0);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(223, 55);
            this.iconButton2.TabIndex = 0;
            this.iconButton2.Text = "Gestion Administratica";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 165);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(223, 55);
            this.iconButton3.TabIndex = 4;
            this.iconButton3.Text = "Mensualidades";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 30;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(0, 55);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(223, 55);
            this.iconButton4.TabIndex = 2;
            this.iconButton4.Text = "Registro Administrativo";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
            this.iconButton5.IconColor = System.Drawing.Color.White;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 30;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(0, 110);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(223, 55);
            this.iconButton5.TabIndex = 3;
            this.iconButton5.Text = "Materias";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = false;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // panelReportAdmin
            // 
            this.panelReportAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(112)))));
            this.panelReportAdmin.Controls.Add(this.iconButton15);
            this.panelReportAdmin.Controls.Add(this.iconButton7);
            this.panelReportAdmin.Controls.Add(this.iconButton14);
            this.panelReportAdmin.Controls.Add(this.iconButton13);
            this.panelReportAdmin.Controls.Add(this.iconButton9);
            this.panelReportAdmin.Location = new System.Drawing.Point(0, 268);
            this.panelReportAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.panelReportAdmin.Name = "panelReportAdmin";
            this.panelReportAdmin.Size = new System.Drawing.Size(223, 57);
            this.panelReportAdmin.TabIndex = 7;
            // 
            // iconButton7
            // 
            this.iconButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.iconButton7.IconColor = System.Drawing.Color.White;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 30;
            this.iconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.Location = new System.Drawing.Point(0, 0);
            this.iconButton7.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(223, 55);
            this.iconButton7.TabIndex = 0;
            this.iconButton7.Text = "Reportes Administrativos";
            this.iconButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton7.UseVisualStyleBackColor = false;
            this.iconButton7.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // iconButton9
            // 
            this.iconButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.iconButton9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton9.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
            this.iconButton9.IconColor = System.Drawing.Color.White;
            this.iconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton9.IconSize = 30;
            this.iconButton9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton9.Location = new System.Drawing.Point(0, 110);
            this.iconButton9.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton9.Name = "iconButton9";
            this.iconButton9.Size = new System.Drawing.Size(223, 55);
            this.iconButton9.TabIndex = 2;
            this.iconButton9.Text = "Reporte Pagos";
            this.iconButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton9.UseVisualStyleBackColor = false;
            this.iconButton9.Click += new System.EventHandler(this.iconButton9_Click);
            // 
            // timerGestAdmin
            // 
            this.timerGestAdmin.Interval = 10;
            this.timerGestAdmin.Tick += new System.EventHandler(this.timerGestAdmin_Tick);
            // 
            // timerReportAdmin
            // 
            this.timerReportAdmin.Interval = 10;
            this.timerReportAdmin.Tick += new System.EventHandler(this.timerReportAdmin_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(112)))));
            this.panel3.Controls.Add(this.iconButton6);
            this.panel3.Controls.Add(this.iconButton8);
            this.panel3.Controls.Add(this.iconButton10);
            this.panel3.Controls.Add(this.iconButton11);
            this.panel3.Controls.Add(this.iconButton12);
            this.panel3.Location = new System.Drawing.Point(675, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 57);
            this.panel3.TabIndex = 7;
            // 
            // iconButton6
            // 
            this.iconButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
            this.iconButton6.IconColor = System.Drawing.Color.White;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 30;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(0, 220);
            this.iconButton6.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(223, 55);
            this.iconButton6.TabIndex = 5;
            this.iconButton6.Text = "Cursos";
            this.iconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton6.UseVisualStyleBackColor = false;
            // 
            // iconButton8
            // 
            this.iconButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.iconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.iconButton8.IconColor = System.Drawing.Color.White;
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.IconSize = 30;
            this.iconButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton8.Location = new System.Drawing.Point(0, 0);
            this.iconButton8.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Size = new System.Drawing.Size(223, 55);
            this.iconButton8.TabIndex = 0;
            this.iconButton8.Text = "Gestion Administratica";
            this.iconButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton8.UseVisualStyleBackColor = false;
            // 
            // iconButton10
            // 
            this.iconButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.iconButton10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton10.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
            this.iconButton10.IconColor = System.Drawing.Color.White;
            this.iconButton10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton10.IconSize = 30;
            this.iconButton10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton10.Location = new System.Drawing.Point(0, 165);
            this.iconButton10.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton10.Name = "iconButton10";
            this.iconButton10.Size = new System.Drawing.Size(223, 55);
            this.iconButton10.TabIndex = 4;
            this.iconButton10.Text = "Mensualidades";
            this.iconButton10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton10.UseVisualStyleBackColor = false;
            // 
            // iconButton11
            // 
            this.iconButton11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.iconButton11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton11.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
            this.iconButton11.IconColor = System.Drawing.Color.White;
            this.iconButton11.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton11.IconSize = 30;
            this.iconButton11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton11.Location = new System.Drawing.Point(0, 55);
            this.iconButton11.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton11.Name = "iconButton11";
            this.iconButton11.Size = new System.Drawing.Size(223, 55);
            this.iconButton11.TabIndex = 2;
            this.iconButton11.Text = "Registro Administrativo";
            this.iconButton11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton11.UseVisualStyleBackColor = false;
            // 
            // iconButton12
            // 
            this.iconButton12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.iconButton12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton12.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
            this.iconButton12.IconColor = System.Drawing.Color.White;
            this.iconButton12.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton12.IconSize = 30;
            this.iconButton12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton12.Location = new System.Drawing.Point(0, 110);
            this.iconButton12.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton12.Name = "iconButton12";
            this.iconButton12.Size = new System.Drawing.Size(223, 55);
            this.iconButton12.TabIndex = 3;
            this.iconButton12.Text = "Materias";
            this.iconButton12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton12.UseVisualStyleBackColor = false;
            // 
            // iconButton13
            // 
            this.iconButton13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.iconButton13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton13.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
            this.iconButton13.IconColor = System.Drawing.Color.White;
            this.iconButton13.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton13.IconSize = 30;
            this.iconButton13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton13.Location = new System.Drawing.Point(0, 55);
            this.iconButton13.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton13.Name = "iconButton13";
            this.iconButton13.Size = new System.Drawing.Size(223, 55);
            this.iconButton13.TabIndex = 8;
            this.iconButton13.Text = "Reporte Inscripcion";
            this.iconButton13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton13.UseVisualStyleBackColor = false;
            this.iconButton13.Click += new System.EventHandler(this.iconButton13_Click);
            // 
            // iconButton14
            // 
            this.iconButton14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.iconButton14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton14.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
            this.iconButton14.IconColor = System.Drawing.Color.White;
            this.iconButton14.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton14.IconSize = 30;
            this.iconButton14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton14.Location = new System.Drawing.Point(0, 165);
            this.iconButton14.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton14.Name = "iconButton14";
            this.iconButton14.Size = new System.Drawing.Size(223, 55);
            this.iconButton14.TabIndex = 9;
            this.iconButton14.Text = "Reporte Notas";
            this.iconButton14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton14.UseVisualStyleBackColor = false;
            this.iconButton14.Click += new System.EventHandler(this.iconButton14_Click);
            // 
            // iconButton15
            // 
            this.iconButton15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.iconButton15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton15.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
            this.iconButton15.IconColor = System.Drawing.Color.White;
            this.iconButton15.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton15.IconSize = 30;
            this.iconButton15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton15.Location = new System.Drawing.Point(0, 220);
            this.iconButton15.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton15.Name = "iconButton15";
            this.iconButton15.Size = new System.Drawing.Size(223, 55);
            this.iconButton15.TabIndex = 10;
            this.iconButton15.Text = "Reporte Materias";
            this.iconButton15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton15.UseVisualStyleBackColor = false;
            this.iconButton15.Click += new System.EventHandler(this.iconButton15_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 690);
            this.Controls.Add(this.panelDashboard);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsuario)).EndInit();
            this.panelGestionAcademica.ResumeLayout(false);
            this.panelDashboard.ResumeLayout(false);
            this.panelGestionAdministrativa.ResumeLayout(false);
            this.panelReportAdmin.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelCargo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private FontAwesome.Sharp.IconButton iconButtonGestAcademica;
        private System.Windows.Forms.Panel panelGestionAcademica;
        private FontAwesome.Sharp.IconButton iconButtonEstudiantes;
        private FontAwesome.Sharp.IconButton iconButtonRegistroProfesores;
        private FontAwesome.Sharp.IconButton iconButtonCalificaciones;
        private FontAwesome.Sharp.IconButton iconButtonInscrAlumnos;
        private System.Windows.Forms.Timer timerMenuTransicon;
        private System.Windows.Forms.Panel panelGestionAdministrativa;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panelReportAdmin;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton9;
        private System.Windows.Forms.Timer timerGestAdmin;
        private System.Windows.Forms.Timer timerReportAdmin;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton iconButton10;
        private FontAwesome.Sharp.IconButton iconButton11;
        private FontAwesome.Sharp.IconButton iconButton12;
        private FontAwesome.Sharp.IconButton iconButton15;
        private FontAwesome.Sharp.IconButton iconButton14;
        private FontAwesome.Sharp.IconButton iconButton13;
    }
}