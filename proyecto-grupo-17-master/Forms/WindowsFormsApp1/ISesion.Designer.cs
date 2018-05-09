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
            this.txtBRut.Location = new System.Drawing.Point(468, 269);
            this.txtBRut.Multiline = true;
            this.txtBRut.Name = "txtBRut";
            this.txtBRut.Size = new System.Drawing.Size(226, 36);
            this.txtBRut.TabIndex = 0;
            // 
            // txtBContraseña
            // 
            this.txtBContraseña.Location = new System.Drawing.Point(468, 341);
            this.txtBContraseña.Multiline = true;
            this.txtBContraseña.Name = "txtBContraseña";
            this.txtBContraseña.Size = new System.Drawing.Size(226, 33);
            this.txtBContraseña.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(350, 269);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(85, 37);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "RUT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contraseña";
            // 
            // btnIS
            // 
            this.btnIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIS.Location = new System.Drawing.Point(468, 467);
            this.btnIS.Name = "btnIS";
            this.btnIS.Size = new System.Drawing.Size(199, 64);
            this.btnIS.TabIndex = 4;
            this.btnIS.Text = "Iniciar Sesion";
            this.btnIS.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(468, 558);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(199, 64);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ISesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1341, 783);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtBContraseña);
            this.Controls.Add(this.txtBRut);
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