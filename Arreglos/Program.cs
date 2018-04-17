using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Declaracion del array unidimensional
            //string[] listaMercado = { "Leche", "Arroz", "Maiz", "Lenteja", "Carne"};

            ////Declaracion del for para concatenar la linea de codigo
            //for (int i = 0; i < listaMercado.Length; i++)
            //{
            //    string concatenar = "";
            //    concatenar +=listaMercado[i] + "," ;
            //    if (listaMercado.Count() == listaMercado.Length) {
            //        //Mostramos la linea concatenada
            //        Console.Write(concatenar);
            //    }
            //}

            string[] lista = { "Leche,", "Arroz,", "Maiz,", "Lenteja,", "Carne" };            
            Console.WriteLine(string.Concat(lista));
            Console.ReadKey();
            
        }

    }
}
