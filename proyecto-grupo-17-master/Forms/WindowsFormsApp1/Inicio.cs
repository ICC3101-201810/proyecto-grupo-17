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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Registrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registrarse registrarse = new Registrarse();
            registrarse.Show();
        }
        private void ISesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            ISesion sesion = new ISesion();
            sesion.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Gracias por ocupar Lost & Found Uandes\n" +
                            "              Vuelve Pronto!");
        }

    }
}
