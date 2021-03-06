﻿using System;
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
    public class Ubicacion
    {
        public string nombre_lugar, indicacion;
        public Ubicacion(string nombre_lugar, string indicacion)
        {
            this.nombre_lugar = nombre_lugar;
            this.indicacion = indicacion;
        }
        public string Nombre_lugar { get => nombre_lugar; }
        public string Indicacion { get => indicacion; }
        public bool Reconocer(List<Ubicacion>ubicaciones)
        {
            foreach (Ubicacion item in ubicaciones)
            {
                if (this.nombre_lugar == item.nombre_lugar)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
