namespace LostAndFound
{

    partial class Form1
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
            this.LOGIN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelrut = new System.Windows.Forms.Label();
            this.ruttext = new System.Windows.Forms.TextBox();
            this.miclave = new System.Windows.Forms.TextBox();
            this.boton_login = new System.Windows.Forms.Button();
            this.boton_nuevaCuenta = new System.Windows.Forms.Button();
            this.c_horas = new System.Windows.Forms.TextBox();
            this.c_dias = new System.Windows.Forms.TextBox();
            this.c_usuarios = new System.Windows.Forms.TextBox();
            this.simulation = new System.Windows.Forms.Label();
            this.boton_simulacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LOGIN
            // 
            this.LOGIN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LOGIN.AutoSize = true;
            this.LOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN.Location = new System.Drawing.Point(57, 48);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(45, 13);
            this.LOGIN.TabIndex = 0;
            this.LOGIN.Text = "LOGIN";
            this.LOGIN.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONTRASEÑA";
            this.label1.Visible = false;
            // 
            // labelrut
            // 
            this.labelrut.AutoSize = true;
            this.labelrut.Location = new System.Drawing.Point(177, 98);
            this.labelrut.Name = "labelrut";
            this.labelrut.Size = new System.Drawing.Size(30, 13);
            this.labelrut.TabIndex = 2;
            this.labelrut.Text = "RUT";
            this.labelrut.Visible = false;
            // 
            // ruttext
            // 
            this.ruttext.Location = new System.Drawing.Point(320, 91);
            this.ruttext.Name = "ruttext";
            this.ruttext.Size = new System.Drawing.Size(166, 20);
            this.ruttext.TabIndex = 3;
            this.ruttext.Visible = false;
            // 
            // miclave
            // 
            this.miclave.Location = new System.Drawing.Point(320, 158);
            this.miclave.Name = "miclave";
            this.miclave.PasswordChar = '*';
            this.miclave.Size = new System.Drawing.Size(166, 20);
            this.miclave.TabIndex = 4;
            this.miclave.Visible = false;
            // 
            // boton_login
            // 
            this.boton_login.Location = new System.Drawing.Point(224, 232);
            this.boton_login.Name = "boton_login";
            this.boton_login.Size = new System.Drawing.Size(75, 23);
            this.boton_login.TabIndex = 5;
            this.boton_login.Text = "LOGIN";
            this.boton_login.UseVisualStyleBackColor = true;
            this.boton_login.Visible = false;
            this.boton_login.Click += new System.EventHandler(this.boton_login_Click);
            // 
            // boton_nuevaCuenta
            // 
            this.boton_nuevaCuenta.Location = new System.Drawing.Point(357, 232);
            this.boton_nuevaCuenta.Name = "boton_nuevaCuenta";
            this.boton_nuevaCuenta.Size = new System.Drawing.Size(155, 23);
            this.boton_nuevaCuenta.TabIndex = 6;
            this.boton_nuevaCuenta.Text = "CREAR NUEVA CUENTA";
            this.boton_nuevaCuenta.UseVisualStyleBackColor = true;
            this.boton_nuevaCuenta.Visible = false;
            this.boton_nuevaCuenta.Click += new System.EventHandler(this.boton_nuevaCuenta_Click);
            // 
            // c_horas
            // 
            this.c_horas.Location = new System.Drawing.Point(519, 128);
            this.c_horas.Name = "c_horas";
            this.c_horas.Size = new System.Drawing.Size(100, 20);
            this.c_horas.TabIndex = 7;
            this.c_horas.Text = "cantidad de horas";
            // 
            // c_dias
            // 
            this.c_dias.Location = new System.Drawing.Point(365, 128);
            this.c_dias.Name = "c_dias";
            this.c_dias.Size = new System.Drawing.Size(100, 20);
            this.c_dias.TabIndex = 8;
            this.c_dias.Text = "cantidad de dias";
            // 
            // c_usuarios
            // 
            this.c_usuarios.Location = new System.Drawing.Point(158, 128);
            this.c_usuarios.Name = "c_usuarios";
            this.c_usuarios.Size = new System.Drawing.Size(100, 20);
            this.c_usuarios.TabIndex = 9;
            this.c_usuarios.Text = "cantidad de usuarios";
            // 
            // simulation
            // 
            this.simulation.AutoSize = true;
            this.simulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simulation.Location = new System.Drawing.Point(314, 36);
            this.simulation.Name = "simulation";
            this.simulation.Size = new System.Drawing.Size(151, 25);
            this.simulation.TabIndex = 10;
            this.simulation.Text = "SIMULACION";
            // 
            // boton_simulacion
            // 
            this.boton_simulacion.Location = new System.Drawing.Point(357, 301);
            this.boton_simulacion.Name = "boton_simulacion";
            this.boton_simulacion.Size = new System.Drawing.Size(75, 23);
            this.boton_simulacion.TabIndex = 11;
            this.boton_simulacion.Text = "enter";
            this.boton_simulacion.UseVisualStyleBackColor = true;
            this.boton_simulacion.Click += new System.EventHandler(this.boton_simulacion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boton_simulacion);
            this.Controls.Add(this.simulation);
            this.Controls.Add(this.c_usuarios);
            this.Controls.Add(this.c_dias);
            this.Controls.Add(this.c_horas);
            this.Controls.Add(this.boton_nuevaCuenta);
            this.Controls.Add(this.boton_login);
            this.Controls.Add(this.miclave);
            this.Controls.Add(this.ruttext);
            this.Controls.Add(this.labelrut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LOGIN);
            this.Name = "Form1";
            this.Text = "grupo 17";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LOGIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelrut;
        private System.Windows.Forms.TextBox ruttext;
        private System.Windows.Forms.TextBox miclave;
        private System.Windows.Forms.Button boton_login;
        private System.Windows.Forms.Button boton_nuevaCuenta;
        private System.Windows.Forms.TextBox c_horas;
        private System.Windows.Forms.TextBox c_dias;
        private System.Windows.Forms.TextBox c_usuarios;
        private System.Windows.Forms.Label simulation;
        private System.Windows.Forms.Button boton_simulacion;
    }
}