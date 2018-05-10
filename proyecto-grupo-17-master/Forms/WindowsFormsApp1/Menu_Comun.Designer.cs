namespace WindowsFormsApp1
{
    partial class Menu_Comun
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
            this.lblMC = new System.Windows.Forms.Label();
            this.btnAPO = new System.Windows.Forms.Button();
            this.btnVOP = new System.Windows.Forms.Button();
            this.btnInbox = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMC
            // 
            this.lblMC.AutoSize = true;
            this.lblMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMC.Location = new System.Drawing.Point(500, 95);
            this.lblMC.Name = "lblMC";
            this.lblMC.Size = new System.Drawing.Size(183, 59);
            this.lblMC.TabIndex = 1;
            this.lblMC.Text = "MENU";
            // 
            // btnAPO
            // 
            this.btnAPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAPO.Location = new System.Drawing.Point(509, 260);
            this.btnAPO.Name = "btnAPO";
            this.btnAPO.Size = new System.Drawing.Size(174, 74);
            this.btnAPO.TabIndex = 2;
            this.btnAPO.Text = "Agregar Perdida Objeto";
            this.btnAPO.UseVisualStyleBackColor = true;
            this.btnAPO.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVOP
            // 
            this.btnVOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVOP.Location = new System.Drawing.Point(510, 398);
            this.btnVOP.Name = "btnVOP";
            this.btnVOP.Size = new System.Drawing.Size(174, 74);
            this.btnVOP.TabIndex = 2;
            this.btnVOP.Text = "Ver Objetos Perdidos";
            this.btnVOP.UseVisualStyleBackColor = true;
            // 
            // btnInbox
            // 
            this.btnInbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInbox.Location = new System.Drawing.Point(509, 526);
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Size = new System.Drawing.Size(174, 74);
            this.btnInbox.TabIndex = 2;
            this.btnInbox.Text = "Inbox";
            this.btnInbox.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1135, 679);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(174, 74);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Menu_Comun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1341, 783);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnInbox);
            this.Controls.Add(this.btnVOP);
            this.Controls.Add(this.btnAPO);
            this.Controls.Add(this.lblMC);
            this.Name = "Menu_Comun";
            this.Text = "Menu_Comun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMC;
        private System.Windows.Forms.Button btnAPO;
        private System.Windows.Forms.Button btnVOP;
        private System.Windows.Forms.Button btnInbox;
        private System.Windows.Forms.Button btnSalir;
    }
}