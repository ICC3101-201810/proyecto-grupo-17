using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostAndFound
{
    class Usuario_comun : Usuario
    {
        double calificacion;
        public Usuario_comun(string rut, string contrasenia, string nombre_usuario, string mail, double calificacion): base(rut, contrasenia, nombre_usuario,mail)
        {
            this.calificacion = calificacion;
        }
        public double Calificacion { get => calificacion; }
    }
}
