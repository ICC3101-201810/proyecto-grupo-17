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
    public partial class ISesion : Form
    {
        public ISesion()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Inicio inicio = new Inicio();
            inicio.Show();

        }

        private void btnIS_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu_admin = new Menu();
            menu_admin.Show();
        }
    }
}
