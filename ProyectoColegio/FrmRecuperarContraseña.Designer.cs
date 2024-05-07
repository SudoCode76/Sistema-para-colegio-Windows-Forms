namespace ProyectoColegio
{
    partial class FrmRecuperarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecuperarContraseña));
            this.btncerrarX = new System.Windows.Forms.PictureBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRecupeContra = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCi = new System.Windows.Forms.TextBox();
            this.txtMensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrarX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncerrarX
            // 
            this.btncerrarX.Image = ((System.Drawing.Image)(resources.GetObject("btncerrarX.Image")));
            this.btncerrarX.Location = new System.Drawing.Point(411, 12);
            this.btncerrarX.Name = "btncerrarX";
            this.btncerrarX.Size = new System.Drawing.Size(15, 15);
            this.btncerrarX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrarX.TabIndex = 0;
            this.btncerrarX.TabStop = false;
            this.btncerrarX.Click += new System.EventHandler(this.btncerrarX_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 7;
            this.gunaElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(183, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnRecupeContra
            // 
            this.btnRecupeContra.AnimationHoverSpeed = 0.07F;
            this.btnRecupeContra.AnimationSpeed = 0.03F;
            this.btnRecupeContra.BackColor = System.Drawing.Color.Transparent;
            this.btnRecupeContra.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnRecupeContra.BorderColor = System.Drawing.Color.Black;
            this.btnRecupeContra.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRecupeContra.FocusedColor = System.Drawing.Color.Empty;
            this.btnRecupeContra.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecupeContra.ForeColor = System.Drawing.Color.White;
            this.btnRecupeContra.Image = null;
            this.btnRecupeContra.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRecupeContra.Location = new System.Drawing.Point(131, 294);
            this.btnRecupeContra.Name = "btnRecupeContra";
            this.btnRecupeContra.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(85)))), ((int)(((byte)(133)))));
            this.btnRecupeContra.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRecupeContra.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnRecupeContra.OnHoverImage = null;
            this.btnRecupeContra.OnPressedColor = System.Drawing.Color.Black;
            this.btnRecupeContra.Radius = 20;
            this.btnRecupeContra.Size = new System.Drawing.Size(160, 42);
            this.btnRecupeContra.TabIndex = 3;
            this.btnRecupeContra.Text = "Recuperar Contraseña";
            this.btnRecupeContra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "¿Olvidaste tu contraseña?\r\nNo te preocupes, es posible recuperarla.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese su CI:";
            // 
            // txtCi
            // 
            this.txtCi.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCi.Location = new System.Drawing.Point(162, 219);
            this.txtCi.Name = "txtCi";
            this.txtCi.Size = new System.Drawing.Size(210, 22);
            this.txtCi.TabIndex = 6;
            // 
            // txtMensaje
            // 
            this.txtMensaje.AutoSize = true;
            this.txtMensaje.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtMensaje.Location = new System.Drawing.Point(99, 259);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(15, 16);
            this.txtMensaje.TabIndex = 7;
            this.txtMensaje.Text = "--";
            // 
            // FrmRecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 363);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.txtCi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRecupeContra);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btncerrarX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRecuperarContraseña";
            this.Text = "FrmRecuperarContraseña";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmRecuperarContraseña_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrarX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btncerrarX;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnRecupeContra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtMensaje;
        private System.Windows.Forms.TextBox txtCi;
    }
}