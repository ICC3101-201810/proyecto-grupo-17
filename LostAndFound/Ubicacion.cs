using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostAndFound
{
    class Ubicacion
    {
        string nombre_lugar, indicacion;
        public Ubicacion(string nombre_lugar, string indicacion)
        {
            this.nombre_lugar = nombre_lugar;
            this.indicacion = indicacion;
        }
        public string Nombre_lugar { get => nombre_lugar; }
        public string Indicacion { get => indicacion; }
    }
}
