namespace ProyectoColegio.capaPresentacion
{
    partial class mensualidadesForm
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
            this.estudiantesDataGridView = new System.Windows.Forms.DataGridView();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.estudianteNoPagoComboBox = new System.Windows.Forms.ComboBox();
            this.pagarButton = new FontAwesome.Sharp.IconButton();
            this.montoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.observacionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mostrarButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(276, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 47);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mensualidades";
            // 
            // estudiantesDataGridView
            // 
            this.estudiantesDataGridView.AllowUserToOrderColumns = true;
            this.estudiantesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.estudiantesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estudiantesDataGridView.Location = new System.Drawing.Point(31, 309);
            this.estudiantesDataGridView.Name = "estudiantesDataGridView";
            this.estudiantesDataGridView.ReadOnly = true;
            this.estudiantesDataGridView.Size = new System.Drawing.Size(844, 332);
            this.estudiantesDataGridView.TabIndex = 20;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Location = new System.Drawing.Point(68, 232);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(121, 21);
            this.estadoComboBox.TabIndex = 21;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.Location = new System.Drawing.Point(306, 233);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(26, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "Estudiante";
            // 
            // estudianteNoPagoComboBox
            // 
            this.estudianteNoPagoComboBox.FormattingEnabled = true;
            this.estudianteNoPagoComboBox.Location = new System.Drawing.Point(31, 113);
            this.estudianteNoPagoComboBox.Name = "estudianteNoPagoComboBox";
            this.estudianteNoPagoComboBox.Size = new System.Drawing.Size(121, 21);
            this.estudianteNoPagoComboBox.TabIndex = 24;
            // 
            // pagarButton
            // 
            this.pagarButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.pagarButton.IconColor = System.Drawing.Color.Black;
            this.pagarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pagarButton.Location = new System.Drawing.Point(556, 84);
            this.pagarButton.Name = "pagarButton";
            this.pagarButton.Size = new System.Drawing.Size(120, 49);
            this.pagarButton.TabIndex = 25;
            this.pagarButton.Text = "Pagar";
            this.pagarButton.UseVisualStyleBackColor = true;
            this.pagarButton.Click += new System.EventHandler(this.pagarButton_Click);
            // 
            // montoTextBox
            // 
            this.montoTextBox.Location = new System.Drawing.Point(190, 114);
            this.montoTextBox.Name = "montoTextBox";
            this.montoTextBox.Size = new System.Drawing.Size(100, 20);
            this.montoTextBox.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(185, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 30);
            this.label3.TabIndex = 27;
            this.label3.Text = "Monto";
            // 
            // observacionTextBox
            // 
            this.observacionTextBox.Location = new System.Drawing.Point(336, 113);
            this.observacionTextBox.Name = "observacionTextBox";
            this.observacionTextBox.Size = new System.Drawing.Size(151, 20);
            this.observacionTextBox.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(331, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 30);
            this.label4.TabIndex = 29;
            this.label4.Text = "Observaciones";
            // 
            // mostrarButton
            // 
            this.mostrarButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.mostrarButton.IconColor = System.Drawing.Color.Black;
            this.mostrarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mostrarButton.Location = new System.Drawing.Point(556, 204);
            this.mostrarButton.Name = "mostrarButton";
            this.mostrarButton.Size = new System.Drawing.Size(120, 49);
            this.mostrarButton.TabIndex = 30;
            this.mostrarButton.Text = "Mostrar";
            this.mostrarButton.UseVisualStyleBackColor = true;
            this.mostrarButton.Click += new System.EventHandler(this.mostrarButton_Click);
            // 
            // mensualidadesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(925, 690);
            this.Controls.Add(this.mostrarButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.observacionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.montoTextBox);
            this.Controls.Add(this.pagarButton);
            this.Controls.Add(this.estudianteNoPagoComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(this.estadoComboBox);
            this.Controls.Add(this.estudiantesDataGridView);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mensualidadesForm";
            this.Text = "mensualidadesForm";
            this.Load += new System.EventHandler(this.mensualidadesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estudiantesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView estudiantesDataGridView;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox estudianteNoPagoComboBox;
        private FontAwesome.Sharp.IconButton pagarButton;
        private System.Windows.Forms.TextBox montoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox observacionTextBox;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton mostrarButton;
    }
}