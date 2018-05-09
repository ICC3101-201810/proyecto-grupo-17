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
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.botonVerCali = new System.Windows.Forms.Button();
            this.botonagregarobjeto = new System.Windows.Forms.Button();
            this.boronVerObjetoEnc = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonverUsuarios = new System.Windows.Forms.Button();
            this.panelCuentaNueva.SuspendLayout();
            this.panelUsuario.SuspendLayout();
            this.panelAdmin.SuspendLayout();
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
            // panelCuentaNueva
            // 
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
            this.panelCuentaNueva.Location = new System.Drawing.Point(12, 12);
            this.panelCuentaNueva.Name = "panelCuentaNueva";
            this.panelCuentaNueva.Size = new System.Drawing.Size(776, 357);
            this.panelCuentaNueva.TabIndex = 12;
            this.panelCuentaNueva.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "RUT(sin puntos ni guion):";
            // 
            // rutNC
            // 
            this.rutNC.Location = new System.Drawing.Point(387, 58);
            this.rutNC.Name = "rutNC";
            this.rutNC.Size = new System.Drawing.Size(100, 20);
            this.rutNC.TabIndex = 24;
            // 
            // nombreCuentaNueva
            // 
            this.nombreCuentaNueva.Location = new System.Drawing.Point(387, 3);
            this.nombreCuentaNueva.Name = "nombreCuentaNueva";
            this.nombreCuentaNueva.Size = new System.Drawing.Size(100, 20);
            this.nombreCuentaNueva.TabIndex = 23;
            // 
            // contraseñaCuentaNueva
            // 
            this.contraseñaCuentaNueva.Location = new System.Drawing.Point(387, 100);
            this.contraseñaCuentaNueva.Name = "contraseñaCuentaNueva";
            this.contraseñaCuentaNueva.Size = new System.Drawing.Size(100, 20);
            this.contraseñaCuentaNueva.TabIndex = 22;
            // 
            // reContraseñaNC
            // 
            this.reContraseñaNC.Location = new System.Drawing.Point(387, 159);
            this.reContraseñaNC.Name = "reContraseñaNC";
            this.reContraseñaNC.Size = new System.Drawing.Size(100, 20);
            this.reContraseñaNC.TabIndex = 21;
            // 
            // mailNC
            // 
            this.mailNC.Location = new System.Drawing.Point(387, 220);
            this.mailNC.Name = "mailNC";
            this.mailNC.Size = new System.Drawing.Size(100, 20);
            this.mailNC.TabIndex = 20;
            // 
            // creandoCuenta
            // 
            this.creandoCuenta.Location = new System.Drawing.Point(387, 315);
            this.creandoCuenta.Name = "creandoCuenta";
            this.creandoCuenta.Size = new System.Drawing.Size(125, 23);
            this.creandoCuenta.TabIndex = 19;
            this.creandoCuenta.Text = "Crear Cuenta";
            this.creandoCuenta.UseVisualStyleBackColor = true;
            this.creandoCuenta.Click += new System.EventHandler(this.creandoCuenta_Click);
            // 
            // checkAdmin
            // 
            this.checkAdmin.AutoSize = true;
            this.checkAdmin.Location = new System.Drawing.Point(387, 272);
            this.checkAdmin.Name = "checkAdmin";
            this.checkAdmin.Size = new System.Drawing.Size(36, 17);
            this.checkAdmin.TabIndex = 18;
            this.checkAdmin.Text = "SI";
            this.checkAdmin.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "adiministrador: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 223);
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
            this.label2.Location = new System.Drawing.Point(229, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "contraseña:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nombre completo:";
            // 
            // panelUsuario
            // 
            this.panelUsuario.Controls.Add(this.button1);
            this.panelUsuario.Controls.Add(this.button3);
            this.panelUsuario.Controls.Add(this.panelAdmin);
            this.panelUsuario.Location = new System.Drawing.Point(12, 12);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(776, 383);
            this.panelUsuario.TabIndex = 26;
            this.panelUsuario.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 27);
            this.button1.TabIndex = 29;
            this.button1.Text = "Objetos Encontrados";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(318, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "Objetos Perdidos";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.botonVerCali);
            this.panelAdmin.Controls.Add(this.botonagregarobjeto);
            this.panelAdmin.Controls.Add(this.boronVerObjetoEnc);
            this.panelAdmin.Controls.Add(this.button2);
            this.panelAdmin.Controls.Add(this.buttonverUsuarios);
            this.panelAdmin.Location = new System.Drawing.Point(17, 3);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(773, 479);
            this.panelAdmin.TabIndex = 27;
            this.panelAdmin.Visible = false;
            // 
            // botonVerCali
            // 
            this.botonVerCali.Location = new System.Drawing.Point(317, 130);
            this.botonVerCali.Name = "botonVerCali";
            this.botonVerCali.Size = new System.Drawing.Size(133, 27);
            this.botonVerCali.TabIndex = 5;
            this.botonVerCali.Text = "Ver Califiaciones";
            this.botonVerCali.UseVisualStyleBackColor = true;
            // 
            // botonagregarobjeto
            // 
            this.botonagregarobjeto.Location = new System.Drawing.Point(195, 240);
            this.botonagregarobjeto.Name = "botonagregarobjeto";
            this.botonagregarobjeto.Size = new System.Drawing.Size(141, 28);
            this.botonagregarobjeto.TabIndex = 3;
            this.botonagregarobjeto.Text = "agregar perdida de objeto";
            this.botonagregarobjeto.UseVisualStyleBackColor = true;
            // 
            // boronVerObjetoEnc
            // 
            this.boronVerObjetoEnc.Location = new System.Drawing.Point(60, 133);
            this.boronVerObjetoEnc.Name = "boronVerObjetoEnc";
            this.boronVerObjetoEnc.Size = new System.Drawing.Size(141, 27);
            this.boronVerObjetoEnc.TabIndex = 2;
            this.boronVerObjetoEnc.Text = "Objetos Encontrados";
            this.boronVerObjetoEnc.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(60, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Objetos Perdidos";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonverUsuarios
            // 
            this.buttonverUsuarios.Location = new System.Drawing.Point(317, 53);
            this.buttonverUsuarios.Name = "buttonverUsuarios";
            this.buttonverUsuarios.Size = new System.Drawing.Size(133, 19);
            this.buttonverUsuarios.TabIndex = 0;
            this.buttonverUsuarios.Text = "Usuarios";
            this.buttonverUsuarios.UseVisualStyleBackColor = true;
            this.buttonverUsuarios.Click += new System.EventHandler(this.buttonverUsuarios_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelUsuario);
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
            this.panelUsuario.ResumeLayout(false);
            this.panelAdmin.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Button botonVerCali;
        private System.Windows.Forms.Button botonagregarobjeto;
        private System.Windows.Forms.Button boronVerObjetoEnc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonverUsuarios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}