using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostAndFound
{
    class Administrador: Usuario
    {
        public Administrador(string rut, string contrasenia, string nombre_usuario, string mail) : base(rut, contrasenia, nombre_usuario, mail)
        {

        }

    }
}
