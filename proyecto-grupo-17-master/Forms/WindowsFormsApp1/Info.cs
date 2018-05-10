using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Info
    {
        public List<int> ruts_totales;
        public List<Objeto> objetos;
        public List<Ubicacion> ubicaciones;
        public List<Usuario> usuarios;
        public List<int> rut_usuarios;
        public List<Usuario> usuarios_no_iguales;
        public List<Objeto> objeto_perdido;
        public List<Objeto> objeto_encontrado;
        public List<Objeto> objeto_totales;

        public Info(List<int> ruts_totales, List<Objeto> objetos, List<Ubicacion> ubicaciones, List<Usuario> usuarios, List<int> rut_usuarios, List<Usuario> usuarios_no_iguales, List<Objeto> objeto_perdido, List<Objeto> objeto_encontrado, List<Objeto> objeto_totales)
        {
            this.ruts_totales = ruts_totales;
            this.objetos = objetos;
            this.ubicaciones = ubicaciones;
            this.usuarios = usuarios;
            this.rut_usuarios = rut_usuarios;
            this.usuarios_no_iguales = usuarios_no_iguales;
            this.objeto_perdido = objeto_perdido;
            this.objeto_encontrado = objeto_encontrado;
            this.objeto_totales = objeto_totales;
        }
    }
}
