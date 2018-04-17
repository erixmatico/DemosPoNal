using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            MetodosEjercicios m = new MetodosEjercicios();
            Console.WriteLine(m.retornarMensaje());
            Console.WriteLine(m.retornarMensaje("Hola Mundazo"));
            Console.WriteLine(m.retornarMensaje("Hola Mundo" + " Edwin Bustos"));
            Console.WriteLine(m.retornarMensaje("Hola Mundo" + " Edwin Bustos " + 25));
            string[] mensajes = { "Genial", "vamos", "a hacerlo" };            
            Console.WriteLine(string.Concat(m.retornarMensaje(mensajes)).ToString());
            string nombre = "Fabian Sanchez";
            m.parametroPorReferencia(ref nombre);
            Console.WriteLine(nombre);
            Console.WriteLine(m.parametroPorReferencia(ref nombre, 42));
            int uno = 50;
            int dos = 80;
            Console.WriteLine(m.parametroPorReferencia(ref uno, ref dos));
            Console.WriteLine(m.parametrosOpcionales("Edwin Bustos", sexo:'F'));
            Console.WriteLine(m.parametrosOpcionales("Fabian Sanchez",40));
            Console.WriteLine(m.parametrosOpcionales(25,175,nombre:"Barbozo Juarez"));
            Console.ReadKey();

        }
    }
}
