namespace ProyectoColegio
{
    partial class AcercaDeNosotro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcercaDeNosotro));
            this.elipceacerca = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panelsuperiorinf = new System.Windows.Forms.Panel();
            this.sistema = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.panelinferiorok = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblinformacion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelsuperiorinf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.panelinferiorok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // elipceacerca
            // 
            this.elipceacerca.Radius = 6;
            this.elipceacerca.TargetControl = this;
            // 
            // panelsuperiorinf
            // 
            this.panelsuperiorinf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.panelsuperiorinf.Controls.Add(this.sistema);
            this.panelsuperiorinf.Controls.Add(this.btncerrar);
            this.panelsuperiorinf.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsuperiorinf.Location = new System.Drawing.Point(0, 0);
            this.panelsuperiorinf.Name = "panelsuperiorinf";
            this.panelsuperiorinf.Size = new System.Drawing.Size(472, 40);
            this.panelsuperiorinf.TabIndex = 0;
            this.panelsuperiorinf.Paint += new System.Windows.Forms.PaintEventHandler(this.panelsuperiorinf_Paint);
            this.panelsuperiorinf.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelsuperiorinf_MouseDown);
            // 
            // sistema
            // 
            this.sistema.AutoSize = true;
            this.sistema.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sistema.ForeColor = System.Drawing.Color.Silver;
            this.sistema.Location = new System.Drawing.Point(12, 12);
            this.sistema.Name = "sistema";
            this.sistema.Size = new System.Drawing.Size(386, 16);
            this.sistema.TabIndex = 17;
            this.sistema.Text = "Sistema de Administración de la Unidad Educativa Niño Jesús.\r\n";
            // 
            // btncerrar
            // 
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(445, 12);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(15, 15);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 16;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // panelinferiorok
            // 
            this.panelinferiorok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.panelinferiorok.Controls.Add(this.btnOk);
            this.panelinferiorok.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelinferiorok.Location = new System.Drawing.Point(0, 238);
            this.panelinferiorok.Name = "panelinferiorok";
            this.panelinferiorok.Size = new System.Drawing.Size(472, 50);
            this.panelinferiorok.TabIndex = 1;
            this.panelinferiorok.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelinferiorok_MouseDown);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(358, 11);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(89, 27);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblinformacion
            // 
            this.lblinformacion.AutoSize = true;
            this.lblinformacion.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinformacion.Location = new System.Drawing.Point(18, 173);
            this.lblinformacion.Name = "lblinformacion";
            this.lblinformacion.Size = new System.Drawing.Size(429, 64);
            this.lblinformacion.TabIndex = 13;
            this.lblinformacion.Text = "Sistema de Administración de la Unidad Educativa Niño Jesús Version: 1.1\r\nDesarro" +
    "llador de Software: oliverarancibia@gmail.com\r\nCopyright © 2024 . Todos los dere" +
    "chos reservados.\r\n\r\n";
            this.lblinformacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cuidad De Niño Jesús";
            // 
            // AcercaDeNosotro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(472, 288);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblinformacion);
            this.Controls.Add(this.panelinferiorok);
            this.Controls.Add(this.panelsuperiorinf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AcercaDeNosotro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AcercaDeNosotro";
            this.panelsuperiorinf.ResumeLayout(false);
            this.panelsuperiorinf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.panelinferiorok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse elipceacerca;
        private System.Windows.Forms.Panel panelsuperiorinf;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Label lblinformacion;
        private System.Windows.Forms.Panel panelinferiorok;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label sistema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
    }
}