using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;

namespace WindowsFormsApp1
{
    public delegate void addUsuario();
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            List<string> ruts_totales = new List<string>();
            List<Objeto> objetos = new List<Objeto>();
            List<Ubicacion> ubicaciones = new List<Ubicacion>();
            List<Usuario> usuarios = new List<Usuario>();
            List<string> rut_usuarios = new List<string>();
            List<string> appelidos = new List<string>();
            List<string> nombres = new List<string>();
            List<Usuario> usuarios_no_iguales = new List<Usuario>();
            List<Objeto> objeto_perdido = new List<Objeto>();
            List<Objeto> objeto_encontrado = new List<Objeto>();
            List<Objeto> objeto_totales = new List<Objeto>();
            List<Objeto> muestral = new List<Objeto>();
            List<string> tallas = new List<string>();
            List<string> tipoderopa = new List<string>();
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
            tallas.Add("XL ");
            tallas.Add("L  ");
            tallas.Add("M  ");
            tallas.Add("S  ");
            tallas.Add("XS ");
            tipoderopa.Add("pantalones");
            tipoderopa.Add("shorts    ");
            tipoderopa.Add("zapatillas");
            tipoderopa.Add("Caño      ");
            tipoderopa.Add("polera    ");
            tipoderopa.Add("poleron   ");
            tipoderopa.Add("calzon    ");
            Ubicacion ubicacion1 = new Ubicacion("Biblioteca        ", "edificio central superior");
            Ubicacion ubicacion2 = new Ubicacion("Ciencias          ", "De ladrillos, con anfiteatro");
            Ubicacion ubicacion3 = new Ubicacion("Humanidades       ", "de ladrillo, sin anfiteatro y cuadrado");
            Ubicacion ubicacion4 = new Ubicacion("Cen               ", "edificio central similar al loubre");
            Ubicacion ubicacion5 = new Ubicacion("Canchas superiores", "antes de la clinica");
            Ubicacion ubicacion6 = new Ubicacion("Cancha nivel u    ", "entremedio del muro de escalada");
            Ubicacion ubicacion7 = new Ubicacion("Cancha inferior   ", "cancha nivel san carlos");
            Ubicacion ubicacion8 = new Ubicacion("Camarin hombres   ", "a la derecha del muro de escalada");
            ubicaciones.Add(ubicacion1);
            ubicaciones.Add(ubicacion2);
            ubicaciones.Add(ubicacion3);
            ubicaciones.Add(ubicacion4);
            ubicaciones.Add(ubicacion5);
            ubicaciones.Add(ubicacion6);
            ubicaciones.Add(ubicacion7);
            ubicaciones.Add(ubicacion8);

            Random random = new Random();
            List<string> noiguales = new List<string>();
            List<string> cleanlist = new List<string>();

            int numero_de_usuarios = 5;
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
            int dias = 2;
            int horas = 12;
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
                            Objeto objetiño = new Objeto(contador, nombreobjeto, true, ubicaciones[random.Next(ubicaciones.Count())], u, po,  "ropa");
                            Inbox inbos = new Inbox (po, u, contadorinbox);
                            po.calificacion = po.calificacion + random.Next(5);
                            objeto_encontrado.Add(objetiño);
                            objeto_totales.Add(objetiño);
                        }
                        if (marin == 0 || marin == 1 || marin == 2 || marin == 4)
                        {
                            Usuario ti = usuarios_no_iguales[random.Next(usuarios.Count())];
                            Objeto objetiño = new Objeto(contador, nombreobjeto, false, ubicaciones[random.Next(ubicaciones.Count())], null, ti, "ropa");
                            objeto_perdido.Add(objetiño);
                            objeto_totales.Add(objetiño);
                        }
                    }
                }
            }
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
            SystemSounds.Beep.Play();
            MessageBox.Show("Gracias por ocupar Lost & Found Uandes\n" +
                            "              Vuelve Pronto!");
            this.Close();
        }
        
        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.Exit();
        }

    }
}
