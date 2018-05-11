﻿namespace LostAndFound
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
            this.panelCuentaNueva = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.rutNC = new System.Windows.Forms.TextBox();
            this.nombreCuentaNueva = new System.Windows.Forms.TextBox();
            this.contraseñaCuentaNueva = new System.Windows.Forms.TextBox();
            this.reContraseñaNC = new System.Windows.Forms.TextBox();
            this.mailNC = new System.Windows.Forms.TextBox();
            this.creandoCuenta = new System.Windows.Forms.Button();
            this.checkAdmin = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelCuentaNueva.SuspendLayout();
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
            this.boton_login.Click += new System.EventHandler(this.Boton_login_Click);
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
            this.boton_nuevaCuenta.Click += new System.EventHandler(this.Boton_nuevaCuenta_Click);
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
            this.boton_simulacion.Click += new System.EventHandler(this.Boton_simulacion_Click);
            // 
            // panelCuentaNueva
            // 
            this.panelCuentaNueva.AutoSize = true;
            this.panelCuentaNueva.Controls.Add(this.label6);
            this.panelCuentaNueva.Controls.Add(this.rutNC);
            this.panelCuentaNueva.Controls.Add(this.nombreCuentaNueva);
            this.panelCuentaNueva.Controls.Add(this.contraseñaCuentaNueva);
            this.panelCuentaNueva.Controls.Add(this.reContraseñaNC);
            this.panelCuentaNueva.Controls.Add(this.mailNC);
            this.panelCuentaNueva.Controls.Add(this.creandoCuenta);
            this.panelCuentaNueva.Controls.Add(this.checkAdmin);
            this.panelCuentaNueva.Controls.Add(this.label5);
            this.panelCuentaNueva.Controls.Add(this.label4);
            this.panelCuentaNueva.Controls.Add(this.label3);
            this.panelCuentaNueva.Controls.Add(this.label2);
            this.panelCuentaNueva.Controls.Add(this.label7);
            this.panelCuentaNueva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCuentaNueva.Location = new System.Drawing.Point(0, 0);
            this.panelCuentaNueva.Name = "panelCuentaNueva";
            this.panelCuentaNueva.Size = new System.Drawing.Size(800, 450);
            this.panelCuentaNueva.TabIndex = 12;
            this.panelCuentaNueva.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "RUT(sin puntos ni guion):";
            // 
            // rutNC
            // 
            this.rutNC.Location = new System.Drawing.Point(386, 100);
            this.rutNC.Name = "rutNC";
            this.rutNC.Size = new System.Drawing.Size(100, 20);
            this.rutNC.TabIndex = 24;
            // 
            // nombreCuentaNueva
            // 
            this.nombreCuentaNueva.Location = new System.Drawing.Point(386, 65);
            this.nombreCuentaNueva.Name = "nombreCuentaNueva";
            this.nombreCuentaNueva.Size = new System.Drawing.Size(100, 20);
            this.nombreCuentaNueva.TabIndex = 23;
            // 
            // contraseñaCuentaNueva
            // 
            this.contraseñaCuentaNueva.Location = new System.Drawing.Point(386, 132);
            this.contraseñaCuentaNueva.Name = "contraseñaCuentaNueva";
            this.contraseñaCuentaNueva.Size = new System.Drawing.Size(100, 20);
            this.contraseñaCuentaNueva.TabIndex = 22;
            // 
            // reContraseñaNC
            // 
            this.reContraseñaNC.Location = new System.Drawing.Point(386, 165);
            this.reContraseñaNC.Name = "reContraseñaNC";
            this.reContraseñaNC.Size = new System.Drawing.Size(100, 20);
            this.reContraseñaNC.TabIndex = 21;
            // 
            // mailNC
            // 
            this.mailNC.Location = new System.Drawing.Point(386, 195);
            this.mailNC.Name = "mailNC";
            this.mailNC.Size = new System.Drawing.Size(100, 20);
            this.mailNC.TabIndex = 20;
            // 
            // creandoCuenta
            // 
            this.creandoCuenta.Location = new System.Drawing.Point(386, 261);
            this.creandoCuenta.Name = "creandoCuenta";
            this.creandoCuenta.Size = new System.Drawing.Size(125, 23);
            this.creandoCuenta.TabIndex = 19;
            this.creandoCuenta.Text = "Crear Cuenta";
            this.creandoCuenta.UseVisualStyleBackColor = true;
            this.creandoCuenta.Click += new System.EventHandler(this.CreandoCuenta_Click);
            // 
            // checkAdmin
            // 
            this.checkAdmin.AutoSize = true;
            this.checkAdmin.Location = new System.Drawing.Point(386, 216);
            this.checkAdmin.Name = "checkAdmin";
            this.checkAdmin.Size = new System.Drawing.Size(36, 17);
            this.checkAdmin.TabIndex = 18;
            this.checkAdmin.Text = "SI";
            this.checkAdmin.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "adiministrador: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "repita contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "contraseña:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nombre completo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCuentaNueva);
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
            this.panelCuentaNueva.ResumeLayout(false);
            this.panelCuentaNueva.PerformLayout();
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
        private System.Windows.Forms.Panel panelCuentaNueva;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rutNC;
        private System.Windows.Forms.TextBox nombreCuentaNueva;
        private System.Windows.Forms.TextBox contraseñaCuentaNueva;
        private System.Windows.Forms.TextBox reContraseñaNC;
        private System.Windows.Forms.TextBox mailNC;
        private System.Windows.Forms.Button creandoCuenta;
        private System.Windows.Forms.CheckBox checkAdmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
    }
}