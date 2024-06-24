namespace ProyectoColegio.capaPresentacion
{
    partial class reportePagosForms
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
            this.fechaPagoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.estadoPagoComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tipoReporteComboBox = new System.Windows.Forms.ComboBox();
            this.generarReportePagosButton = new FontAwesome.Sharp.IconButton();
            this.guardarReportePagosPDFButton = new FontAwesome.Sharp.IconButton();
            this.imprimirReportePagosButton = new FontAwesome.Sharp.IconButton();
            this.reportePagosDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.reportePagosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(347, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 47);
            this.label2.TabIndex = 5;
            this.label2.Text = "ReportePagos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(28, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 30);
            this.label1.TabIndex = 26;
            this.label1.Text = "Seleccione una fecha";
            // 
            // fechaPagoDateTimePicker
            // 
            this.fechaPagoDateTimePicker.Location = new System.Drawing.Point(33, 122);
            this.fechaPagoDateTimePicker.Name = "fechaPagoDateTimePicker";
            this.fechaPagoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaPagoDateTimePicker.TabIndex = 27;
            // 
            // estadoPagoComboBox
            // 
            this.estadoPagoComboBox.FormattingEnabled = true;
            this.estadoPagoComboBox.Location = new System.Drawing.Point(284, 120);
            this.estadoPagoComboBox.Name = "estadoPagoComboBox";
            this.estadoPagoComboBox.Size = new System.Drawing.Size(121, 21);
            this.estadoPagoComboBox.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(279, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 30);
            this.label3.TabIndex = 29;
            this.label3.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(471, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 30);
            this.label4.TabIndex = 30;
            this.label4.Text = "Tipo de Reporte";
            // 
            // tipoReporteComboBox
            // 
            this.tipoReporteComboBox.FormattingEnabled = true;
            this.tipoReporteComboBox.Location = new System.Drawing.Point(476, 121);
            this.tipoReporteComboBox.Name = "tipoReporteComboBox";
            this.tipoReporteComboBox.Size = new System.Drawing.Size(121, 21);
            this.tipoReporteComboBox.TabIndex = 31;
            // 
            // generarReportePagosButton
            // 
            this.generarReportePagosButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarReportePagosButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.generarReportePagosButton.IconColor = System.Drawing.Color.Black;
            this.generarReportePagosButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.generarReportePagosButton.Location = new System.Drawing.Point(701, 85);
            this.generarReportePagosButton.Name = "generarReportePagosButton";
            this.generarReportePagosButton.Size = new System.Drawing.Size(158, 57);
            this.generarReportePagosButton.TabIndex = 37;
            this.generarReportePagosButton.Text = "GENERAR REPORTE";
            this.generarReportePagosButton.UseVisualStyleBackColor = true;
            this.generarReportePagosButton.Click += new System.EventHandler(this.generarReportePagosButton_Click);
            // 
            // guardarReportePagosPDFButton
            // 
            this.guardarReportePagosPDFButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarReportePagosPDFButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.guardarReportePagosPDFButton.IconColor = System.Drawing.Color.Black;
            this.guardarReportePagosPDFButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.guardarReportePagosPDFButton.Location = new System.Drawing.Point(238, 542);
            this.guardarReportePagosPDFButton.Name = "guardarReportePagosPDFButton";
            this.guardarReportePagosPDFButton.Size = new System.Drawing.Size(158, 57);
            this.guardarReportePagosPDFButton.TabIndex = 41;
            this.guardarReportePagosPDFButton.Text = "GUARDAR";
            this.guardarReportePagosPDFButton.UseVisualStyleBackColor = true;
            this.guardarReportePagosPDFButton.Click += new System.EventHandler(this.guardarReportePagosPDFButton_Click);
            // 
            // imprimirReportePagosButton
            // 
            this.imprimirReportePagosButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprimirReportePagosButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.imprimirReportePagosButton.IconColor = System.Drawing.Color.Black;
            this.imprimirReportePagosButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imprimirReportePagosButton.Location = new System.Drawing.Point(502, 542);
            this.imprimirReportePagosButton.Name = "imprimirReportePagosButton";
            this.imprimirReportePagosButton.Size = new System.Drawing.Size(158, 57);
            this.imprimirReportePagosButton.TabIndex = 40;
            this.imprimirReportePagosButton.Text = "IMPRIMIR";
            this.imprimirReportePagosButton.UseVisualStyleBackColor = true;
            this.imprimirReportePagosButton.Click += new System.EventHandler(this.imprimirReportePagosButton_Click);
            // 
            // reportePagosDataGridView
            // 
            this.reportePagosDataGridView.AllowUserToOrderColumns = true;
            this.reportePagosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reportePagosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportePagosDataGridView.Location = new System.Drawing.Point(33, 169);
            this.reportePagosDataGridView.Name = "reportePagosDataGridView";
            this.reportePagosDataGridView.ReadOnly = true;
            this.reportePagosDataGridView.Size = new System.Drawing.Size(844, 332);
            this.reportePagosDataGridView.TabIndex = 39;
            // 
            // reportePagosForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(925, 690);
            this.Controls.Add(this.guardarReportePagosPDFButton);
            this.Controls.Add(this.imprimirReportePagosButton);
            this.Controls.Add(this.reportePagosDataGridView);
            this.Controls.Add(this.generarReportePagosButton);
            this.Controls.Add(this.tipoReporteComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.estadoPagoComboBox);
            this.Controls.Add(this.fechaPagoDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reportePagosForms";
            this.Text = "reportePagosForms";
            this.Load += new System.EventHandler(this.reportePagosForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportePagosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechaPagoDateTimePicker;
        private System.Windows.Forms.ComboBox estadoPagoComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tipoReporteComboBox;
        private FontAwesome.Sharp.IconButton generarReportePagosButton;
        private FontAwesome.Sharp.IconButton guardarReportePagosPDFButton;
        private FontAwesome.Sharp.IconButton imprimirReportePagosButton;
        private System.Windows.Forms.DataGridView reportePagosDataGridView;
    }
}