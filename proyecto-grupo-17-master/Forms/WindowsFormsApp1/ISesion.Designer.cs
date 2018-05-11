namespace WindowsFormsApp1
{
    partial class ISesion
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
            this.txtBRut = new System.Windows.Forms.TextBox();
            this.txtBContraseña = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIS = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBRut
            // 
            this.txtBRut.Location = new System.Drawing.Point(312, 175);
            this.txtBRut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBRut.Multiline = true;
            this.txtBRut.Name = "txtBRut";
            this.txtBRut.Size = new System.Drawing.Size(152, 25);
            this.txtBRut.TabIndex = 0;
            // 
            // txtBContraseña
            // 
            this.txtBContraseña.Location = new System.Drawing.Point(312, 222);
            this.txtBContraseña.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBContraseña.Multiline = true;
            this.txtBContraseña.Name = "txtBContraseña";
            this.txtBContraseña.PasswordChar = '*';
            this.txtBContraseña.Size = new System.Drawing.Size(152, 23);
            this.txtBContraseña.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(233, 175);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 26);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "RUT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contraseña";
            // 
            // btnIS
            // 
            this.btnIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIS.Location = new System.Drawing.Point(312, 304);
            this.btnIS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIS.Name = "btnIS";
            this.btnIS.Size = new System.Drawing.Size(133, 42);
            this.btnIS.TabIndex = 4;
            this.btnIS.Text = "Iniciar Sesion";
            this.btnIS.UseVisualStyleBackColor = true;
            this.btnIS.Click += new System.EventHandler(this.btnIS_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(312, 363);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(133, 42);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ISesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(894, 487);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtBContraseña);
            this.Controls.Add(this.txtBRut);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ISesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBRut;
        private System.Windows.Forms.TextBox txtBContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIS;
        private System.Windows.Forms.Button btnSalir;
    }
}