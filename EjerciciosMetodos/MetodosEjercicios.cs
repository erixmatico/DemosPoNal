using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosMetodos
{
    class MetodosEjercicios
    {
        public MetodosEjercicios()
        {

        }
        public string retornarMensaje()
        {
            return "Hola Mundo";
        }

        public string retornarMensaje(string _mensaje)
        {
            return _mensaje;
        }

        public string retornarMensaje(string _mensaje, string _nombre)
        {
            return _mensaje + _nombre;
        }

        public string retornarMensaje(string _mensaje, string _nombre, int _edad)
        {
           return _mensaje + _nombre + _edad;
        }

        public string[] retornarMensaje(string[] _mensajes)
        {
            return _mensajes;
        }

        public void parametroPorReferencia(ref string _nombre) {
            _nombre = "Edwin Bustos";
        }

        public string parametroPorReferencia(ref string _nombre, int _edad) {
            return _nombre = "Ricardo Villanueva" + _edad;
        }

        public int parametroPorReferencia(ref int _uno, ref int _dos) {
            _uno = 50;
            _dos = 60;
            return _uno + _dos;
        }

        public string parametrosOpcionales(string nombre, int edad = 23, char sexo = 'M' ) {
            return nombre + " " + edad + " " + sexo;
        }

        public string parametrosOpcionales(int edad, int altura, string nombre = "Juanito Olean") {
            return nombre + edad + altura;
        }



    }
}
