using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostAndFound
{
    public class Objeto
    {
        //perdido_encontrado = false => perdido
        //perdido_encontrado = true => encontrado
        private int codigo;
        public bool perdido_encontrado;
        public string descripcion;
        public Ubicacion ubicacion;
        public Usuario usuarioencontro, usuarioperdio;

        public int Codigo { get => codigo; set => codigo = value; }

        public Objeto(int codigo, string descripcion, bool perdido_encontrado, Ubicacion ubicacion,Usuario usuarioencontro, Usuario usuarioperdido)
        {
            this.Codigo = codigo;
            this.descripcion = descripcion;
            this.perdido_encontrado = perdido_encontrado;
            this.ubicacion = ubicacion;
            this.usuarioencontro = usuarioencontro;
            this.usuarioperdio = usuarioperdido;
        }
        // public void mostrarobj { }

        
    }
}
