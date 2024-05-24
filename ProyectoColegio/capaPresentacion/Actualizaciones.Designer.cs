namespace ProyectoColegio
{
    partial class Actualizaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actualizaciones));
            this.panelinferiorx = new System.Windows.Forms.Panel();
            this.lblactualizacion = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btncerrarinf = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblinformaciones = new System.Windows.Forms.Label();
            this.lblinformacionexpandida = new System.Windows.Forms.Label();
            this.panelinferiorx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelinferiorx
            // 
            this.panelinferiorx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.panelinferiorx.Controls.Add(this.lblactualizacion);
            this.panelinferiorx.Controls.Add(this.btncerrar);
            this.panelinferiorx.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelinferiorx.Location = new System.Drawing.Point(0, 0);
            this.panelinferiorx.Name = "panelinferiorx";
            this.panelinferiorx.Size = new System.Drawing.Size(479, 36);
            this.panelinferiorx.TabIndex = 0;
            this.panelinferiorx.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelinferiorx_MouseDown);
            // 
            // lblactualizacion
            // 
            this.lblactualizacion.AutoSize = true;
            this.lblactualizacion.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblactualizacion.ForeColor = System.Drawing.Color.Silver;
            this.lblactualizacion.Location = new System.Drawing.Point(5, 8);
            this.lblactualizacion.Name = "lblactualizacion";
            this.lblactualizacion.Size = new System.Drawing.Size(273, 16);
            this.lblactualizacion.TabIndex = 19;
            this.lblactualizacion.Text = "Actualización de Sistema de Administración.";
            // 
            // btncerrar
            // 
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(452, 8);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(15, 15);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 18;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btncerrarinf
            // 
            this.btncerrarinf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btncerrarinf.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrarinf.ForeColor = System.Drawing.Color.White;
            this.btncerrarinf.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btncerrarinf.Location = new System.Drawing.Point(336, 304);
            this.btncerrarinf.Margin = new System.Windows.Forms.Padding(0);
            this.btncerrarinf.Name = "btncerrarinf";
            this.btncerrarinf.Size = new System.Drawing.Size(104, 34);
            this.btncerrarinf.TabIndex = 20;
            this.btncerrarinf.Text = "Aceptar";
            this.btncerrarinf.UseVisualStyleBackColor = false;
            this.btncerrarinf.Click += new System.EventHandler(this.btncerrarinf_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // lblinformaciones
            // 
            this.lblinformaciones.AutoSize = true;
            this.lblinformaciones.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinformaciones.Location = new System.Drawing.Point(206, 123);
            this.lblinformaciones.Name = "lblinformaciones";
            this.lblinformaciones.Size = new System.Drawing.Size(119, 32);
            this.lblinformaciones.TabIndex = 22;
            this.lblinformaciones.Text = "Version: 1.1\r\nOliver corporation.";
            // 
            // lblinformacionexpandida
            // 
            this.lblinformacionexpandida.AutoSize = true;
            this.lblinformacionexpandida.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinformacionexpandida.Location = new System.Drawing.Point(45, 226);
            this.lblinformacionexpandida.Name = "lblinformacionexpandida";
            this.lblinformacionexpandida.Size = new System.Drawing.Size(373, 48);
            this.lblinformacionexpandida.TabIndex = 23;
            this.lblinformacionexpandida.Text = "¡Este sistema se encuentra actualizado. \r\nPuedes seguir disfrutando de todas las " +
    "funciones! \r\nCon la versión más reciente que cuentas en esotos momentos.";
            this.lblinformacionexpandida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Actualizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(479, 359);
            this.Controls.Add(this.lblinformacionexpandida);
            this.Controls.Add(this.lblinformaciones);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelinferiorx);
            this.Controls.Add(this.btncerrarinf);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Actualizaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizaciones";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Actualizaciones_MouseDown);
            this.panelinferiorx.ResumeLayout(false);
            this.panelinferiorx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelinferiorx;
        private System.Windows.Forms.Label lblactualizacion;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Button btncerrarinf;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblinformaciones;
        private System.Windows.Forms.Label lblinformacionexpandida;
    }
}