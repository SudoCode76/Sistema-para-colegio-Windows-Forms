namespace ProyectoColegio.capaPresentacion
{
    partial class reporteInscripcionForms
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
            this.fechaReporteDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reporteDataGridView = new System.Windows.Forms.DataGridView();
            this.generarReporteButton = new FontAwesome.Sharp.IconButton();
            this.imprimirReporteButton = new FontAwesome.Sharp.IconButton();
            this.guardarPDFButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(285, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 47);
            this.label2.TabIndex = 5;
            this.label2.Text = "Reporte Inscripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(29, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 30);
            this.label1.TabIndex = 25;
            this.label1.Text = "Seleccione una fecha";
            // 
            // fechaReporteDateTimePicker
            // 
            this.fechaReporteDateTimePicker.Location = new System.Drawing.Point(34, 108);
            this.fechaReporteDateTimePicker.Name = "fechaReporteDateTimePicker";
            this.fechaReporteDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaReporteDateTimePicker.TabIndex = 26;
            // 
            // reporteDataGridView
            // 
            this.reporteDataGridView.AllowUserToOrderColumns = true;
            this.reporteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reporteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reporteDataGridView.Location = new System.Drawing.Point(34, 151);
            this.reporteDataGridView.Name = "reporteDataGridView";
            this.reporteDataGridView.ReadOnly = true;
            this.reporteDataGridView.Size = new System.Drawing.Size(844, 332);
            this.reporteDataGridView.TabIndex = 35;
            // 
            // generarReporteButton
            // 
            this.generarReporteButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarReporteButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.generarReporteButton.IconColor = System.Drawing.Color.Black;
            this.generarReporteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.generarReporteButton.Location = new System.Drawing.Point(331, 71);
            this.generarReporteButton.Name = "generarReporteButton";
            this.generarReporteButton.Size = new System.Drawing.Size(158, 57);
            this.generarReporteButton.TabIndex = 36;
            this.generarReporteButton.Text = "GENERAR REPORTE";
            this.generarReporteButton.UseVisualStyleBackColor = true;
            this.generarReporteButton.Click += new System.EventHandler(this.generarReporteButton_Click);
            // 
            // imprimirReporteButton
            // 
            this.imprimirReporteButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprimirReporteButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.imprimirReporteButton.IconColor = System.Drawing.Color.Black;
            this.imprimirReporteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imprimirReporteButton.Location = new System.Drawing.Point(503, 524);
            this.imprimirReporteButton.Name = "imprimirReporteButton";
            this.imprimirReporteButton.Size = new System.Drawing.Size(158, 57);
            this.imprimirReporteButton.TabIndex = 37;
            this.imprimirReporteButton.Text = "IMPRIMIR";
            this.imprimirReporteButton.UseVisualStyleBackColor = true;
            this.imprimirReporteButton.Click += new System.EventHandler(this.imprimirReporteButton_Click);
            // 
            // guardarPDFButton
            // 
            this.guardarPDFButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarPDFButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.guardarPDFButton.IconColor = System.Drawing.Color.Black;
            this.guardarPDFButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.guardarPDFButton.Location = new System.Drawing.Point(239, 524);
            this.guardarPDFButton.Name = "guardarPDFButton";
            this.guardarPDFButton.Size = new System.Drawing.Size(158, 57);
            this.guardarPDFButton.TabIndex = 38;
            this.guardarPDFButton.Text = "GUARDAR";
            this.guardarPDFButton.UseVisualStyleBackColor = true;
            this.guardarPDFButton.Click += new System.EventHandler(this.guardarPDFButton_Click);
            // 
            // reporteInscripcionForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(925, 690);
            this.Controls.Add(this.guardarPDFButton);
            this.Controls.Add(this.imprimirReporteButton);
            this.Controls.Add(this.generarReporteButton);
            this.Controls.Add(this.reporteDataGridView);
            this.Controls.Add(this.fechaReporteDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reporteInscripcionForms";
            this.Text = "reporteInscripcionForms";
            this.Load += new System.EventHandler(this.reporteInscripcionForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechaReporteDateTimePicker;
        private System.Windows.Forms.DataGridView reporteDataGridView;
        private FontAwesome.Sharp.IconButton generarReporteButton;
        private FontAwesome.Sharp.IconButton imprimirReporteButton;
        private FontAwesome.Sharp.IconButton guardarPDFButton;
    }
}