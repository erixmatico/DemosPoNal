using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionesOMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 34;
            DemoMetodos miclase = new DemoMetodos();
            //miclase.EnviarValor(valor);
            miclase.EnviarValorPorReferencia(ref valor);
            //var forceStop = true;
            //int respuesta =  miclase.StopServiceConParametrosOpcionales(forceStop, serviceId: 23);
            string parametroEntrada = "Hola mundo";
            string statusMessage = string.Empty;
            bool isServiceOnline = miclase.IsServiceOnLine(parametroEntrada, out statusMessage);
            if (isServiceOnline) {
                
                Console.WriteLine(miclase.IsServiceOnLine(parametroEntrada, out statusMessage) + ""+ statusMessage);
            }


            //Console.WriteLine("Valor " + miclase.StopServiceConParametrosOpcionales(forceStop, "Edwin"));
            Console.WriteLine("Presione cualquier letra");
            Console.ReadKey();
        }

    }
}
