namespace ProyectoColegio.capaPresentacion
{
    partial class registroAdministrativaForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.registrarButton = new FontAwesome.Sharp.IconButton();
            this.guardarCambiosButton = new FontAwesome.Sharp.IconButton();
            this.administradoresDataGridView = new System.Windows.Forms.DataGridView();
            this.actualizarButton = new FontAwesome.Sharp.IconButton();
            this.cargoComboBox = new System.Windows.Forms.ComboBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.administradoresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(257, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 47);
            this.label2.TabIndex = 3;
            this.label2.Text = "Registro Administrativo";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(59, 149);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(59, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(322, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cargo";
            // 
            // registrarButton
            // 
            this.registrarButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.registrarButton.IconColor = System.Drawing.Color.Black;
            this.registrarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.registrarButton.Location = new System.Drawing.Point(472, 122);
            this.registrarButton.Name = "registrarButton";
            this.registrarButton.Size = new System.Drawing.Size(120, 49);
            this.registrarButton.TabIndex = 8;
            this.registrarButton.Text = "Registrar";
            this.registrarButton.UseVisualStyleBackColor = true;
            this.registrarButton.Click += new System.EventHandler(this.registrarButton_Click);
            // 
            // guardarCambiosButton
            // 
            this.guardarCambiosButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.guardarCambiosButton.IconColor = System.Drawing.Color.Black;
            this.guardarCambiosButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.guardarCambiosButton.Location = new System.Drawing.Point(764, 121);
            this.guardarCambiosButton.Name = "guardarCambiosButton";
            this.guardarCambiosButton.Size = new System.Drawing.Size(120, 49);
            this.guardarCambiosButton.TabIndex = 10;
            this.guardarCambiosButton.Text = "Guardar";
            this.guardarCambiosButton.UseVisualStyleBackColor = true;
            this.guardarCambiosButton.Click += new System.EventHandler(this.guardarCambiosButton_Click);
            // 
            // administradoresDataGridView
            // 
            this.administradoresDataGridView.AllowUserToOrderColumns = true;
            this.administradoresDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.administradoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.administradoresDataGridView.Location = new System.Drawing.Point(40, 270);
            this.administradoresDataGridView.Name = "administradoresDataGridView";
            this.administradoresDataGridView.ReadOnly = true;
            this.administradoresDataGridView.Size = new System.Drawing.Size(844, 150);
            this.administradoresDataGridView.TabIndex = 18;
            // 
            // actualizarButton
            // 
            this.actualizarButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.actualizarButton.IconColor = System.Drawing.Color.Black;
            this.actualizarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.actualizarButton.Location = new System.Drawing.Point(625, 122);
            this.actualizarButton.Name = "actualizarButton";
            this.actualizarButton.Size = new System.Drawing.Size(120, 49);
            this.actualizarButton.TabIndex = 9;
            this.actualizarButton.Text = "Actualizar";
            this.actualizarButton.UseVisualStyleBackColor = true;
            this.actualizarButton.Click += new System.EventHandler(this.actualizarButton_Click);
            // 
            // cargoComboBox
            // 
            this.cargoComboBox.FormattingEnabled = true;
            this.cargoComboBox.Location = new System.Drawing.Point(327, 149);
            this.cargoComboBox.Name = "cargoComboBox";
            this.cargoComboBox.Size = new System.Drawing.Size(121, 21);
            this.cargoComboBox.TabIndex = 19;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Location = new System.Drawing.Point(183, 149);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(100, 20);
            this.apellidoTextBox.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(178, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 30);
            this.label4.TabIndex = 21;
            this.label4.Text = "Apellido";
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(406, 452);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(120, 49);
            this.iconButton1.TabIndex = 22;
            this.iconButton1.Text = "Editar";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // registroAdministrativaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(925, 690);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(this.cargoComboBox);
            this.Controls.Add(this.administradoresDataGridView);
            this.Controls.Add(this.guardarCambiosButton);
            this.Controls.Add(this.actualizarButton);
            this.Controls.Add(this.registrarButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registroAdministrativaForm";
            this.Text = "gestionAdministrativaForm";
            this.Load += new System.EventHandler(this.registroAdministrativaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.administradoresDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton registrarButton;
        private FontAwesome.Sharp.IconButton guardarCambiosButton;
        private System.Windows.Forms.DataGridView administradoresDataGridView;
        private FontAwesome.Sharp.IconButton actualizarButton;
        private System.Windows.Forms.ComboBox cargoComboBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}