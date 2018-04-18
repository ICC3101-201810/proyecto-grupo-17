using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostAndFound
{
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
        public void mostrar(List<Usuario>usuarios)
        {
            foreach (Usuario usuario in usuarios)
            {
                Console.WriteLine(usuario.nombre_usuario);
            }
        }

    }

}
