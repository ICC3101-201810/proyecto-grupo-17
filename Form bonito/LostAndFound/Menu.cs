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
        public bool admin1;
        public Biblioteca biblioteca;
        public Menu()
        {
            InitializeComponent();
            deserializar();
            panelAgregarObjeto.Location = new Point(0, 0);
            panelCuentaNueva.Location = new Point(0, 0);
            panelInbox.Location = new Point(0, 0);
            PanelMenu.Location = new Point(0, 0);
            panel_login.Location = new Point(0, 0);
            panel_login.Visible = true;
            PanelMenu.Visible = false;

        }
        public void serializar()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.Open("Datos.bin", FileMode.OpenOrCreate);
            bf.Serialize(fs, biblioteca);
            fs.Close();
        }

        public void deserializar()
        {
            BinaryFormatter bif = new BinaryFormatter();
            FileStream fis = File.Open("Datos.bin", FileMode.Open);
            biblioteca = (Biblioteca)bif.Deserialize(fis);
            fis.Close();
        }

        private void IniciarMenu()
        {
            lblerror.Visible = false;
            if (admin1) 
            {
                PanelMenu.Visible = true;
                VerObj.Visible = true;
                btnInbox.Visible = true;
                btnSalir.Visible = true;
                buttonverUsuarios.Visible = true;
                cmb_tipo.Visible = false;
                lable_tipo.Visible = false;
            }
            else
            {
                PanelMenu.Visible = true;
                VerObj.Visible = true;
                btnInbox.Visible = true;
                btnSalir.Visible = true;
                buttonverUsuarios.Visible = false;
                boronVerObjetoEnc.Visible = false;
                btnEliminarObj.Visible = false;
                btnAgrUsu.Visible = false;
                btnEliminarUsu.Visible = false;
                cmb_tipo.Visible = false;
                lable_tipo.Visible = false;
            }
            panelAgregarObjeto.Location = new Point(0, 0);
            panelCuentaNueva.Location = new Point(0, 0);
            panelInbox.Location = new Point(0, 0);
            PanelMenu.Location = new Point(0, 0);
        }
        private void MostrarInbox()
        {
            panelInbox.Visible = true;
            PanelMenu.Visible = false;
            panelAgregarObjeto.Visible = false;
            panelCuentaNueva.Visible = false;
            lblerror.Visible = false;

        }

        private void ButtonverUsuarios_Click_1(object sender, EventArgs e)
        {
            VerUsu.Refresh();
            lblerror.Visible = false;
            btnAgrUsu.Visible = true;            
            btnEliminarUsu.Visible = true;
            VerUsu.Visible = true;
            VerObj.Visible = false;
            btnEliminarObj.Visible = false;
            btnObjetoEncontrado.Visible = false;
            cmb_tipo.Visible = false;
            lable_tipo.Visible = false;
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
            PanelMenu.Visible = false;
            panelInbox.Visible = false;
            lblMenu.Visible = false;
            lblerror.Visible = false;
            cmb_tipo.Visible = false;
            lable_tipo.Visible = false;
            btnEliminarObj.Visible = false;

        }

        private void BtnEliminarUsu_Click(object sender, EventArgs e)
        {
            lblerror.Text = "";
            lblerror_o.Text = "";

            lblerror.Visible = false;
            try
            {
                cmb_tipo.Visible = false;
                lable_tipo.Visible = false;
                VerUsu.Items.Remove(VerUsu.SelectedItems);
                biblioteca.usuarios_no_iguales.RemoveAt(Convert.ToInt32(VerUsu.SelectedIndex));
                btnEliminarUsu.Visible = false;
                btnAgrUsu.Visible = false;
                VerUsu.Visible = false;
                MessageBox.Show("Usuario Eliminado con Exito");
                btnEliminarObj.Visible = false;

            }
            catch
            {
                lblerror.Visible = true;
                lblerror.Text = "Por favor seleccione un usuario";
            }
        }

        private void CreandoCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (reContraseñaNC.Text !="")
                {
                    if (reContraseñaNC.Text == contraseñaCuentaNueva.Text)
                    {
                        string minombre = nombreCuentaNueva.Text;
                        int mirut = Convert.ToInt32(rutNC.Text);
                        string mipass1 = contraseñaCuentaNueva.Text;
                        string mimail = mailNC.Text;
                        bool admin1 = false;
                        if (checkAdmin.CheckState == CheckState.Checked)
                        {
                            admin1 = true;
                            this.admin1 = true;
                            biblioteca.admin.Add(rutNC.Text);
                        }
                        if (biblioteca.admin.Contains(rutNC.Text))
                        {
                            admin1 = true;
                            panelCuentaNueva.Visible = false;
                            PanelMenu.Visible = true;
                        }

                        Usuario yo1 = new Usuario(mirut, mipass1, minombre, mimail, admin1, 0);
                        serializar();
                        Console.WriteLine("Usuario creado con exito");
                        biblioteca.usuarios_no_iguales.Add(yo1);
                        IniciarMenu();
                        if (admin1)
                        {
                            panelCuentaNueva.Visible = false;
                            PanelMenu.Visible = true;
                        }
                        else
                        {
                            panelCuentaNueva.Visible = false;
                            PanelMenu.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("las contraseñas no coinciden");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese una contraseña valida");
                }
                
            }
            catch
            {
                MessageBox.Show("Debe llenar bien todos los datos.");
            }
        }

        private void BtnObjPerdidos_Click(object sender, EventArgs e)
        {
            lblerror.Visible = false;
            btnObjetoEncontrado.Visible = true;
            VerObj.Items.Clear();
            VerObj.Visible = true;
            VerUsu.Visible = false;
            btnEliminarUsu.Visible = false;
            cmb_tipo.Visible = true;
            lable_tipo.Visible = true;
            btnAgrUsu.Visible = false;
            if (admin1)
            {
                btnEliminarObj.Visible = true;

            }
            else { btnEliminarObj.Visible = false; }

            foreach (Objeto obj in biblioteca.objeto_perdido)
            {
                VerObj.Items.Add(obj.descripcion);
            }
            foreach (Objeto objj in biblioteca.objeto_perdido)
            {
                if (cmb_tipo.Items.Count == 0)
                {
                    if (objj.tipo != null)
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
            lblerror.Visible = false;
            panelAgregarObjeto.Visible = true;
            btnAgrUsu.Visible = false;
            btnEliminarUsu.Visible = false;
            VerUsu.Items.Clear();
            VerObj.Items.Clear();
            VerUsu.Visible = true;
            panelAgregarObjeto.Hide();
            panelCuentaNueva.Hide();
            btnEliminarObj.Visible = true;
            btnObjetoEncontrado.Visible = false;
            VerObj.Visible = false;
            lblMenu.Visible = false;
            cmb_tipo.Visible = false;
            lable_tipo.Visible = false;
            VerObj.Refresh();

            foreach (Objeto obj in biblioteca.objeto_encontrado)
            {
                VerUsu.Items.Add(obj.descripcion);
            }
        }

        private void Botonagregarobjeto_Click(object sender, EventArgs e)
        {
            cmb_tipo.Visible = false;
            lable_tipo.Visible = false;
            lblerror.Visible = false;
            VerObj.Visible = false;
            btnEliminarObj.Visible = false;
            btnObjetoEncontrado.Visible = false;
            MessageBox.Show("Porfavor publicar con seriedad y respeto!");
            panelAgregarObjeto.Visible = true;
            panelCuentaNueva.Visible = false;
            panelInbox.Visible = false;
            PanelMenu.Visible = false;
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
            serializar();

        }

        private void BtnEliminarObj_Click_1(object sender, EventArgs e)
        {
            lblerror.Text = "";
            lblerror_o.Text = "";

            lblerror.Visible = false;
            try
            {
                lblerror.Visible = false;
                VerObj.Items.Remove(VerObj.SelectedItems);
                biblioteca.objeto_perdido.RemoveAt(Convert.ToInt32(VerObj.SelectedIndex));
                MessageBox.Show("Objeto Eliminado con Exito");
                btnEliminarObj.Visible = false;
                btnObjetoEncontrado.Visible = false;
                VerObj.Visible = false;
                VerUsu.Visible = false;
                cmb_tipo.Visible = false;
                lable_tipo.Visible = false;
                serializar();
            }
            catch
            {
                lblerror.Visible = true;
                lblerror.Text = "Seleccione una publicacion a eliminar.";
            }
        }


        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            serializar();
            this.Close();
            Application.Exit();
        }

        private void BotonAgregarObjEncontrado_Click(object sender, EventArgs e)
        {
            lblerror.Visible = true;
            try
            {
                bool validacion = false;
                string mailusuario = "";
                string nombb = "";
                lblerror.Text = "";
                lblerror_o.Text = "";

                foreach (Usuario ussu in biblioteca.usuarios_no_iguales)
                {

                    int calificacion;
                    nombb = biblioteca.objeto_perdido[VerObj.SelectedIndex].usuarioperdio.nombre_usuario;
                    if (ussu.nombre_usuario == nombb)
                    {
                        cmb_tipo.Visible = false;
                        lable_tipo.Visible = false;
                        mailusuario = ussu.mail;
                        VerObj.Visible = false;
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
                        MessageBox.Show("Contactarse con " + nombb + "\n MAIL: " + mailusuario);
                        if (checkBox_puntaje1.CheckState == CheckState.Checked)
                        {
                            calificacion = 1;
                            ussu.calificacion += calificacion;
                            validacion = true;
                        }
                        else if (checkBox_puntaje2.CheckState == CheckState.Checked)
                        {
                            calificacion = 2;
                            ussu.calificacion += calificacion;
                            validacion = true;

                        }
                        else if (checkBox_puntaje3.CheckState == CheckState.Checked)
                        {
                            calificacion = 3;
                            ussu.calificacion += calificacion;
                            validacion = true;
                        }
                        else if (checkBox_puntaje4.CheckState == CheckState.Checked)
                        {
                            calificacion = 4;
                            ussu.calificacion += calificacion;
                            validacion = true;
                        }
                        else if (checkBox_puntaje5.CheckState == CheckState.Checked)
                        {
                            calificacion = 5;
                            ussu.calificacion += calificacion;
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
                    VerUsu.Items.Clear();
                    serializar();
                }
            }
            catch
            {
                lblerror.Visible = true;
                lblerror.Text = "Seleccione una publicacion.";
            }
        }

        private void IboxEnter_Click(object sender, EventArgs e)
        {
            string mn;
            mn = textoInbox.Text + "\n ";
            textoInbox.Text = " \n";
            feedInbox.Text += "\n YO: \n";
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
            panelAgregarObjeto.Visible = false;
            panelCuentaNueva.Visible = false;
            panelInbox.Visible = false;
            PanelMenu.Visible = true;
            btnObjetoEncontrado.Visible = false;
        }

        private void BtnInbox_Click(object sender, EventArgs e)
        {
            panelAgregarObjeto.Visible = false;
            panelInbox.Visible = true;
            panelCuentaNueva.Visible = false;
            PanelMenu.Visible = false;
            lblerror.Visible = false;
            cmb_tipo.Visible = false;
            lable_tipo.Visible = false;
            btnEliminarObj.Visible = false;
            lblerror.Text = "";
            lblerror_o.Text = "";
        }

        private void Input2_Click(object sender, EventArgs e)
        {
            lblerror_o.Text = "";
            lblerror.Text = "";
            try
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
                cmb_tipo.Visible = false;
                lable_tipo.Visible = false;

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
                                serializar();
                                PanelMenu.Visible = true;
                                break;
                            }
                        }
                    }
                }
            }
            catch
            {
                lblerror_o.Visible = true;
                lblerror_o.Text = "Datos mal ingresados.";
            }
            lblerror_o.Visible = false;
        }
        
        private void Button2_Click(object sender, EventArgs e)
        {
            lblerror_o.Text = "";
            lblerror.Text = "";

            try
            {
                Ubicacion nuevp = new Ubicacion(name_ubi.Text, descripcion.Text);
                biblioteca.ubicaciones.Add(nuevp);
                name_ubi.Text = "";
                descripcion.Text = "";
                comboubicaciones.Items.Add(nuevp.nombre_lugar);
                serializar();
            }
            catch
            {
                lblerror_o.Visible = true;
                lblerror_o.Text = "Ingrese todos los datos de Ubicacion Nueva.";
            }
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
            lblerror.Text = "";
            lblerror_o.Text = "";

            try
            {
                biblioteca.tipoderopa.Add(txtTipo.Text);
                comboTipo.Items.Add(txtTipo.Text);
                txtTipo.Text = "";
            }
            catch
            {
                lblerror_o.Visible = true;
                lblerror_o.Text = "Ingrese todos los datos de Tipo Nuevo.";
            }
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
            lblerror.Text = "";
            lblerror_o.Text = "";

            if ((nombreCuentaNueva.Text == "") || (rutNC.Text == "") || contraseñaCuentaNueva.Text == "" || mailNC.Text == "")
            {
                panelCuentaNueva.Visible = false;
                panel_login.Visible = true;
            }
            else
            {
                panelCuentaNueva.Hide();
                PanelMenu.Visible = true;
            }
           
        }

        private void botonSALIR_Click(object sender, EventArgs e)
        {
            lblerror.Text = "";
            lblerror_o.Text = "";
            panelAgregarObjeto.Hide();
            VerUsu.Visible = false;
            VerObj.Visible = false;
            btnEliminarObj.Visible = false;
            PanelMenu.Show();
        }

        private void btn_calificar_Click(object sender, EventArgs e)
        {
            try
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
                btnEliminarObj.Visible = false;

            }
            catch
            {
                MessageBox.Show("Seleccione una opcion.");
            }
        }

        private void checkBox_puntaje2_CheckedChanged(object sender, EventArgs e)
        {
            btn_calificar.Visible = true;
            if(!(checkBox_puntaje2.Checked))
            {
                checkBox_puntaje1.Checked = false;
                checkBox_puntaje3.Checked = false;
                checkBox_puntaje4.Checked = false;
                checkBox_puntaje5.Checked = false;
            }
        }

        private void checkBox_puntaje3_CheckedChanged(object sender, EventArgs e)
        {
            btn_calificar.Visible = true;
            if (!(checkBox_puntaje3.Checked))
            {
                checkBox_puntaje1.Checked = false;
                checkBox_puntaje2.Checked = false;
                checkBox_puntaje4.Checked = false;
                checkBox_puntaje5.Checked = false;
            }
        }

        private void checkBox_puntaje4_CheckedChanged(object sender, EventArgs e)
        {
            btn_calificar.Visible = true;
            if (!(checkBox_puntaje4.Checked))
            {
                checkBox_puntaje1.Checked = false;
                checkBox_puntaje2.Checked = false;
                checkBox_puntaje3.Checked = false;
                checkBox_puntaje5.Checked = false;
            }
        }

        private void checkBox_puntaje5_CheckedChanged(object sender, EventArgs e)
        {
            btn_calificar.Visible = true;
            if (!(checkBox_puntaje5.Checked))
            {
                checkBox_puntaje1.Checked = false;
                checkBox_puntaje2.Checked = false;
                checkBox_puntaje3.Checked = false;
                checkBox_puntaje4.Checked = false;
            }
        }

        private void checkBox_puntaje1_CheckedChanged(object sender, EventArgs e)
        {
            btn_calificar.Visible = true;
            if (!(checkBox_puntaje1.Checked))
            {
                checkBox_puntaje2.Checked = false;
                checkBox_puntaje3.Checked = false;
                checkBox_puntaje4.Checked = false;
                checkBox_puntaje5.Checked = false;
            }
        }

        private void mensaje_enter(object sender, EventArgs e)
        {
            string mn;
            mn = textoInbox.Text + "\n ";
            textoInbox.Text = " ";
            feedInbox.Text += "\n YO: \n";
            DateTime localDate = DateTime.Now;
            var culture = new CultureInfo("en-US");
            feedInbox.Text += mn + "\n";
            feedInbox.Text += localDate.ToString(culture) + "\n";
            lblMenu.Visible = false;
        }

        private void boton_login_Click(object sender, EventArgs e)
        {
            try
            {
                if(ruttext.Text != "")
                {
                    PanelMenu.Visible = true;
                    panel_login.Visible = false;
                    panelAgregarObjeto.Visible = false;
                    panelInbox.Visible = false;
                    panelCuentaNueva.Visible = false;
                    deserializar();
                    int ruttest = Int32.Parse(ruttext.Text);

                    foreach (Usuario u in this.biblioteca.usuarios_no_iguales)
                    {
                        //MessageBox.Show(u.rut+ " es "+ ruttest +" y la clave" + u.password + " es "+ miclave.Text);
                        if (ruttest == u.rut && miclave.Text == u.password)
                        {
                            this.biblioteca.rut_admin = u.rut.ToString();
                            if (biblioteca.admin.Contains(u.rut.ToString()))
                            {
                                this.biblioteca.admin.Add(u.rut.ToString());
                                this.biblioteca.rut_admin = u.rut.ToString();
                                admin1 = true;
                                this.biblioteca.admin.Add(this.biblioteca.rut_admin);
                                IniciarMenu();

                            }
                            else
                            {
                                admin1 = false;
                                IniciarMenu();
                            }
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Ingrese un RUT valido.");
                }
                
            }
            catch
            {
                MessageBox.Show("Ingrese un RUT valido.");
            }
            
        }

        private void boton_nuevaCuenta_Click(object sender, EventArgs e)
        {
            lblerror.Text = "";
            lblerror_o.Text = "";

            panel_login.Visible = false;
            panelCuentaNueva.Visible = true;
            serializar();
        }
        string tipo_selected;
        private void cmb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerObj.Items.Clear();
            tipo_selected = cmb_tipo.SelectedItem.ToString();

            foreach (Objeto obj in biblioteca.objeto_perdido)
            {
                if (obj.tipo == tipo_selected)
                {
                    VerObj.Items.Add(obj.descripcion);
                }
            }
        }
    }
}

        
