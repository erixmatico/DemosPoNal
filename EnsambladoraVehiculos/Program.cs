using EnsambladoraVehiculos.molde;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsambladoraVehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            int? numeroPuertas = null;
            modelCarro elTercerCarro = new modelCarro(numeroPuertas, NumeroLlantas.cuatro,ColorVehiculo.Negro, (modelCarro.MarcaVehiculo)2);

            modelCarro elCuartoCarro = new modelCarro(2,NumeroLlantas.cuatro, (modelCarro.MarcaVehiculo)2);

            elCuartoCarro.Color = (ColorVehiculo)5;

            modelCarro elQuintoCarro = new modelCarro(ColorVehiculo.Negro);                
            
            Console.WriteLine(elQuintoCarro.Color);
            elCuartoCarro.Frenar(5);
            Console.WriteLine(elTercerCarro.Marca + " El numero de llantas es: "+ elTercerCarro.NumLlantas);
            Console.ReadKey();

        }
               
        public static int acelerar(int _presionPedal)
        {
            if (_presionPedal > 0)
                return _presionPedal * 2;
            return 0;
        }
    }
}
