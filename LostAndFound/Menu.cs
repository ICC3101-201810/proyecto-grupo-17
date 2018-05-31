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
            //MessageBox.Show(biblioteca.usuarios_no_iguales.Count().ToString() + "selectedindex " + VerUsu.SelectedIndex.ToString() );
            biblioteca.usuarios_no_iguales.RemoveAt(Convert.ToInt32(VerUsu.SelectedIndex));
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
            cmb_tipo.Visible = true;
            lable_tipo.Visible = true;
            if (this.biblioteca.rut_admin == "1")
            {
                btnEliminarObj.Visible = true;

            }
            else { btnEliminarObj.Visible = false; }

            foreach (Objeto obj in biblioteca.objeto_perdido)
            {
                VerObj.Items.Add(obj.descripcion);
            }
            foreach(Objeto objj in biblioteca.objeto_perdido)
            {
                if (cmb_tipo.Items.Count==0)
                {
                    if (objj.tipo != null )
                    {
                        cmb_tipo.Items.Add(objj.tipo);
                    

                    }
                }
                if (objj.tipo != null)
                {
                    if (cmb_tipo.Items.Contains(objj.tipo))
                    {
                        continue;
                    }
                    else
                    {
                        cmb_tipo.Items.Add(objj.tipo);

                    }
                }
               
               
                
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
             
            biblioteca.objeto_perdido.RemoveAt(VerUsu.SelectedIndex-1);
            
            MessageBox.Show("Objeto Eliminado con Exito");
            btnEliminarObj.Visible = false;
            btnObjetoEncontrado.Visible = false;
            VerObj.Visible = false;
            VerUsu.Visible = false;
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
            bool validacion = false;
            //MostrarInbox();

            foreach (Usuario ussu in biblioteca.usuarios_no_iguales)
            {
                
                int calificacion;
                string nombb;
                nombb = biblioteca.objeto_perdido[VerObj.SelectedIndex].usuarioperdio.nombre_usuario;
                if (ussu.nombre_usuario == nombb)
                {


                    btn_calificar.Visible = true;
                    btnObjetoEncontrado.Visible = false;
                    btnEliminarObj.Visible = false;
                    lbl_calif.Visible = true;
                    lbl_calificar_usuario.Text = ussu.nombre_usuario;
                    lbl_calificar_usuario.Visible = true;
                    checkBox_puntaje1.Visible = true;
                    checkBox_puntaje2.Visible = true;
                    checkBox_puntaje3.Visible = true;
                    checkBox_puntaje4.Visible = true;
                    checkBox_puntaje5.Visible = true;
                    if (checkBox_puntaje1.Checked)
                    {
                        
                        calificacion = 1;
                        ussu.calificacion += calificacion;
                        validacion = true;
                        VerObj.Visible = false;

                    }
                    if (checkBox_puntaje2.Checked)
                    {
                        
                        calificacion = 2;
                        ussu.calificacion += calificacion;
                        validacion = true;
                        VerObj.Visible = false;

                    }
                    else if (checkBox_puntaje3.Checked)
                    {
                        
                        calificacion =  3;
                        ussu.calificacion += calificacion;
                        VerObj.Visible = false;
                        validacion = true;
                    }
                    else if (checkBox_puntaje4.Checked)
                    {
                        
                        calificacion = 4;
                        ussu.calificacion += calificacion;
                        VerObj.Visible = false;
                        validacion = true;
                    }
                    else if (checkBox_puntaje5.Checked)
                    {
                        
                        calificacion = 5;
                        ussu.calificacion += calificacion;
                        VerObj.Visible = false;
                        validacion = true;
                    }
                   


                }
                
            }

            if (validacion)
            {
                biblioteca.objeto_encontrado.Add(biblioteca.objeto_perdido[VerObj.SelectedIndex]);
                biblioteca.objeto_perdido.RemoveAt(VerObj.SelectedIndex);
                VerObj.Items.Remove(VerObj.SelectedItems);
                VerObj.Items.Clear();

            }
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

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_calificar_Click(object sender, EventArgs e)
        {
            VerObj.Visible = false;
            lbl_calif.Visible = false;
            lbl_calificar_usuario.Visible = false;
            checkBox_puntaje1.Visible = false;
            checkBox_puntaje2.Visible = false;
            checkBox_puntaje3.Visible = false;
            checkBox_puntaje4.Visible = false;
            checkBox_puntaje5.Visible = false;
            btn_calificar.Visible = false;
        }

        private void checkBox_puntaje2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_puntaje1.Checked = true;
            checkBox_puntaje3.Checked = false;
            checkBox_puntaje4.Checked = false;
            checkBox_puntaje5.Checked = false;
            if(!checkBox_puntaje2.Checked)
            {
                checkBox_puntaje1.Checked = false;
                checkBox_puntaje3.Checked = false;
                checkBox_puntaje4.Checked = false;
                checkBox_puntaje5.Checked = false;
            }
        }

        private void checkBox_puntaje3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_puntaje1.Checked = true;
            checkBox_puntaje2.Checked = true;
            checkBox_puntaje4.Checked = false;
            checkBox_puntaje5.Checked = false;
            if (!checkBox_puntaje3.Checked)
            {
                checkBox_puntaje1.Checked = false;
                checkBox_puntaje2.Checked = false;
                checkBox_puntaje4.Checked = false;
                checkBox_puntaje5.Checked = false;
            }
        }

        private void checkBox_puntaje4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_puntaje1.Checked = true;
            checkBox_puntaje2.Checked = true;
            checkBox_puntaje3.Checked = true;
            checkBox_puntaje5.Checked = false;
            if (!checkBox_puntaje4.Checked)
            {
                checkBox_puntaje1.Checked = false;
                checkBox_puntaje2.Checked = false;
                checkBox_puntaje3.Checked = false;
                checkBox_puntaje5.Checked = false;
            }
        }

        private void checkBox_puntaje5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_puntaje1.Checked = true;
            checkBox_puntaje2.Checked = true;
            checkBox_puntaje3.Checked = true;
            checkBox_puntaje4.Checked = true;
            if (!checkBox_puntaje5.Checked)
            {
                checkBox_puntaje1.Checked = false;
                checkBox_puntaje2.Checked = false;
                checkBox_puntaje3.Checked = false;
                checkBox_puntaje4.Checked = false;
            }
        }

        private void checkBox_puntaje1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_puntaje2.Checked = false;
            checkBox_puntaje3.Checked = false;
            checkBox_puntaje4.Checked = false;
            checkBox_puntaje5.Checked = false;
            if (!checkBox_puntaje1.Checked)
            {
                checkBox_puntaje2.Checked = false;
                checkBox_puntaje3.Checked = false;
                checkBox_puntaje4.Checked = false;
                checkBox_puntaje5.Checked = false;
            }
        }

        private void lable_tipo_Click(object sender, EventArgs e)
        {

        }

        string tipo_selected;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerObj.Items.Clear();
            tipo_selected = cmb_tipo.SelectedText;
            foreach (Objeto obj in biblioteca.objeto_perdido)
            {
                if (obj.tipo==tipo_selected)
                {
                    VerObj.Items.Add(obj.descripcion);
                }
            }
        }
    }
}

        
