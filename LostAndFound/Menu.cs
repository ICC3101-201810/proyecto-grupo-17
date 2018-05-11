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
            panelCuentaNueva.Visible = true;
           
            
            
        }

        private void btnEliminarUsu_Click(object sender, EventArgs e)
        {
            VerUsu.Items.Remove(VerUsu.SelectedItems);

            biblioteca.usuarios_no_iguales.RemoveAt(VerUsu.SelectedIndex);
            btnEliminarUsu.Visible = false;
            btnAgrUsu.Visible = false;
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

            foreach (Objeto obj in biblioteca.objeto_encontrado)
            {
                VerObj.Items.Add(obj.descripcion);
            }
        }

        private void botonagregarobjeto_Click(object sender, EventArgs e)
        {
            bool hugeloop = true;
            while (hugeloop)
            {
                Console.WriteLine("desea usar un tipo de ropa determinado o ingresar uno nuevo? \n" +
                "opcion 1 = usar determinado \n" +
                "opcion 2 = crear tipo de objeto nuevo \n" +
                "opcion 3 = volver al menu principal");
                string opcionn = Console.ReadLine();
                if (opcionn == "1")
                {
                    foreach (string i in tipoderopa)
                    {
                        Console.WriteLine(i);
                    }

                    Console.WriteLine("ingrese su tipo de ropa");
                    string tipoo = Console.ReadLine();
                    Console.WriteLine("ingrese talla, en caso de no necesitar presione ENTER");
                    string tallaaa = Console.ReadLine();
                    string nombrenuevoo = tipoo + " " + tallaaa;
                    bool keeploopingg = true;
                    while (keeploopingg)
                    {
                        Console.WriteLine("ingrese ubicacion existente o nueva");
                        foreach (Ubicacion item in ubicaciones)
                        {
                            Console.WriteLine(item.nombre_lugar);
                        }
                        Console.WriteLine("si desea ingresar ubicacion nueva presione 1, en caso de querer usar ubicacion predeterminada presione 2");
                        string opcionnn = Console.ReadLine();
                        if (opcionnn == "2")
                        {
                            Console.WriteLine("ingrese ubicacion existente");
                            string ubicacionaingresar = Console.ReadLine();
                            foreach (Ubicacion u in ubicaciones)
                            {
                                if (ubicacionaingresar == u.nombre_lugar)
                                {
                                    foreach (Usuario a in usuarios_no_iguales)
                                    {
                                        if (a.rut == mirut)
                                        {
                                            Objeto nuevop = new Objeto((objeto_perdido.Count() + 1), nombrenuevoo, false, u, a, null);
                                            objeto_perdido.Add(nuevop);
                                            Console.WriteLine("objeto ingresado con exito!");
                                            keeploopingg = false;
                                            hugeloop = false;
                                            break;

                                        }
                                    }

                                }
                            }
                        }
                        if (opcionnn == "1")
                        {
                            Console.WriteLine("ingrese nombre de ubicacion nueva");
                            string nombreubi = Console.ReadLine();
                            Console.WriteLine("ingresar descripcion breve de lugar");
                            string descrip = Console.ReadLine();
                            Ubicacion ubiii = new Ubicacion(nombreubi, descrip);
                            if (ubiii.reconocer(ubicaciones))
                            {
                                ubicaciones.Add(ubiii);
                            }
                            foreach (Ubicacion item in ubicaciones)
                            {
                                if (item.nombre_lugar == nombreubi)
                                {
                                    foreach (Usuario usu in usuarios_no_iguales)
                                    {
                                        if (usu.rut == mirut)
                                        {
                                            Objeto nuevop = new Objeto((objeto_perdido.Count() + 1), nombrenuevoo, false, item, usu, null);
                                            objeto_perdido.Add(nuevop);
                                            Console.WriteLine("se ha añadido objeto perdido");
                                            keeploopingg = false;
                                            hugeloop = false;
                                        }
                                    }
                                }
                            }





                        }
                    }


                }
                if (opcionn == "2")
                {
                    Console.WriteLine("ingresar tipo de ropa nuevo");
                    string nuevatipo = Console.ReadLine();
                    Console.WriteLine("ingrese talla si es que quiere, en el caso de no necesitar precione ENTER");
                    string talllaa = Console.ReadLine();
                    tipoderopa.Add(nuevatipo);
                    string nombrenuevoo = nuevatipo + " " + talllaa;
                    bool keeploopingggg = true;
                    while (keeploopingggg)
                    {
                        Console.WriteLine("ingrese ubicacion existente o nueva");
                        foreach (Ubicacion item in ubicaciones)
                        {
                            Console.WriteLine(item.nombre_lugar);
                        }
                        Console.WriteLine("si desea ingresar ubicacion nueva presione 1, en caso de querer usar ubicacion predeterminada presione 2");
                        string opcionnn = Console.ReadLine();
                        if (opcionnn == "2")
                        {
                            Console.WriteLine("ingrese ubicacion existente");
                            string ubicacionaingresar = Console.ReadLine();
                            foreach (Ubicacion u in ubicaciones)
                            {
                                if (ubicacionaingresar == u.nombre_lugar)
                                {
                                    foreach (Usuario a in usuarios_no_iguales)
                                    {
                                        if (a.rut == mirut)
                                        {
                                            Objeto nuevop = new Objeto((objeto_perdido.Count() + 1), nombrenuevoo, false, u, a, null);
                                            keeploopingggg = false;
                                            hugeloop = false;
                                            break;
                                        }
                                    }

                                }
                            }
                        }
                        if (opcionnn == "1")
                        {
                            Console.WriteLine("ingrese nombre de ubicacion nueva");
                            string nombreubi = Console.ReadLine();
                            Console.WriteLine("ingresar descripcion breve de lugar");
                            string descrip = Console.ReadLine();
                            Ubicacion ubiii = new Ubicacion(nombreubi, descrip);
                            foreach (Usuario usu in usuarios_no_iguales)
                            {
                                if (usu.rut == mirut)
                                {
                                    Objeto nuevop = new Objeto((objeto_perdido.Count() + 1), nombrenuevoo, false, ubiii, usu, null);
                                    objeto_perdido.Add(nuevop);
                                    Console.WriteLine("se ha añadido objeto perdido");
                                    keeploopingggg = false;
                                    hugeloop = false;
                                }
                            }




                        }
                        if (opcionnn == "3")
                        {
                            break;
                        }
                    }



                }
                if (opcionn == "3")
                {
                    break;
                }
                if (opcionn != "1" && opcionn != "2" && opcionn != "3")
                {
                    Console.WriteLine("opcion ingresada no valida, regresando...");
                }

            }


        
    }
    }
}
