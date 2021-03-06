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
    public class Objeto
    {
        //perdido_encontrado = false => perdido
        //perdido_encontrado = true => encontrado
        public int codigo;
        public bool perdido_encontrado;
        public string descripcion;
        public Ubicacion ubicacion;
        public Usuario usuarioencontro, usuarioperdio;
        public string tipo;

        public int Codigo { get => codigo; set => codigo = value;   }

        public Objeto(int codigo, string descripcion, bool perdido_encontrado, Ubicacion ubicacion,Usuario usuarioencontro, Usuario usuarioperdido,string tipo)
        {
            this.Codigo = codigo;
            this.descripcion = descripcion;
            this.perdido_encontrado = perdido_encontrado;
            this.ubicacion = ubicacion;
            this.usuarioencontro = usuarioencontro;
            this.usuarioperdio = usuarioperdido;
            this.tipo = tipo;
        }
        public void InfoO()
        {
            if (this.perdido_encontrado)
            {
                Console.WriteLine("nombre de objeto: " + this.descripcion + "" +
               " objeto perdido por:" + this.usuarioperdio.nombre_usuario +
               "en el lugar " + this.ubicacion.nombre_lugar + this.ubicacion.indicacion +
               "encontrado por: " + this.usuarioencontro.nombre_usuario +
               "\n");
            }
            else
            {
                Console.WriteLine("nombre de objeto: " + this.descripcion +
                " objeto perdido por:" + this.usuarioperdio.nombre_usuario +
               "en el lugar " + this.ubicacion.nombre_lugar +this.ubicacion.indicacion +
               "\n"); 
            }
            
        }
        

        

        
    }
}
