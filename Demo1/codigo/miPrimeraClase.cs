using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.codigo
{
    class miPrimeraClase
    {
        //Variable
        string ColorOjos = "Azules";

        //Propiedad
        public int miEdad { get; set; }

        public Boolean Femenino { get; set; }

        //Función que no retorna nada y no recibe ningun parametro
        public void funcionSinRetornoNiParametros() {
            miEdad = 35;
        }

        //Función que retorna un entero y no recibe parametros
        //retornaEdad
        public int funcionRetornaEnterosSinParametros() {
            return miEdad;
        }

        int meses = 0;

        //Función que retorna un entero y recibe como parametros dos enteros
        //calcularMesesDeEdad
        public int funcionRetornaEnteroConParametros(int _edad, int meses) {
            return _edad * meses;
        }

        //Función que no retorna nada y recibe un parametro
        public void funcionNoRetornaConParametro(int _edad) {
            miEdad = _edad;
        }
    }
}
