using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostAndFound
{
    class Objeto
    {
        int codigo, perdido_encontrado;
        List<string> categorias;
        string descripcion, lugar_destino;
        Ubicacion ubicacion;
        public Objeto(int codigo, List<string> categorias, string descripcion, int perdido_encontrado, Ubicacion ubicacion, string lugar_destino)
        {
            this.codigo = codigo;
            this.categorias = categorias;
            this.descripcion = descripcion;
            this.perdido_encontrado = perdido_encontrado;
            this.ubicacion = ubicacion;
            this.lugar_destino = lugar_destino;
        }

    }
}
