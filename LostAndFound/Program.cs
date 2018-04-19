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
            Ubicacion ubicacion1 = new Ubicacion("biblioteca","edificio central superior");
            Ubicacion ubicacion2 = new Ubicacion("ciencias", "De ladrillos, con anfiteatro");
            Ubicacion ubicacion3 = new Ubicacion("humanidades","de ladrillo, sin anfiteatro y cuadrado");
            Ubicacion ubicacion4 = new Ubicacion("Cen","edificio central similar al loubre");
            Ubicacion ubicacion5 = new Ubicacion("canchas superiores","antes de la clinica");
            Ubicacion ubicacion6 = new Ubicacion("cancha nivel u","entremedio del muro de escalada");
            Ubicacion ubicacion7 = new Ubicacion("cancha inferior oficial","cancha niver san carlos");
            Ubicacion ubicacion8 = new Ubicacion("camarin hombres", "a la derecha del muro de escalada");
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

            for (int i = 0; i < 300; i++)
            {
                int ruto = i + 1000;
                string name = nombres[random.Next(nombres.Count())];
                int suma = 1 + 200;
                string appellido1 = appelidos[random.Next(appelidos.Count())];
                string apelidos2 = appelidos[random.Next(appelidos.Count())];
                string password = suma.ToString();
                string fullname = name + " " + apelidos2 + " " + appellido1;
                noiguales.Add(fullname);
                string mail = name+appellido1 + apelidos2 + "@miuandes.cl";
                bool admin;
                if (random.Next(5) == 3)
                {
                    admin = true;
                
                }
                else
                {
                    admin = false;
                }

                Usuario usuario = new Usuario(ruto, password, fullname, mail, admin, random.Next(0, 100));
                usuarios.Add(usuario);
            }
            usuarios_no_iguales = usuarios.Distinct().ToList();
            int contador = 0;
            int contadorinbox = 0;
            for (int i = 0; i < 13; i++)
            {
                for (int p = 0; p < 24; p++)
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
                            objeto_encontrado.Add(objetiño);
                            objeto_totales.Add(objetiño);
                        }
                        if (marin == 0 || marin == 1 || marin == 2 || marin == 4)
                        {
                            Usuario ti = usuarios_no_iguales[random.Next(usuarios.Count())];
                            Objeto objetiño = new Objeto(contador, nombreobjeto, false, ubicaciones[random.Next(ubicaciones.Count())],null,ti);
                            objeto_perdido.Add(objetiño);
                            objeto_totales.Add(objetiño);
                        }


                    }
                }
            }
            
            string opcion = "inicio";
            Console.WriteLine("\n" +
                "Hola, bienvenido a lost & found uandes");
            Console.WriteLine("ingrese a su rut sin puntos ni guion ej: \n" +
                " 19.309.333-7 = 193093337");
            string rut = Console.ReadLine();
            int mirut = Convert.ToInt32(rut);
           
            bool keeplooping =true;
            while (keeplooping)
            {
                Console.WriteLine("¿desea iniciar sesion o crear cuenta? \n 1 = iniciar sesion \n 2 = crear cuenta");
                string opcion1 = Console.ReadLine();
                if (opcion1 == "1")
                {
                    Console.WriteLine("ingrese contraseña aca :");
                    string pass = Console.ReadLine();
                    Console.WriteLine("Ooops! el programa se olvido de su nombre, ingreselo a continuacion");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ooops! el programa se olvido de su email, ingreselo a continuacion");
                    string elmail = Console.ReadLine();
                    Usuario yo1 = new Usuario(mirut, pass, nombre, elmail, true, 0);
                    usuarios_no_iguales.Add(yo1);
                    keeplooping = false;


                }
                if (opcion1 == "2")
                {
                    while (true)
                    {
                        Console.WriteLine("ingrese contraseña nueva");
                        string mipass1 = Console.ReadLine();
                        Console.WriteLine("repita su contraseña");
                        string pass2 = Console.ReadLine();
                        if (mipass1 == pass2)
                        {
                            Console.WriteLine("contraseña aceptada!");
                            Console.WriteLine("ingrese su nombre");
                            string minombre = Console.ReadLine();
                            Console.WriteLine("ingrese su mail Uandes a continuacion");
                            string mimail = Console.ReadLine();
                            Usuario yo1 = new Usuario(mirut, mipass1,minombre,mimail,true,0);
                            Console.WriteLine("Usuario creado con exito");
                            usuarios_no_iguales.Add(yo1);
                            keeplooping = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("las contraseñas no coinsiden");
                        }
                    }
                }
                if (opcion1 != "1" && opcion1 != "2")               
                {
                    Console.WriteLine("opcion ingresada no valida");
                    continue;
                }
            }
            while (opcion != "4")
            {
                Console.WriteLine(" \nIngrese opcion : \n opcion 1 = ver usuarios(solo administradores) \n opcion 2 = ver objetos perdidos \n opcion 3 = ver objetos encontrados(solo administradores) \n" +
                    " opcion 4 = salir \n opcion 5 = agregar perdida de objeto");
                opcion = Console.ReadLine();
                if (opcion == "1")
                {
                    foreach (Usuario item in usuarios_no_iguales)
                    {
                        if (mirut == item.rut)
                        {
                            if (item.administrador)
                            {
                                item.mostrar(usuarios_no_iguales);
                            }
                        }
                    }
                }
                if (opcion == "2")
                {
                    foreach (Objeto objeto in objeto_perdido ) 
                    {
                        Console.WriteLine(objeto.descripcion);
                    }
                }
                if (opcion =="3")
                {
                    foreach (Objeto  item in objeto_encontrado)
                    {
                        Console.WriteLine(item.descripcion);
                    }
                }
                if (opcion =="5")
                {
                    Console.WriteLine("ingrese lugar donde lo encontro");
                    Console.WriteLine("ingrese tipo del objeto ej :");
                    foreach (string item in tipoderopa)
                    {
                        Console.WriteLine(item);
                    }
                    bool hugeloop = true;
                    while (hugeloop)
                    {
                        Console.WriteLine("desea usar un tipo de ropa determinado o ingresar uno nuevo? \n" +
                        "opcion 1 = usar determinado \n" +
                        "opcion 2 = crear tipo de objeto nuevo");
                        string opcionn = Console.ReadLine();
                        if (opcionn == "1")
                        {
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
                                if (opcionnn == "2" )
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
                                                    Objeto nuevop = new Objeto((objeto_perdido.Count() + 1),nombrenuevoo,false, u,a, null);
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
                                    foreach (Usuario usu in usuarios_no_iguales)
                                    {
                                        if (usu.rut == mirut)
                                        {
                                            Objeto nuevop = new Objeto((objeto_perdido.Count() + 1), nombrenuevoo, false, ubiii, usu, null);
                                            objeto_perdido.Add(nuevop);
                                            Console.WriteLine("se ha añadido objeto perdido");
                                            keeploopingg = false;
                                            hugeloop = false;
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
                            }



                        }
                        if (opcionn != "1" && opcionn != "2")
                        {
                            Console.WriteLine("opcion ingresada no valida, regresando...");
                        }
                    }
                    
                     
                }
            }

        }
    }
}
