using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostAndFound
{
    class Horario
    {
        DateTime hora_inicial, hora_final;

        public Horario(DateTime hora_inicial, DateTime hora_final)
        {
            this.hora_inicial = hora_inicial;
            this.hora_final = hora_final;
        }
    }
}
