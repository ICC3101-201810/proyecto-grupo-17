using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private void cbadmin_CheckedChanged(object sender, EventArgs e)
        {
            //bool admin = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Inicio inicio = new Inicio();
            inicio.Show();

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {

            this.Close();
            ISesion sesion = new ISesion();
            sesion.Show();
            
        }

        private void Registrarse_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
    
}
