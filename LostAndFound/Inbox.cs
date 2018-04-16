using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostAndFound
{
    class Inbox
    {
        Usuario usuario_p, usuario_e;
        List<Horario> horarios;
        int contador;
        public Inbox(Usuario usuario_p, Usuario usuario_e, List<Horario> horarios, int contador)
        {
            this.usuario_p = usuario_p;
            this.usuario_e = usuario_e;
            this.horarios = horarios;
            this.contador = contador;
        }
    }
}
