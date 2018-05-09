using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace LostAndFound
{
    public partial class Form1 : Form
    {

      
        List<string> ruts_totales = new List<string>();
        List<Objeto> objetos = new List<Objeto>();
        List<Ubicacion> ubicaciones = new List<Ubicacion>();
        List<Usuario> usuarios = new List<Usuario>();
        List<string> rut_usuarios = new List<string>();
        List<string> appelidos = new List<string>();
        public List<string> nombres = new List<string>();
        public List<Usuario> usuarios_no_iguales = new List<Usuario>();
        List<Objeto> objeto_perdido = new List<Objeto>();
        List<Objeto> objeto_encontrado = new List<Objeto>();
        List<Objeto> objeto_totales = new List<Objeto>();
        List<Objeto> muestral = new List<Objeto>();
        List<string> tallas = new List<string>();
        List<string> tipoderopa = new List<string>();
        Ubicacion ubicacion1 = new Ubicacion("biblioteca", "edificio central superior");
        Ubicacion ubicacion2 = new Ubicacion("ciencias", "De ladrillos, con anfiteatro");
        Ubicacion ubicacion3 = new Ubicacion("humanidades", "de ladrillo, sin anfiteatro y cuadrado");
        Ubicacion ubicacion4 = new Ubicacion("Cen", "edificio central similar al loubre");
        Ubicacion ubicacion5 = new Ubicacion("canchas superiores", "antes de la clinica");
        Ubicacion ubicacion6 = new Ubicacion("cancha nivel u", "entremedio del muro de escalada");
        Ubicacion ubicacion7 = new Ubicacion("cancha inferior oficial", "cancha niver san carlos");
        Ubicacion ubicacion8 = new Ubicacion("camarin hombres", "a la derecha del muro de escalada");
      

        Random random = new Random();
        List<string> noiguales = new List<string>();
        List<string> cleanlist = new List<string>();
        




        public Form1()
        {
            InitializeComponent();
            ubicaciones.Add(ubicacion1);
            ubicaciones.Add(ubicacion2);
            ubicaciones.Add(ubicacion3);
            ubicaciones.Add(ubicacion4);
            ubicaciones.Add(ubicacion5);
            ubicaciones.Add(ubicacion6);
            ubicaciones.Add(ubicacion7);
            ubicaciones.Add(ubicacion8);
            nombres.Add("Carlos");
        nombres.Add("Gonzalo");
        nombres.Add("Gabriela");
        nombres.Add("Raimundo");
        nombres.Add("Isidora");
        nombres.Add("juan");
        nombres.Add("Esteban");
        nombres.Add("Alan");
        nombres.Add("Juanita");
        nombres.Add("Zacarias");
        nombres.Add("Matias");
        appelidos.Add("Brito");
        appelidos.Add("Quito");
        appelidos.Add("Santiago");
        appelidos.Add("E MANUEL");
        appelidos.Add("Del pilar");
        appelidos.Add("De La fuente");
        appelidos.Add("Rosas");
        appelidos.Add("Rojas");
        appelidos.Add("del fuego");
        appelidos.Add("Un Perno");
        appelidos.Add("Un Troncho");
        appelidos.Add("Piña");
        appelidos.Add("Jaguar");
        appelidos.Add("Peña");
        tallas.Add("XXl");
        tallas.Add("XL");
        tallas.Add("L");
        tallas.Add("M");
        tallas.Add("S");
        tallas.Add("XS");
        tipoderopa.Add("pantalones");
        tipoderopa.Add("shorts");
        tipoderopa.Add("zapatillas");
        tipoderopa.Add("Caño");
        tipoderopa.Add("polera");
        tipoderopa.Add("poleron");
        tipoderopa.Add("calzon"); 
        

        }
        

        public void visiblelogin()
        {
            LOGIN.Visible = true;
            label1.Visible = true;
            labelrut.Visible = true;
            miclave.Visible = true;
            ruttext.Visible = true;
            boton_login.Visible = true;
            boton_nuevaCuenta.Visible = true;


        }
        public void NOvisiblelogin()
        {
            LOGIN.Visible = false;
            label1.Visible =false;
            labelrut.Visible = false;
            miclave.Visible = false;
            ruttext.Visible = false;
            boton_login.Visible = false;
            boton_nuevaCuenta.Visible = false;


        }
        public void visibleVerUsu()
        {
            panelVerUsu.Visible = true;
            VerUsu.Visible = true;
            labelverusu.Visible = true;
            buttonagregarusu.Visible = true;
            buttoneliminarusu.Visible = true;
            botonvolvermenu.Visible = true;

        }
        

        private void boton_login_Click(object sender, EventArgs e)
        {
            NOvisiblelogin();
            int ruttest=Int32.Parse(ruttext.Text);
            foreach (Usuario u in usuarios_no_iguales)
            {
                if (ruttest == u.rut && miclave.Text == u.password)
                {
                    if (u.administrador)
                    {
                        NOvisiblelogin();
                        panelAdmin.Visible = true;
                           //menu admin
                    }
                    else
                    {
                        NOvisiblelogin();
                        panelUsuario.Visible = true;
                        //menu usuario
                    }
                
                }
                else
                {
                    MessageBox.Show("el usuario o la contraseña es erronea! por favor intentar denuevo");
                }
            }
                
        }

        private void boton_nuevaCuenta_Click(object sender, EventArgs e)
        {
            NOvisiblelogin();
            panelCuentaNueva.Visible = true;

        }

        private void boton_simulacion_Click(object sender, EventArgs e)
        {
            int numero_de_usuarios=Convert.ToInt32(c_dias.Text);
            int horas=Convert.ToInt32(c_horas.Text);
            int dias=Convert.ToInt32(c_usuarios.Text);

            for (int i = 0; i < numero_de_usuarios; i++)
            {
                int ruto = i + 1000;
                string name = nombres[random.Next(nombres.Count())];
                int suma = 1 + 200;
                string appellido1 = appelidos[random.Next(appelidos.Count())];
                string apelidos2 = appelidos[random.Next(appelidos.Count())];
                string password = suma.ToString();
                string fullname = name + " " + apelidos2 + " " + appellido1;
                noiguales.Add(fullname);
                string mail = name + appellido1 + apelidos2 + "@miuandes.cl";
                bool admin;
                if (random.Next(5) == 3)
                {
                    admin = true;

                }
                else
                {
                    admin = false;
                }

                Usuario usuario = new Usuario(ruto, password, fullname, mail, admin, 0);
                usuarios.Add(usuario);
            }
            usuarios_no_iguales = usuarios.Distinct().ToList();
            int contador = 0;
            int contadorinbox = 0;
            for (int i = 0; i < dias; i++)
            {
                for (int p = 0; p < horas; p++)
                {
                    for (int t = 0; t < random.Next(10); t++)
                    {
                        contador = contador + 1;
                        string nombreobjeto = tipoderopa[random.Next(tipoderopa.Count())] + " " + tallas[random.Next(tallas.Count())];
                        int marin = random.Next(4);
                        if (marin == 3)
                        {
                            contadorinbox++;
                            Usuario u = usuarios_no_iguales[random.Next(usuarios.Count())];
                            Usuario po = usuarios_no_iguales[random.Next(usuarios.Count())];
                            Objeto objetiño = new Objeto(contador, nombreobjeto, true, ubicaciones[random.Next(ubicaciones.Count())], u, po);
                            Inbox inbos = new Inbox(po, u, contadorinbox);
                            po.calificacion = po.calificacion + random.Next(5);
                            objeto_encontrado.Add(objetiño);
                            objeto_totales.Add(objetiño);
                        }
                        if (marin == 0 || marin == 1 || marin == 2 || marin == 4)
                        {
                            Usuario ti = usuarios_no_iguales[random.Next(usuarios.Count())];
                            Objeto objetiño = new Objeto(contador, nombreobjeto, false, ubicaciones[random.Next(ubicaciones.Count())], null, ti);
                            objeto_perdido.Add(objetiño);
                            objeto_totales.Add(objetiño);
                        }


                    }
                }
            }
            MessageBox.Show("simulacion creada con exito!");
            simulation.Visible = false;
            c_dias.Visible = false;
            c_horas.Visible = false;
            c_usuarios.Visible = false;
            boton_simulacion.Visible = false;
            visiblelogin();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                usuarios_no_iguales.Add(yo1);
                if (admin1)
                {
                    panelCuentaNueva.Visible = false;
                    panelAdmin.Visible = true;
                }
                else
                {
                    panelCuentaNueva.Visible = false;
                    panelUsuario.Visible = true;
                }

            }
            else
            {
                MessageBox.Show("las contraseñas no coinciden");
            }
        }

        private void buttonverUsuarios_Click(object sender, EventArgs e)
        {
            panelAdmin.Visible = false;
            visibleVerUsu();
            //hacer visible panelverusuario
            foreach (Usuario item in usuarios_no_iguales)
            {
                VerUsu.Items.Add(item.nombre_usuario);
            }
        }


        private void botonvolvermenu_Click(object sender, EventArgs e)
        {
            panelVerUsu.Visible = false;
           
        }

        private void buttonagregarusu_Click(object sender, EventArgs e)
        {
            panelVerUsu.Visible = false;
            panelCuentaNueva.Visible = true;
        }

        private void buttoneliminarusu_Click(object sender, EventArgs e)
        {
            VerUsu.Items.Remove(VerUsu.SelectedItems);
            //me falta eliminar de la lista de usuarios no iguales
           
         
        }

   
    }
}

  

