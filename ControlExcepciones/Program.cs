using System;

namespace ControlExcepciones
{
    public class ManerjoExcepciones
    {

        public decimal dividirA(decimal numero1, decimal numero2)
        {
            var resultado = numero1 / numero2;
            if (numero2 == 0)
                throw new DivideByZeroException("Error manejo de excepcion");


            return resultado;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*.NET CORE => investigar*/
                int numeroA = 1, numeroB = 0;
                var result = numeroA / numeroB;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message} {ex.TargetSite}{ex.StackTrace}");
            }
            Console.ReadKey();
        }
    }
}
