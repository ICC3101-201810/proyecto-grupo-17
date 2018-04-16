using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostAndFound
{
    abstract class Usuario
    {
        string rut;
        string password;
        string nombre_usuario;
        string mail;

        public Usuario(string rut, string password, string nombre_usuario, string mail)
        {

            this.rut = rut;
            this.password = password;
            this.nombre_usuario = nombre_usuario;
            this.mail = mail;
        }
        public string Rut { get => rut;}
        public string Nombre_usuario { get => nombre_usuario; }
        public string Mail { get => mail; }
    }
}
