using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo1.codigo;


namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejercicio para identificar los tipos de variables
            //int edad = 23;
            //int meses = 12;
            int EdadEnMeses = 23 * 12;

            //Declaracion de variables
            bool bandera = true;
            byte valor = 152;
            short valor0 = -12345;
            int valor1 = 1234567891;
            long valor2 = 2345678978963451786;
            float valor3 = 3.6325445646465416546546545F;
            double valor4 = 5.531489544794126945374354321323434354358;
            decimal valor5 = 5.512313243645363434343434M;
            char caracter = 'u';
            string texto = "Esto es genial";
            var noSe = "";
            var datos = texto + bandera;

            //Conversion implicita
            int a = 4;
            long b = 5;
            b = a;

            string dato = "mi edad " + 32;

            //conversion explicita
            long minumero = 9;
            int elnumero = (int)minumero;

            //conversores
            string possibleInt = "1234";
            int count = Convert.ToInt32(possibleInt);

            miPrimeraClase teresa = new miPrimeraClase();
            teresa.miEdad = 25;
            teresa.funcionSinRetornoNiParametros();
            teresa.funcionNoRetornaConParametro(18);

            miPrimeraClase sofia = new miPrimeraClase();
            sofia = teresa;

            teresa.funcionNoRetornaConParametro(35);

            //linea para escribir en pantalla
            Console.WriteLine("La edad de teresa tiene : " + teresa.funcionRetornaEnterosSinParametros() + " años");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

         

        }
    }
}
