using System;
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
    public class Biblioteca
    {

        public List<Objeto> objetos = new List<Objeto>();
        public List<Ubicacion> ubicaciones = new List<Ubicacion>();
        public List<Usuario> usuarios_no_iguales = new List<Usuario>();
        public List<Objeto> objeto_perdido = new List<Objeto>();
        public List<Objeto> objeto_encontrado = new List<Objeto>();
        public List<Objeto> objeto_totales = new List<Objeto>();
        public List<string> tipoderopa = new List<string>();
        public List<string> admin = new List<string>();
        public string rut_admin;



        public Biblioteca(List<Objeto> objetos, List<Ubicacion> ubicaciones, List<Usuario> usuarios_no_iguales, List<Objeto> objeto_perdido, List<Objeto> objeto_encontrado, List<Objeto> objeto_totales, List<string> tipoderopa, List<string> admin, string rut_admin)
        {
            this.objetos = objetos;
            this.ubicaciones = ubicaciones;
            this.usuarios_no_iguales = usuarios_no_iguales;
            this.objeto_perdido = objeto_perdido;
            this.objeto_encontrado = objeto_encontrado;
            this.objeto_totales = objeto_totales;
            this.tipoderopa = tipoderopa;
            this.admin = admin;
            this.rut_admin = rut_admin;
        }
    }
}
