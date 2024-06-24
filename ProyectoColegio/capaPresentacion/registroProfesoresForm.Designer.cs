namespace ProyectoColegio.capaPresentacion
{
    partial class registroProfesoresForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreProfesorTextBox = new System.Windows.Forms.TextBox();
            this.apellidoProfesorTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.direccionProfesorTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailProfesorTextBox = new System.Windows.Forms.TextBox();
            this.telefonoProfesorTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.profesoresSinMateriaComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.agregarProfesorButton = new FontAwesome.Sharp.IconButton();
            this.asignarMateriaButton = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.materiasDisponiblesComboBox = new System.Windows.Forms.ComboBox();
            this.profesoresDataGridView = new System.Windows.Forms.DataGridView();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.profesoresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(260, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registrar Profesores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(26, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // nombreProfesorTextBox
            // 
            this.nombreProfesorTextBox.Location = new System.Drawing.Point(31, 129);
            this.nombreProfesorTextBox.Name = "nombreProfesorTextBox";
            this.nombreProfesorTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreProfesorTextBox.TabIndex = 3;
            // 
            // apellidoProfesorTextBox
            // 
            this.apellidoProfesorTextBox.Location = new System.Drawing.Point(143, 129);
            this.apellidoProfesorTextBox.Name = "apellidoProfesorTextBox";
            this.apellidoProfesorTextBox.Size = new System.Drawing.Size(100, 20);
            this.apellidoProfesorTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(138, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(265, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Direccion";
            // 
            // direccionProfesorTextBox
            // 
            this.direccionProfesorTextBox.Location = new System.Drawing.Point(270, 129);
            this.direccionProfesorTextBox.Name = "direccionProfesorTextBox";
            this.direccionProfesorTextBox.Size = new System.Drawing.Size(100, 20);
            this.direccionProfesorTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(535, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // emailProfesorTextBox
            // 
            this.emailProfesorTextBox.Location = new System.Drawing.Point(540, 129);
            this.emailProfesorTextBox.Name = "emailProfesorTextBox";
            this.emailProfesorTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailProfesorTextBox.TabIndex = 9;
            // 
            // telefonoProfesorTextBox
            // 
            this.telefonoProfesorTextBox.Location = new System.Drawing.Point(403, 129);
            this.telefonoProfesorTextBox.Name = "telefonoProfesorTextBox";
            this.telefonoProfesorTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonoProfesorTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(398, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(260, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(300, 47);
            this.label7.TabIndex = 12;
            this.label7.Text = "Asignar Materias";
            // 
            // profesoresSinMateriaComboBox
            // 
            this.profesoresSinMateriaComboBox.FormattingEnabled = true;
            this.profesoresSinMateriaComboBox.Location = new System.Drawing.Point(208, 300);
            this.profesoresSinMateriaComboBox.Name = "profesoresSinMateriaComboBox";
            this.profesoresSinMateriaComboBox.Size = new System.Drawing.Size(121, 21);
            this.profesoresSinMateriaComboBox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(203, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Profesor:";
            // 
            // agregarProfesorButton
            // 
            this.agregarProfesorButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.agregarProfesorButton.IconColor = System.Drawing.Color.Black;
            this.agregarProfesorButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.agregarProfesorButton.Location = new System.Drawing.Point(668, 101);
            this.agregarProfesorButton.Name = "agregarProfesorButton";
            this.agregarProfesorButton.Size = new System.Drawing.Size(123, 48);
            this.agregarProfesorButton.TabIndex = 17;
            this.agregarProfesorButton.Text = "Registrar";
            this.agregarProfesorButton.UseVisualStyleBackColor = true;
            this.agregarProfesorButton.Click += new System.EventHandler(this.agregarProfesorButton_Click);
            // 
            // asignarMateriaButton
            // 
            this.asignarMateriaButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.asignarMateriaButton.IconColor = System.Drawing.Color.Black;
            this.asignarMateriaButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.asignarMateriaButton.Location = new System.Drawing.Point(540, 273);
            this.asignarMateriaButton.Name = "asignarMateriaButton";
            this.asignarMateriaButton.Size = new System.Drawing.Size(123, 48);
            this.asignarMateriaButton.TabIndex = 18;
            this.asignarMateriaButton.Text = "Asignar";
            this.asignarMateriaButton.UseVisualStyleBackColor = true;
            this.asignarMateriaButton.Click += new System.EventHandler(this.asignarMateriaButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(366, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Materia:";
            // 
            // materiasDisponiblesComboBox
            // 
            this.materiasDisponiblesComboBox.FormattingEnabled = true;
            this.materiasDisponiblesComboBox.Location = new System.Drawing.Point(371, 300);
            this.materiasDisponiblesComboBox.Name = "materiasDisponiblesComboBox";
            this.materiasDisponiblesComboBox.Size = new System.Drawing.Size(121, 21);
            this.materiasDisponiblesComboBox.TabIndex = 19;
            // 
            // profesoresDataGridView
            // 
            this.profesoresDataGridView.AllowUserToOrderColumns = true;
            this.profesoresDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.profesoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profesoresDataGridView.Location = new System.Drawing.Point(22, 350);
            this.profesoresDataGridView.Name = "profesoresDataGridView";
            this.profesoresDataGridView.ReadOnly = true;
            this.profesoresDataGridView.Size = new System.Drawing.Size(844, 195);
            this.profesoresDataGridView.TabIndex = 21;
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(297, 587);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(123, 48);
            this.iconButton2.TabIndex = 22;
            this.iconButton2.Text = "Editar Datos";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(506, 587);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(123, 48);
            this.iconButton3.TabIndex = 23;
            this.iconButton3.Text = "Editar Asignacion";
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(22, 587);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(123, 48);
            this.iconButton1.TabIndex = 24;
            this.iconButton1.Text = "Eliminar";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.Location = new System.Drawing.Point(812, 101);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(101, 48);
            this.iconButton4.TabIndex = 25;
            this.iconButton4.Text = "Actualizar";
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconButton5
            // 
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.Location = new System.Drawing.Point(688, 273);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(123, 48);
            this.iconButton5.TabIndex = 26;
            this.iconButton5.Text = "Actualizar";
            this.iconButton5.UseVisualStyleBackColor = true;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // registroProfesoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(925, 690);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.profesoresDataGridView);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.materiasDisponiblesComboBox);
            this.Controls.Add(this.asignarMateriaButton);
            this.Controls.Add(this.agregarProfesorButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.profesoresSinMateriaComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.telefonoProfesorTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.emailProfesorTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.direccionProfesorTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.apellidoProfesorTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombreProfesorTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registroProfesoresForm";
            this.Text = "registroProfesoresForm";
            this.Load += new System.EventHandler(this.registroProfesoresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profesoresDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombreProfesorTextBox;
        private System.Windows.Forms.TextBox apellidoProfesorTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox direccionProfesorTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailProfesorTextBox;
        private System.Windows.Forms.TextBox telefonoProfesorTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox profesoresSinMateriaComboBox;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton agregarProfesorButton;
        private FontAwesome.Sharp.IconButton asignarMateriaButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox materiasDisponiblesComboBox;
        private System.Windows.Forms.DataGridView profesoresDataGridView;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton5;
    }
}