namespace ProyectoColegio.capaPresentacion
{
    partial class materiasForm
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
            this.nombreMateriaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gestionTextBox = new System.Windows.Forms.TextBox();
            this.agregarMateriaButton = new FontAwesome.Sharp.IconButton();
            this.materiasDataGridView = new System.Windows.Forms.DataGridView();
            this.editarMateriaButton = new FontAwesome.Sharp.IconButton();
            this.eliminarMateriaButton = new FontAwesome.Sharp.IconButton();
            this.guardarCambiosMateriaButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.materiasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(345, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 47);
            this.label2.TabIndex = 4;
            this.label2.Text = "Materias";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(50, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Materia";
            // 
            // nombreMateriaTextBox
            // 
            this.nombreMateriaTextBox.Location = new System.Drawing.Point(55, 127);
            this.nombreMateriaTextBox.Name = "nombreMateriaTextBox";
            this.nombreMateriaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreMateriaTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(200, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gestion";
            // 
            // gestionTextBox
            // 
            this.gestionTextBox.Location = new System.Drawing.Point(205, 127);
            this.gestionTextBox.Name = "gestionTextBox";
            this.gestionTextBox.Size = new System.Drawing.Size(100, 20);
            this.gestionTextBox.TabIndex = 9;
            this.gestionTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.gestionTextBox_Validating);
            // 
            // agregarMateriaButton
            // 
            this.agregarMateriaButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.agregarMateriaButton.IconColor = System.Drawing.Color.Black;
            this.agregarMateriaButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.agregarMateriaButton.Location = new System.Drawing.Point(353, 98);
            this.agregarMateriaButton.Name = "agregarMateriaButton";
            this.agregarMateriaButton.Size = new System.Drawing.Size(120, 49);
            this.agregarMateriaButton.TabIndex = 10;
            this.agregarMateriaButton.Text = "Agregar";
            this.agregarMateriaButton.UseVisualStyleBackColor = true;
            this.agregarMateriaButton.Click += new System.EventHandler(this.agregarMateriaButton_Click);
            // 
            // materiasDataGridView
            // 
            this.materiasDataGridView.AllowUserToOrderColumns = true;
            this.materiasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.materiasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materiasDataGridView.Location = new System.Drawing.Point(40, 199);
            this.materiasDataGridView.Name = "materiasDataGridView";
            this.materiasDataGridView.ReadOnly = true;
            this.materiasDataGridView.Size = new System.Drawing.Size(844, 180);
            this.materiasDataGridView.TabIndex = 19;
            // 
            // editarMateriaButton
            // 
            this.editarMateriaButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.editarMateriaButton.IconColor = System.Drawing.Color.Black;
            this.editarMateriaButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editarMateriaButton.Location = new System.Drawing.Point(205, 420);
            this.editarMateriaButton.Name = "editarMateriaButton";
            this.editarMateriaButton.Size = new System.Drawing.Size(120, 49);
            this.editarMateriaButton.TabIndex = 23;
            this.editarMateriaButton.Text = "Editar";
            this.editarMateriaButton.UseVisualStyleBackColor = true;
            this.editarMateriaButton.Click += new System.EventHandler(this.editarMateriaButton_Click);
            // 
            // eliminarMateriaButton
            // 
            this.eliminarMateriaButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.eliminarMateriaButton.IconColor = System.Drawing.Color.Black;
            this.eliminarMateriaButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.eliminarMateriaButton.Location = new System.Drawing.Point(473, 420);
            this.eliminarMateriaButton.Name = "eliminarMateriaButton";
            this.eliminarMateriaButton.Size = new System.Drawing.Size(120, 49);
            this.eliminarMateriaButton.TabIndex = 24;
            this.eliminarMateriaButton.Text = "Eliminar";
            this.eliminarMateriaButton.UseVisualStyleBackColor = true;
            this.eliminarMateriaButton.Click += new System.EventHandler(this.eliminarMateriaButton_Click);
            // 
            // guardarCambiosMateriaButton
            // 
            this.guardarCambiosMateriaButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.guardarCambiosMateriaButton.IconColor = System.Drawing.Color.Black;
            this.guardarCambiosMateriaButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.guardarCambiosMateriaButton.Location = new System.Drawing.Point(497, 98);
            this.guardarCambiosMateriaButton.Name = "guardarCambiosMateriaButton";
            this.guardarCambiosMateriaButton.Size = new System.Drawing.Size(120, 49);
            this.guardarCambiosMateriaButton.TabIndex = 25;
            this.guardarCambiosMateriaButton.Text = "Guardar";
            this.guardarCambiosMateriaButton.UseVisualStyleBackColor = true;
            this.guardarCambiosMateriaButton.Click += new System.EventHandler(this.guardarCambiosMateriaButton_Click);
            // 
            // materiasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(925, 690);
            this.Controls.Add(this.guardarCambiosMateriaButton);
            this.Controls.Add(this.eliminarMateriaButton);
            this.Controls.Add(this.editarMateriaButton);
            this.Controls.Add(this.materiasDataGridView);
            this.Controls.Add(this.agregarMateriaButton);
            this.Controls.Add(this.gestionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombreMateriaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "materiasForm";
            this.Text = "materiasForm";
            ((System.ComponentModel.ISupportInitialize)(this.materiasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreMateriaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gestionTextBox;
        private FontAwesome.Sharp.IconButton agregarMateriaButton;
        private System.Windows.Forms.DataGridView materiasDataGridView;
        private FontAwesome.Sharp.IconButton editarMateriaButton;
        private FontAwesome.Sharp.IconButton eliminarMateriaButton;
        private FontAwesome.Sharp.IconButton guardarCambiosMateriaButton;
    }
}