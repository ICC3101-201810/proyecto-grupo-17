using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LostAndFound
{
    public partial class Menu : Form
    {
        public Biblioteca biblioteca;
        public Menu()
        {
            
            InitializeComponent();
            BinaryFormatter bif = new BinaryFormatter();
            FileStream fis = File.Open("Datos.bin", FileMode.Open);
            biblioteca = (Biblioteca)bif.Deserialize(fis);
            fis.Close();

        }
     

        private void buttonverUsuarios_Click_1(object sender, EventArgs e)
        {

            btnAgrUsu.Visible = true;
            btnEliminarUsu.Visible = true;
            VerUsu.Visible = true;

            VerUsu.Items.Clear();
            foreach (Usuario item in biblioteca.usuarios_no_iguales)
            {
                VerUsu.Items.Add(item.nombre_usuario);
            }
        }

        private void btnAgrUsu_Click(object sender, EventArgs e)
        {
            VerUsu.Visible = false;
            panelCuentaNueva.Visible = true;
           
            
            
        }

        private void btnEliminarUsu_Click(object sender, EventArgs e)
        {
            VerUsu.Items.Remove(VerUsu.SelectedItems);

            biblioteca.usuarios_no_iguales.RemoveAt(VerUsu.SelectedIndex);
            btnEliminarUsu.Visible = false;
            btnAgrUsu.Visible = false;
            VerUsu.Visible = false;
            MessageBox.Show("Usuario Eliminado con Exito");
        }

        private void creandoCuenta_Click(object sender, EventArgs e)
        {
            
            if (reContraseñaNC.Text == contraseñaCuentaNueva.Text)
            {
                MessageBox.Show("Las contraseñas coinciden");

                string minombre = nombreCuentaNueva.Text;
                int mirut = Convert.ToInt32(rutNC.Text);
                string mipass1 = contraseñaCuentaNueva.Text;
                string mimail = mailNC.Text;
                bool admin1 = false;
                if (checkAdmin.Checked)
                {
                    admin1 = true;
                }

                Usuario yo1 = new Usuario(mirut, mipass1, minombre, mimail, admin1, 0);
                Console.WriteLine("Usuario creado con exito");
                biblioteca.usuarios_no_iguales.Add(yo1);
                if (admin1)
                {
                    panelCuentaNueva.Visible = false;
                }
                else
                {
                    panelCuentaNueva.Visible = false;
                   

                }

            }
            else
            {
                MessageBox.Show("las contraseñas no coinciden");
            }
        }

        private void btnObjPerdidos_Click(object sender, EventArgs e)
        {
            VerObj.Items.Clear();
            
            foreach (Objeto obj in biblioteca.objeto_perdido)
            {
                VerObj.Items.Add(obj.descripcion);
            }
        }

        private void boronVerObjetoEnc_Click(object sender, EventArgs e)
        {
            VerObj.Items.Clear();
            btnEliminarObj.Visible = true;
            
            foreach (Objeto obj in biblioteca.objeto_encontrado)
            {
                VerObj.Items.Add(obj.descripcion);
            }
        }

        private void botonagregarobjeto_Click(object sender, EventArgs e)
        {
           
        
        }

        private void btnEliminarObj_Click_1(object sender, EventArgs e)
        {
            VerObj.Items.Remove(VerUsu.SelectedItems);

            biblioteca.objeto_perdido.RemoveAt(VerObj.SelectedIndex);
            btnEliminarObj.Visible = false;
            VerObj.Visible = false;
            MessageBox.Show("Objeto Eliminado con Exito");
        }


        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void botonAgregarObjEncontrado_Click(object sender, EventArgs e)
        {

        }

        private void btnVerCalificacion_Click_1(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
