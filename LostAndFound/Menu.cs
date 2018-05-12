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
using System.Globalization;

namespace LostAndFound
{
    public partial class Menu : Form
    {
        public string ruti; 
        public Biblioteca biblioteca;
        public Menu()
        {

            InitializeComponent();
            BinaryFormatter bif = new BinaryFormatter();
            FileStream fis = File.Open("Datos.bin", FileMode.Open);
            biblioteca = (Biblioteca)bif.Deserialize(fis);
            fis.Close();
            IniciarMenu();
            MessageBox.Show(("rut bib"+this.biblioteca.rut_admin + "rut ingr "+ruti).ToString());

        }

        private void IniciarMenu()
        {
            if (this.biblioteca.admin.Contains(this.biblioteca.rut_admin)) 
            {
                PanelMenu.Visible = true;
                VerObj.Visible = true;
                btnInbox.Visible = true;
                btnSalir.Visible = true;
                buttonverUsuarios.Visible = true;
            }
            else      
            {
                PanelMenu.Visible = true;
                VerObj.Visible = true;
                btnInbox.Visible = true;
                btnSalir.Visible = true;
                buttonverUsuarios.Visible = false;
                boronVerObjetoEnc.Visible = false;
            }
        }
        private void MostrarInbox()
        {
            panelInbox.Visible = true;
            PanelMenu.Visible = false;
            panelAgregarObjeto.Visible = false;
            panelCuentaNueva.Visible = false;
        }

        private void ButtonverUsuarios_Click_1(object sender, EventArgs e)
        {
            
            btnAgrUsu.Visible = true;            
            btnEliminarUsu.Visible = true;
            VerUsu.Visible = true;
            VerObj.Visible = false;
            btnEliminarObj.Visible = false;
            btnObjetoEncontrado.Visible = false;
            
            VerUsu.Items.Clear();
            foreach (Usuario item in biblioteca.usuarios_no_iguales)
            {
                VerUsu.Items.Add(item.nombre_usuario + "\t" + item.calificacion);
            }
        }
        int codigooo = 10000000;

        private void BtnAgrUsu_Click(object sender, EventArgs e)
        {
            VerUsu.Visible = false;
            btnAgrUsu.Visible = false;
            btnEliminarUsu.Visible = false;
            panelCuentaNueva.Visible = true;
            // panelCuentaNueva.Location.CenterToScreen;
            panelInbox.Visible = false;
            lblMenu.Visible = false;




        }

        private void BtnEliminarUsu_Click(object sender, EventArgs e)
        {
            VerUsu.Items.Remove(VerUsu.SelectedItems);

            this.biblioteca.usuarios_no_iguales.RemoveAt(VerUsu.SelectedIndex);
            btnEliminarUsu.Visible = false;
            btnAgrUsu.Visible = false;
            VerUsu.Visible = false;
            MessageBox.Show("Usuario Eliminado con Exito");

        }

        private void CreandoCuenta_Click(object sender, EventArgs e)
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

        private void BtnObjPerdidos_Click(object sender, EventArgs e)
        {
            btnObjetoEncontrado.Visible = true;
            VerObj.Items.Clear();
            VerObj.Visible = true;
            VerUsu.Visible = false;
            btnEliminarUsu.Visible = false;
            btnAgrUsu.Visible = false;
            if (this.biblioteca.rut_admin == "1")
            {
                btnEliminarObj.Visible = true;

            }
            else { btnEliminarObj.Visible = false; }

            foreach (Objeto obj in biblioteca.objeto_perdido)
            {
                VerObj.Items.Add(obj.descripcion);
            }
        }

        private void BoronVerObjetoEnc_Click(object sender, EventArgs e)
        {
            panelAgregarObjeto.Visible = true;
            btnAgrUsu.Visible = false;
            btnEliminarUsu.Visible = false;
            VerUsu.Items.Clear();
            VerObj.Items.Clear();
            VerUsu.Visible = true;
            panelAgregarObjeto.Hide();
            panelCuentaNueva.Hide();
            btnEliminarObj.Visible = true;
            VerObj.Visible = false;
            lblMenu.Visible = false;

            foreach (Objeto obj in biblioteca.objeto_encontrado)
            {
                VerUsu.Items.Add(obj.descripcion);
            }
        }

        private void Botonagregarobjeto_Click(object sender, EventArgs e)
        {
            VerObj.Visible = false;
            MessageBox.Show("Porfavor publicar con seriedad y respeto!");
            panelAgregarObjeto.Visible = true;
            //panelCuentaNueva.Visible = false;
            //panelInbox.Visible = false;
            //PanelMenu.Visible = false;
            botonSalir.Visible = true;
            foreach (Ubicacion ubicacion in biblioteca.ubicaciones)
            {
                comboubicaciones.Items.Add(ubicacion.nombre_lugar);
            }
            foreach (string tipo in biblioteca.tipoderopa)
            {
                comboTipo.Items.Add(tipo);
            }
            if (comboTipo.SelectedItem!=null && comboubicaciones.SelectedItem!=null)
            {
                AceptarObjeto.Visible = true;
            }
            

        }

        private void BtnEliminarObj_Click_1(object sender, EventArgs e)
        {
            VerUsu.Items.Remove(VerUsu.SelectedItems);
             
            biblioteca.objeto_perdido.RemoveAt(VerUsu.SelectedIndex);
            btnEliminarObj.Visible = false;
            btnObjetoEncontrado.Visible = false;
            VerObj.Visible = false;
            VerUsu.Visible = false;
            MessageBox.Show("Objeto Eliminado con Exito");
        }


        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.Open("Datos.bin", FileMode.OpenOrCreate);
            bf.Serialize(fs, biblioteca);
            fs.Close();
            this.Close();
            Application.Exit();
        }

        private void BotonAgregarObjEncontrado_Click(object sender, EventArgs e)
        {
            //MostrarInbox();

            foreach (Usuario ussu in biblioteca.usuarios_no_iguales)
            {
                
                if (ussu.nombre_usuario == biblioteca.objeto_perdido[VerObj.SelectedIndex].usuarioperdio.nombre_usuario)
                {

                    //panelInbox.Visible = true;
                    //btnEliminarObj.Visible = false;
                    //btnObjetoEncontrado.Visible = false;
                    //VerObj.Visible = false;
                    //ibox_nombre_perdido.Text = ussu.nombre_usuario;
                    MessageBox.Show("Contactarse con: "+ussu.nombre_usuario +"\n"+ "Mail: "+ ussu.mail );
                    btnObjetoEncontrado.Visible = false;
                    btnEliminarObj.Visible = false;
                    

                }
                
            }
            
            biblioteca.objeto_encontrado.Add(biblioteca.objeto_perdido[VerObj.SelectedIndex]);
            biblioteca.objeto_perdido.RemoveAt(VerObj.SelectedIndex);
            VerObj.Items.Remove(VerObj.SelectedItems);
            VerObj.Items.Clear();
        }



        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void IboxEnter_Click(object sender, EventArgs e)
        {
            string mn;
            mn = textoInbox.Text + "\n ";
            textoInbox.Text = " ";
            feedInbox.Text += " YO: \n";
            DateTime localDate = DateTime.Now;
            var culture = new CultureInfo("en-US");
            feedInbox.Text += mn + "\n";
            feedInbox.Text += localDate.ToString(culture) + "\n";
            lblMenu.Visible = false;

        }

        private void SalirInbox_Click(object sender, EventArgs e)
        {
            panelInbox.Visible = false;
            lblMenu.Visible = true;
            btnEliminarObj.Visible = false;
            btnAgrUsu.Visible = false;
            VerObj.Visible = false;
            VerUsu.Visible = false;
        }

        private void BtnInbox_Click(object sender, EventArgs e)
        {
            panelAgregarObjeto.Visible = false;
            panelInbox.Visible = true;
            panelCuentaNueva.Visible = false;
            lblMenu.Visible = false;
        }

        private void VerObj_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LblMenu_Click(object sender, EventArgs e)
        {

        }

        private void Input2_Click(object sender, EventArgs e)
        {
            string descrip = textoNOmbreObjeto.Text;
            textoNOmbreObjeto.Text = " ";
            AceptarObjeto.Visible = false;
            panelAgregarObjeto.Visible = false;
            descripcion.Visible = false;
            name_ubi.Visible = false;
            nombre_ubicacion.Visible = false;
            descripcionn.Visible = false;
            btnAgregarUbicacion.Visible = false;
            txtTipo.Visible = false;
            tipo.Visible = false;
            btnAceptarTipo.Visible = false;
            codigooo += 1;

            foreach (Usuario u in biblioteca.usuarios_no_iguales)
            {
                if (u.rut.ToString() == biblioteca.rut_admin)
                {
                    
                    foreach (Ubicacion ubicacionn in biblioteca.ubicaciones)
                    {
                        if (ubicacionn.nombre_lugar == comboubicaciones.SelectedText)
                        {
                            
                            Objeto objetito = new Objeto(codigooo, descrip, false, ubicacionn, null, u, comboTipo.SelectedText);
                            MessageBox.Show("Objeto publicado con exito ");
                            biblioteca.objeto_perdido.Add(objetito);
                            break;
                           


                        }
                    }
                }
                
            }
            
        }
        
        

        private void Button2_Click(object sender, EventArgs e)
        {
            Ubicacion nuevp = new Ubicacion(name_ubi.Text, descripcion.Text);
            biblioteca.ubicaciones.Add(nuevp);
            name_ubi.Text = "";
            descripcion.Text = "";
            comboubicaciones.Items.Add(nuevp.nombre_lugar);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            descripcion.Visible = true;
            name_ubi.Visible = true;
            nombre_ubicacion.Visible = true;
            descripcionn.Visible = true;
            btnAgregarUbicacion.Visible = true;

        }

        private void BtnAgregartipo_Click(object sender, EventArgs e)
        {
            txtTipo.Visible = true;
            tipo.Visible = true;
            btnAceptarTipo.Visible = true;

        }

        private void BtnAceptarTipo_Click(object sender, EventArgs e)
        {
            biblioteca.tipoderopa.Add(txtTipo.Text);
            comboTipo.Items.Add(txtTipo.Text);
            
            txtTipo.Text = "";

        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textoNOmbreObjeto.Text != null || textoNOmbreObjeto.Text != " ")
            {
                if (comboubicaciones.SelectedItem != null && comboTipo.SelectedItem != null)
                {
                    AceptarObjeto.Visible = true;
                }

            }
        }

        private void comboubicaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textoNOmbreObjeto.Text != null || textoNOmbreObjeto.Text != " ")
            {
                if (comboubicaciones.SelectedItem != null && comboTipo.SelectedItem != null)
                {
                    AceptarObjeto.Visible = true;
                }

            }
        }

        private void btnNombreObj_Click(object sender, EventArgs e)
        {

        }

        private void textoNOmbreObjeto_TextChanged(object sender, EventArgs e)
        {
            if (textoNOmbreObjeto.Text !=null || textoNOmbreObjeto.Text!= " ")
            {
                if (comboubicaciones.SelectedItem != null && comboTipo.SelectedItem != null)
                {
                    AceptarObjeto.Visible = true;
                }
                
            }
            
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            panelCuentaNueva.Hide();
            PanelMenu.Show();
            btnObjPerdidos.Visible = true;
            botonagregarobjeto.Visible = true;
            btnInbox.Visible = true;
            VerUsu.Visible = false;
            VerObj.Visible = false;
            btnEliminarObj.Visible = false;

        }

        private void botonSALIR_Click(object sender, EventArgs e)
        {
            panelAgregarObjeto.Hide();
            VerUsu.Visible = false;
            VerObj.Visible = false;
            btnEliminarObj.Visible = false;
            PanelMenu.Show();
        }

        private void panelCuentaNueva_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

        
