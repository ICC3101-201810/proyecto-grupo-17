using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace LostAndFound
{
    internal static class NativeMethods
    {
        [DllImport("kernel32.dll")]
        internal static extern Boolean AllocConsole();
    }
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                // run as windows app
                Application.EnableVisualStyles();
                Application.Run(new Menu());
            }
            else
            {
                // run as console app
                NativeMethods.AllocConsole();
                Console.WriteLine("Hello World");
                Console.ReadLine();
            }

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
            Console.WriteLine("Hola antes de iniciar el programa haremos unas pocas preguntas de simulacion \n" +
                "ingrese numero de usuarios max 300");
            int numero_de_usuarios = Convert.ToInt32(Console.ReadLine());
            while (numero_de_usuarios>300)
            {
                Console.WriteLine("numero ingresado incorrecto porfavor ingrese nuevamente el numero");
                numero_de_usuarios = Convert.ToInt32(Console.ReadLine());

            }
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

                Usuario usuario = new Usuario(ruto, password, fullname, mail, admin,0 );
                usuarios.Add(usuario);
            }
            usuarios_no_iguales = usuarios.Distinct().ToList();
            Console.WriteLine("Ingrese numero de dias a simular");
            int dias = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese horas por dia a simular");
            int horas = Convert.ToInt32(Console.ReadLine());
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
                            Objeto objetiño = new Objeto(contador, nombreobjeto, true, ubicaciones[random.Next(ubicaciones.Count())], u, po, null);
                            Inbox inbos = new Inbox(po, u, contadorinbox);
                            po.calificacion = po.calificacion + random.Next(5);
                            objeto_encontrado.Add(objetiño);
                            objeto_totales.Add(objetiño);
                        }
                        if (marin == 0 || marin == 1 || marin == 2 || marin == 4)
                        {
                            Usuario ti = usuarios_no_iguales[random.Next(usuarios.Count())];
                            Objeto objetiño = new Objeto(contador, nombreobjeto, false, ubicaciones[random.Next(ubicaciones.Count())],null,ti, null);
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
                    bool maringo = true;
                    bool admin = false;
                    while (maringo)
                    {
                        Console.WriteLine("Ooops! el programa se olvido de su condicion ,  es usetd administrador? \n" +
                            "presione 1 si lo es, en caso de no serlo preciones 2");
                        string decicision = Console.ReadLine();
                        if (decicision == "1")
                        {
                            admin = true;
                            maringo = false;
                        }
                        if (decicision == "2")
                        {
                            admin = false;
                            maringo = false;
                        }
                        if (decicision != "1"&&decicision !="2")
                        {
                            Console.WriteLine("opcion ingresada no valida");
                        }
                    }
                    Usuario yo1 = new Usuario(mirut, pass, nombre, elmail, admin, 0);
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
                            bool flamingo = true;
                            bool admin1 = false;
                            while (flamingo)
                            {
                                Console.WriteLine("Es usted administrador? \n" +
                                    "1 = si \n" +
                                    "2 = no");
                                string decicision = Console.ReadLine();
                                if (decicision == "1")
                                {
                                    admin1 = true;
                                    flamingo = false;
                                }
                                if (decicision == "2")
                                {
                                    admin1 = false;
                                    flamingo = false;
                                }
                                if (decicision != "1" && decicision != "2")
                                {
                                    Console.WriteLine("opcion ingresada no valida");
                                }
                            }
                            Usuario yo1 = new Usuario(mirut, mipass1,minombre,mimail,admin1,0);
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
                    break;
                }
            }
            while (opcion != "8")
            {
                Console.WriteLine(" \nIngrese opcion : \n" +
                    "opcion 1 = ver usuarios(SOLO ADMINISTRADORES) \n" +
                    "opcion 2 = ver objetos perdidos \n" +
                    "opcion 3 = ver objetos encontrados(SOLO ADMINISTRADORES) \n" +       
                    "opcion 4 = agregar perdida de objeto \n" +
                    "opcion 5 = añadir ususario(SOLO ADMINISTRADOR) \n" +
                    "opcion 6 = ver calificaciones(SOLO ADMINISTRADOR) \n" +
                    "opcion 7 = eliminar usuario(SOLO ADMINISTRADOR)\n"+
                    "opcion 8 = salir \n " );
                opcion = Console.ReadLine();
                if (opcion == "1")
                {
                    foreach (Usuario item in usuarios_no_iguales)
                    {
                        if (mirut == item.rut)
                        {
                            if (item.administrador)
                            {
                                item.Mostrar(usuarios_no_iguales);
                            }
                        }
                       

                    }
                }
                if (opcion == "2")
                {
                    Console.WriteLine("NOMBRE OBJETO                   CODIGO             UBICACION");
                    foreach (Objeto objeto in objeto_perdido ) 
                    {
                        Console.WriteLine(objeto.descripcion +"                 "+ objeto.codigo+"                 "+objeto.ubicacion.nombre_lugar);
                    }
                    Console.WriteLine("Encontro un Objeto perdido\n (1)SI\n (2)NO\n");
                    string opc = Console.ReadLine();
                    
                    if (opc=="1")
                    {
                        Console.WriteLine("escriba el codigo del objeto que encontro");
                        int codigoo = Int32.Parse(Console.ReadLine());
                        foreach (Objeto obj in objeto_perdido)
                        {
                            if (codigoo ==obj.codigo)
                            {
                                obj.perdido_encontrado = true;
                                foreach (Usuario usu1 in usuarios_no_iguales)
                                {
                                    if (mirut==usu1.rut)
                                    {
                                        Objeto obj1 = obj;
                                        obj.usuarioencontro = usu1;
                                        Console.WriteLine("Inbox creado!! " +obj.usuarioperdio.nombre_usuario+ " con "+obj.usuarioencontro.nombre_usuario);
                                        Console.WriteLine("Objeto encontrado con exito");
                                        contadorinbox++;
                                        Inbox inob= new Inbox(obj.usuarioperdio, usu1, contadorinbox);
                                        objeto_perdido.Remove(obj1);
                                        objeto_encontrado.Add(obj1);

                                    }
                                }
                                break;
                            }
                            

                        }
                       


                    }
                }
                if (opcion == "3")
                {
                    foreach (Usuario item in usuarios_no_iguales)
                    {
                        if (mirut == item.rut && item.administrador)
                        {
                            foreach (Objeto itemm in objeto_encontrado)
                            {
                                itemm.InfoO();

                            }
                        }
                       
                    }
                    continue;
                }
                if (opcion =="4")
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
                            foreach  (string i in tipoderopa)
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
                                                    Objeto nuevop = new Objeto((objeto_perdido.Count() + 1),nombrenuevoo,false, u,a, null,null);
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
                                    if (ubiii.Reconocer(ubicaciones))
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
                                                    Objeto nuevop = new Objeto((objeto_perdido.Count() + 1), nombrenuevoo, false, item, usu, null,null);
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
                                                    Objeto nuevop = new Objeto((objeto_perdido.Count() + 1), nombrenuevoo, false, u, a, null,   null);
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
                                            Objeto nuevop = new Objeto((objeto_perdido.Count() + 1), nombrenuevoo, false, ubiii, usu, null, null);
                                            objeto_perdido.Add(nuevop);
                                            Console.WriteLine("se ha añadido objeto perdido");
                                            keeploopingggg = false;
                                            hugeloop = false;
                                        }
                                    }




                                }
                                if (opcionnn=="3")
                                {
                                    break;
                                }
                            }



                        }
                        if (opcionn=="3")
                        {
                            break;
                        }
                        if (opcionn != "1" && opcionn != "2"&& opcionn != "3" )
                        {
                            Console.WriteLine("opcion ingresada no valida, regresando...");
                        }
                        
                    }
                    
                     
                }
                if (opcion == "5")
                {
                    foreach (Usuario item in usuarios_no_iguales)
                    {
                        if (mirut == item.rut && item.administrador)
                        {
                            Console.WriteLine("ingrese rut  de un Nuevo Usuario sin puntos ni guion ej: \n" +
                             " 19.309.333-7 = 193093337");
                            string rut1 = Console.ReadLine();
                            int mirut1 = Convert.ToInt32(rut1);
                            bool keeplooping1 = true;
                            while (keeplooping1)
                            {
                                Console.WriteLine("ingrese contraseña nueva para el nuevo Usuario");
                                string mipass1 = Console.ReadLine();
                                Console.WriteLine("repita su contraseña");
                                string pass2 = Console.ReadLine();
                                if (mipass1 == pass2)
                                {
                                    Console.WriteLine("contraseña aceptada!");
                                    Console.WriteLine("ingrese  nombre de Usuario");
                                    string minombre = Console.ReadLine();
                                    Console.WriteLine("ingrese  mail Uandes a continuacion de Usuario");
                                    string mimail = Console.ReadLine();
                                    bool flamingo = true;
                                    bool admin1 = false;
                                    while (flamingo)
                                    {
                                        Console.WriteLine("Este Usuario es administrador? \n" +
                                            "1 = si \n" +
                                            "2 = no");
                                        string decicision = Console.ReadLine();
                                        if (decicision == "1")
                                        {
                                            admin1 = true;
                                            flamingo = false;
                                        }
                                        if (decicision == "2")
                                        {
                                            admin1 = false;
                                            flamingo = false;
                                        }
                                        if (decicision != "1" && decicision != "2")
                                        {
                                            Console.WriteLine("opcion ingresada no valida");
                                        }
                                    }
                                    Usuario yo1 = new Usuario(mirut1, mipass1, minombre, mimail, admin1, 0);
                                    Console.WriteLine("Usuario creado con exito");
                                    usuarios_no_iguales.Add(yo1);
                                    keeplooping1 = false;
                                    

                                }
                            }
                            break;
                        }
                      

                    }
                }
                
                if (opcion == "6")
                {

                    foreach (Usuario u in usuarios_no_iguales)
                    {
                        if (mirut == u.rut)
                        {
                            u.Vercalificacion(usuarios_no_iguales);
                        }
                       
                    }
                    
                    continue;
                }
                if (opcion == "7")
                {
                    List<Usuario> usuariossss = new List<Usuario>();
                    foreach (Usuario item1 in usuarios_no_iguales)
                    {
                        if (mirut == item1.rut && item1.administrador)
                        {
                            Console.WriteLine("USUSARIOS                  RUT  \n");
                            Console.WriteLine("-------------------------------------------");

                            foreach (Usuario usu in usuarios_no_iguales)
                            {                   
                                Console.WriteLine(usu.nombre_usuario+" "+usu.rut);
                            }
                            Console.WriteLine("rut de usurario que quiera eliminar");
                            int rutt= Int32.Parse(Console.ReadLine());
                            
                            foreach (Usuario usu in usuarios_no_iguales)
                            {
                                if (rutt==usu.rut)
                                {

                                    usuariossss.Add(usu);
                                }
                            }
                            

                        }
                       
                    }
                    foreach (Usuario u in usuariossss)
                    {
                        usuarios_no_iguales.Remove(u);
                        Console.WriteLine("usuario removido con exito!");
                    }
                    continue;
                }
                if (opcion == "8")
                {
                    break;
                }
                if (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4" && opcion != "5" && opcion != "6" && opcion != "7" && opcion != "8")
                {
                    Console.WriteLine("opcion ingresada no valida regresando al menu prinicpal...");
                    break;
                }
            }

        }
    }
}
