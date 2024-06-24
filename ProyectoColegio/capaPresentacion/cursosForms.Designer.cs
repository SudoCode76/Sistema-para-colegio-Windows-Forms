namespace ProyectoColegio.capaPresentacion
{
    partial class cursosForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.agregarCursoButton = new FontAwesome.Sharp.IconButton();
            this.editarCursoButton = new FontAwesome.Sharp.IconButton();
            this.actualizarCursoButton = new FontAwesome.Sharp.IconButton();
            this.nombreCursoTextBox = new System.Windows.Forms.TextBox();
            this.nivelComboBox = new System.Windows.Forms.ComboBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.eliminarCursoButton = new FontAwesome.Sharp.IconButton();
            this.cursosDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cursosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(349, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 47);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cursos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(28, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 30);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(180, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 30);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nivel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(352, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 30);
            this.label4.TabIndex = 26;
            this.label4.Text = "Estado";
            // 
            // agregarCursoButton
            // 
            this.agregarCursoButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.agregarCursoButton.IconColor = System.Drawing.Color.Black;
            this.agregarCursoButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.agregarCursoButton.Location = new System.Drawing.Point(520, 82);
            this.agregarCursoButton.Name = "agregarCursoButton";
            this.agregarCursoButton.Size = new System.Drawing.Size(120, 49);
            this.agregarCursoButton.TabIndex = 27;
            this.agregarCursoButton.Text = "Agregar";
            this.agregarCursoButton.UseVisualStyleBackColor = true;
            this.agregarCursoButton.Click += new System.EventHandler(this.agregarCursoButton_Click);
            // 
            // editarCursoButton
            // 
            this.editarCursoButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.editarCursoButton.IconColor = System.Drawing.Color.Black;
            this.editarCursoButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editarCursoButton.Location = new System.Drawing.Point(265, 582);
            this.editarCursoButton.Name = "editarCursoButton";
            this.editarCursoButton.Size = new System.Drawing.Size(120, 49);
            this.editarCursoButton.TabIndex = 28;
            this.editarCursoButton.Text = "Editar";
            this.editarCursoButton.UseVisualStyleBackColor = true;
            this.editarCursoButton.Click += new System.EventHandler(this.editarCursoButton_Click);
            // 
            // actualizarCursoButton
            // 
            this.actualizarCursoButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.actualizarCursoButton.IconColor = System.Drawing.Color.Black;
            this.actualizarCursoButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.actualizarCursoButton.Location = new System.Drawing.Point(680, 82);
            this.actualizarCursoButton.Name = "actualizarCursoButton";
            this.actualizarCursoButton.Size = new System.Drawing.Size(120, 49);
            this.actualizarCursoButton.TabIndex = 29;
            this.actualizarCursoButton.Text = "Actualizar";
            this.actualizarCursoButton.UseVisualStyleBackColor = true;
            this.actualizarCursoButton.Click += new System.EventHandler(this.actualizarCursoButton_Click);
            // 
            // nombreCursoTextBox
            // 
            this.nombreCursoTextBox.Location = new System.Drawing.Point(33, 110);
            this.nombreCursoTextBox.Name = "nombreCursoTextBox";
            this.nombreCursoTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreCursoTextBox.TabIndex = 30;
            // 
            // nivelComboBox
            // 
            this.nivelComboBox.FormattingEnabled = true;
            this.nivelComboBox.Location = new System.Drawing.Point(185, 110);
            this.nivelComboBox.Name = "nivelComboBox";
            this.nivelComboBox.Size = new System.Drawing.Size(121, 21);
            this.nivelComboBox.TabIndex = 31;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Location = new System.Drawing.Point(357, 110);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(121, 21);
            this.estadoComboBox.TabIndex = 32;
            // 
            // eliminarCursoButton
            // 
            this.eliminarCursoButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.eliminarCursoButton.IconColor = System.Drawing.Color.Black;
            this.eliminarCursoButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.eliminarCursoButton.Location = new System.Drawing.Point(480, 582);
            this.eliminarCursoButton.Name = "eliminarCursoButton";
            this.eliminarCursoButton.Size = new System.Drawing.Size(120, 49);
            this.eliminarCursoButton.TabIndex = 33;
            this.eliminarCursoButton.Text = "Eliminar";
            this.eliminarCursoButton.UseVisualStyleBackColor = true;
            this.eliminarCursoButton.Click += new System.EventHandler(this.eliminarCursoButton_Click);
            // 
            // cursosDataGridView
            // 
            this.cursosDataGridView.AllowUserToOrderColumns = true;
            this.cursosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cursosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cursosDataGridView.Location = new System.Drawing.Point(33, 209);
            this.cursosDataGridView.Name = "cursosDataGridView";
            this.cursosDataGridView.ReadOnly = true;
            this.cursosDataGridView.Size = new System.Drawing.Size(844, 332);
            this.cursosDataGridView.TabIndex = 34;
            // 
            // cursosForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(925, 690);
            this.Controls.Add(this.cursosDataGridView);
            this.Controls.Add(this.eliminarCursoButton);
            this.Controls.Add(this.estadoComboBox);
            this.Controls.Add(this.nivelComboBox);
            this.Controls.Add(this.nombreCursoTextBox);
            this.Controls.Add(this.actualizarCursoButton);
            this.Controls.Add(this.editarCursoButton);
            this.Controls.Add(this.agregarCursoButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cursosForms";
            this.Text = "cursosForms";
            this.Load += new System.EventHandler(this.cursosForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cursosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton agregarCursoButton;
        private FontAwesome.Sharp.IconButton editarCursoButton;
        private FontAwesome.Sharp.IconButton actualizarCursoButton;
        private System.Windows.Forms.TextBox nombreCursoTextBox;
        private System.Windows.Forms.ComboBox nivelComboBox;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private FontAwesome.Sharp.IconButton eliminarCursoButton;
        private System.Windows.Forms.DataGridView cursosDataGridView;
    }
}