using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConcatenearTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenacion de texto con el objeto StringBuilder
            StringBuilder direccion = new StringBuilder();
            direccion.Append("80");
            direccion.Append(", AV CALI");
            direccion.Append(", Buffalo");
            string concatenarCadena = direccion.ToString();

            //Linea para escribir en pantalla
            //Console.WriteLine("Su direccion es: " + concatenarCadena);
            

            //implementacion de condicionales logicos
            //if (si)
            // == Igual que
            // (!=) o (<>) Diferente que
            // > Mayor que
            // < Menor que
            // >= Mayor o igual que
            // <= Menor o igual que
            
            //Declaracion y inicializacion de variables
            int uno = 90;
            int dos = 80;

            //Declaracion de if aninados
            if (uno > dos)
            {
                Console.WriteLine(uno + " > " + dos);
            }
            else if (uno == dos) {
                Console.WriteLine(uno + " == " + dos);
            } 
            else {
                Console.WriteLine(uno + " < " + dos);
            }          

            //Evaluacin de switch anidados
            switch (uno < dos) {
                case true:
                    Console.WriteLine(uno + " < " + dos);
                    break;

                case false:
                    switch (uno > dos) {
                        case true:
                            Console.WriteLine(uno +" > " + dos);
                            break;

                        case false:
                            switch (uno == dos) {
                                case true:
                                    Console.WriteLine(uno + " == " + dos);
                                    break;

                                case false:

                                    break;
                            }
                            break;
                    }
                    break;
            }

            //Formato for
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }


            //Formato foreach
            String nombre = "Edwin Bustos";
            foreach (var nom in nombre)
            {
                Console.WriteLine(nom);
            }

            //Formato while
            int count = 0;
            while (count < 10) {
                Console.WriteLine(count);
                count++;
            }

            //Formato do while
            int count1 = 0;
            do
            {
                Console.WriteLine(count1);
                count1++;
            } while (count1 < 10);

            

            Console.ReadKey();
            //Uso de expresiones regulares con el Objeto Regex
            var texto = "hell0 wOrld";
            var expresionRegular = "\\d";
            var resultado = Regex.IsMatch(texto, expresionRegular);

            
        }
    }
}
