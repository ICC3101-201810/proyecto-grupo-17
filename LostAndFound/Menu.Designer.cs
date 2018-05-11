﻿namespace LostAndFound
{
    partial class Menu
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
            this.botonagregarobjeto = new System.Windows.Forms.Button();
            this.boronVerObjetoEnc = new System.Windows.Forms.Button();
            this.btnObjPerdidos = new System.Windows.Forms.Button();
            this.buttonverUsuarios = new System.Windows.Forms.Button();
            this.VerUsu = new System.Windows.Forms.ListBox();
            this.btnAgrUsu = new System.Windows.Forms.Button();
            this.btnEliminarUsu = new System.Windows.Forms.Button();
            this.panelCuentaNueva = new System.Windows.Forms.Panel();
            this.VerObj = new System.Windows.Forms.ListBox();
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
            this.btnEliminarObj = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnObjetoEncontrado = new System.Windows.Forms.Button();
            this.btnInbox = new System.Windows.Forms.Button();
            this.panelCuentaNueva.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonagregarobjeto
            // 
            this.botonagregarobjeto.Location = new System.Drawing.Point(12, 75);
            this.botonagregarobjeto.Name = "botonagregarobjeto";
            this.botonagregarobjeto.Size = new System.Drawing.Size(141, 28);
            this.botonagregarobjeto.TabIndex = 9;
            this.botonagregarobjeto.Text = "agregar perdida de objeto";
            this.botonagregarobjeto.UseVisualStyleBackColor = true;
            this.botonagregarobjeto.Click += new System.EventHandler(this.botonagregarobjeto_Click);
            // 
            // boronVerObjetoEnc
            // 
            this.boronVerObjetoEnc.Location = new System.Drawing.Point(12, 154);
            this.boronVerObjetoEnc.Name = "boronVerObjetoEnc";
            this.boronVerObjetoEnc.Size = new System.Drawing.Size(141, 47);
            this.boronVerObjetoEnc.TabIndex = 8;
            this.boronVerObjetoEnc.Text = "Objetos Encontrados";
            this.boronVerObjetoEnc.UseVisualStyleBackColor = true;
            this.boronVerObjetoEnc.Visible = false;
            this.boronVerObjetoEnc.Click += new System.EventHandler(this.boronVerObjetoEnc_Click);
            // 
            // btnObjPerdidos
            // 
            this.btnObjPerdidos.Location = new System.Drawing.Point(12, 12);
            this.btnObjPerdidos.Name = "btnObjPerdidos";
            this.btnObjPerdidos.Size = new System.Drawing.Size(141, 23);
            this.btnObjPerdidos.TabIndex = 7;
            this.btnObjPerdidos.Text = "Objetos Perdidos";
            this.btnObjPerdidos.UseVisualStyleBackColor = true;
            this.btnObjPerdidos.Click += new System.EventHandler(this.btnObjPerdidos_Click);
            // 
            // buttonverUsuarios
            // 
            this.buttonverUsuarios.Location = new System.Drawing.Point(12, 222);
            this.buttonverUsuarios.Name = "buttonverUsuarios";
            this.buttonverUsuarios.Size = new System.Drawing.Size(141, 41);
            this.buttonverUsuarios.TabIndex = 6;
            this.buttonverUsuarios.Text = "Usuarios";
            this.buttonverUsuarios.UseVisualStyleBackColor = true;
            this.buttonverUsuarios.Click += new System.EventHandler(this.buttonverUsuarios_Click_1);
            // 
            // VerUsu
            // 
            this.VerUsu.FormattingEnabled = true;
            this.VerUsu.Location = new System.Drawing.Point(464, 68);
            this.VerUsu.Name = "VerUsu";
            this.VerUsu.Size = new System.Drawing.Size(281, 264);
            this.VerUsu.TabIndex = 11;
            this.VerUsu.Visible = false;
            // 
            // btnAgrUsu
            // 
            this.btnAgrUsu.Location = new System.Drawing.Point(207, 21);
            this.btnAgrUsu.Name = "btnAgrUsu";
            this.btnAgrUsu.Size = new System.Drawing.Size(107, 23);
            this.btnAgrUsu.TabIndex = 12;
            this.btnAgrUsu.Text = "Agregar Usuario";
            this.btnAgrUsu.UseVisualStyleBackColor = true;
            this.btnAgrUsu.Visible = false;
            this.btnAgrUsu.Click += new System.EventHandler(this.btnAgrUsu_Click);
            // 
            // btnEliminarUsu
            // 
            this.btnEliminarUsu.Location = new System.Drawing.Point(207, 78);
            this.btnEliminarUsu.Name = "btnEliminarUsu";
            this.btnEliminarUsu.Size = new System.Drawing.Size(107, 23);
            this.btnEliminarUsu.TabIndex = 13;
            this.btnEliminarUsu.Text = "Eliminar Usuario";
            this.btnEliminarUsu.UseVisualStyleBackColor = true;
            this.btnEliminarUsu.Visible = false;
            this.btnEliminarUsu.Click += new System.EventHandler(this.btnEliminarUsu_Click);
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
            this.panelCuentaNueva.Location = new System.Drawing.Point(420, 175);
            this.panelCuentaNueva.Name = "panelCuentaNueva";
            this.panelCuentaNueva.Size = new System.Drawing.Size(800, 450);
            this.panelCuentaNueva.TabIndex = 14;
            this.panelCuentaNueva.Visible = false;
            // 
            // VerObj
            // 
            this.VerObj.FormattingEnabled = true;
            this.VerObj.Location = new System.Drawing.Point(478, 21);
            this.VerObj.Name = "VerObj";
            this.VerObj.Size = new System.Drawing.Size(281, 290);
            this.VerObj.TabIndex = 15;
            this.VerObj.Visible = false;
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
            // btnEliminarObj
            // 
            this.btnEliminarObj.Location = new System.Drawing.Point(207, 118);
            this.btnEliminarObj.Name = "btnEliminarObj";
            this.btnEliminarObj.Size = new System.Drawing.Size(141, 41);
            this.btnEliminarObj.TabIndex = 6;
            this.btnEliminarObj.Text = "Eliminar Publicacion de Objeto";
            this.btnEliminarObj.UseVisualStyleBackColor = true;
            this.btnEliminarObj.Visible = false;
            this.btnEliminarObj.Click += new System.EventHandler(this.btnEliminarObj_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(478, 376);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(141, 41);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnObjetoEncontrado
            // 
            this.btnObjetoEncontrado.Location = new System.Drawing.Point(207, 203);
            this.btnObjetoEncontrado.Name = "btnObjetoEncontrado";
            this.btnObjetoEncontrado.Size = new System.Drawing.Size(141, 28);
            this.btnObjetoEncontrado.TabIndex = 9;
            this.btnObjetoEncontrado.Text = "Encontre Objeto";
            this.btnObjetoEncontrado.UseVisualStyleBackColor = true;
            this.btnObjetoEncontrado.Visible = false;
            this.btnObjetoEncontrado.Click += new System.EventHandler(this.botonAgregarObjEncontrado_Click);
            // 
            // btnInbox
            // 
            this.btnInbox.Location = new System.Drawing.Point(12, 291);
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Size = new System.Drawing.Size(141, 41);
            this.btnInbox.TabIndex = 16;
            this.btnInbox.Text = "Inbox";
            this.btnInbox.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInbox);
            this.Controls.Add(this.VerObj);
            this.Controls.Add(this.panelCuentaNueva);
            this.Controls.Add(this.btnEliminarUsu);
            this.Controls.Add(this.btnAgrUsu);
            this.Controls.Add(this.VerUsu);
            this.Controls.Add(this.btnObjetoEncontrado);
            this.Controls.Add(this.botonagregarobjeto);
            this.Controls.Add(this.boronVerObjetoEnc);
            this.Controls.Add(this.btnObjPerdidos);
            this.Controls.Add(this.btnEliminarObj);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.buttonverUsuarios);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panelCuentaNueva.ResumeLayout(false);
            this.panelCuentaNueva.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonagregarobjeto;
        private System.Windows.Forms.Button boronVerObjetoEnc;
        private System.Windows.Forms.Button btnObjPerdidos;
        private System.Windows.Forms.Button buttonverUsuarios;
        private System.Windows.Forms.ListBox VerUsu;
        private System.Windows.Forms.Button btnAgrUsu;
        private System.Windows.Forms.Button btnEliminarUsu;
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
        private System.Windows.Forms.ListBox VerObj;
        private System.Windows.Forms.Button btnEliminarObj;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnObjetoEncontrado;
        private System.Windows.Forms.Button btnInbox;
    }
}