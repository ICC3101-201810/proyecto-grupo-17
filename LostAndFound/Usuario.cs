using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LostAndFound
{
    [Serializable]
    public class Usuario
    {
        public int rut;
        public string password;
        public string nombre_usuario;
        public string mail;
        public bool administrador;
        public int calificacion;

        public Usuario(int rut, string password, string nombre_usuario, string mail, bool administrador, int calificacion)
        {

            this.rut = rut;
            this.password = password;
            this.nombre_usuario = nombre_usuario;
            this.mail = mail;
            this.administrador = administrador;
            this.calificacion = calificacion;
        }
        public string Nombre_usuario { get => nombre_usuario; }
        public string Mail { get => mail; }
        public void Mostrar(List<Usuario>usuarios)
        {
            foreach (Usuario usuario in usuarios)
            {
                Console.WriteLine(usuario.nombre_usuario);
            }
        }
        public void Vercalificacion()
        {
            Console.WriteLine("nombre de ususario: "+this.nombre_usuario+" calificacion: "+this.calificacion+"\n");
        }
        public void Vercalificacion(List<Usuario> usuarios_no_iguales)
        {
            if (this.administrador)
            {
                foreach (Usuario itemm in usuarios_no_iguales)
                {
                    itemm.Vercalificacion();

                }
            }
        }
        public Usuario Reconocerusuario(List<Usuario> usuarios_no_iguales,int rut)
        {
            foreach (Usuario usuario in usuarios_no_iguales)
            {
                if (usuario.rut == rut)
                {
                    return usuario;
                }
            }
            Usuario usuario1 = new Usuario(0, " ", " ", " ", false, 0);
            return usuario1;
        }

    }

}
