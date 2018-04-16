using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostAndFound
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ruts_totales;
            List<Objeto> objetos;
            List<Ubicacion> ubicaciones;
            List<Usuario> usuarios;
            List<string> rut_usuarios;

            void Registrarse()
            {
                Console.WriteLine("Bienvenido al Lost & Found Uandes, para comenzar debes registrarte\n" +
                    "Ingresa tu rut:\n");
                string rut = Console.ReadLine();
                if (ruts_totales.Contains(rut))
                {
                    Console.WriteLine("--------REGISTRARSE---------\n" +
                        "Ingrese el tipo de usuario\n" +
                        "1. Usuario Comun \n" +
                        "2. Administrador\n");
                    string opcion_usuario = Console.ReadLine();
                    if(opcion_usuario == "1")
                    {
                        rut_usuarios.Add(rut);
                        Console.WriteLine("Ingrese su nombre de usuario: \n");
                        string nombre_usuario = Console.ReadLine();
                        Console.WriteLine("Ingrese una contraseña:\n");
                        string password = Console.ReadLine();
                        Console.WriteLine("Ingresa tu mail: \n");
                        string mail = Console.ReadLine();
                        double calificacion = 0.0;
                        Usuario_comun usuario_comun = new Usuario_comun(rut, password, nombre_usuario, mail, calificacion);
                        usuarios.Add(usuario_comun);
                        Console.WriteLine(nombre_usuario + " Te has registrado con exito!\n");
                    }
                    else if(opcion_usuario == "2")
                    {
                        rut_usuarios.Add(rut);
                        Console.WriteLine("Ingrese su id de administrados: \n");
                        string id_admin = Console.ReadLine();
                        Console.WriteLine("Ingrese una contraseña:\n");
                        string password_admin = Console.ReadLine();
                        Console.WriteLine("Ingresa tu mail: \n");
                        string mail_admin = Console.ReadLine();
                        Administrador administrador = new Administrador(rut, password_admin, id_admin, mail_admin );
                        usuarios.Add(administrador);
                        Console.WriteLine("Administrador" + id_admin + "te has registrado con exito!\n");
                    }
                    else { Console.WriteLine("Usted no pertenece a la UANDES\n"); }
                }
                void Iniciar_sesion()
                {
                    IC:
                    Console.WriteLine("-------INICIAR SESION--------" +
                        "Selecciona tu tipo de usuario\n" +
                        "1. Usuario Comun\n" +
                        "2. Administrador");
                    string opcion = Console.ReadLine();
                    if (opcion == "1")
                    {
                        Console.WriteLine("Ingresa tu RUT: \n");
                        string rut_i = Console.ReadLine();
                        if (rut_usuarios.Contains(rut_i))
                        {
                            Console.WriteLine("Ingresa tu clave: \n");
                            string pass_i = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("No se encuentra registrado");
                        }
                    }
                    else if(opcion == "2")
                    {
                        Console.WriteLine("Ingresa tu RUT: \n");
                        string rut_i = Console.ReadLine();
                        if (rut_usuarios.Contains(rut_i))
                        {
                            Console.WriteLine("Ingresa tu clave: \n");
                            string pass_i = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("No se encuentra registrado");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ingresa una opcion valida.\n");
                        goto IC;
                    }

                }
            }

        }
    }
}
