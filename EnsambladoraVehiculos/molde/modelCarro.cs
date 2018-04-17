using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsambladoraVehiculos.molde
{
    // Los enumaradores es una coleccion de constates
    // esto tambien se puede utilizar dentro de la clase
    public enum ColorVehiculo
    {
        Rojo = 2, Gris, Negro, Amarrillo, Azul
    }

    public enum NumeroLlantas : int {
        uno = 1, dos = 2, tres =3, cuatro = 4
    }

    class modelCarro
    {
        // Los enumaradores es una coleccion de constates
        // esto tambien se puede utilizar dentro de la clase
        //public enum ColorVehiculo
        //{
        //    Rojo = 2, Gris, Negro, Amarrillo, Azul
        //}

        public enum MarcaVehiculo {
            Mazda, Chevrolet, Susuki, Aveo
        }

        public modelCarro(int? _numPuertas, NumeroLlantas _numllantas, ColorVehiculo _color, MarcaVehiculo _marca)
        {
            NumPuertas = NumPuertas;
            NumLlantas = _numllantas;
            Color = _color;
            Marca = _marca;
        }

        public modelCarro(int? _numPuertas, NumeroLlantas _numllantas, MarcaVehiculo _marca)
        {
            NumPuertas = NumPuertas;
            NumLlantas = _numllantas;
            Marca = _marca;
        }

        public modelCarro(ColorVehiculo _color)
        {
            Color = _color;
        }

        #region Propiedades

        public int? NumPuertas { get; set; }

        public NumeroLlantas NumLlantas { get; set; }

        public ColorVehiculo Color { get; set; }

        public int Velocidad { get; set; }

        public MarcaVehiculo Marca { get; set; }
        #endregion

        #region MyRegion
        /// <summary>
        /// Este metodo me controla la velocidad cuando frena
        /// </summary>
        public void Frenar(int _presionPedalFreno)
        {
            if (_presionPedalFreno > 0) {
                try
                {
                    Velocidad = _presionPedalFreno / 0;
                }
                catch (Exception ex)
                {
                    //Console.WriteLine("Error " + ex.Message);
                    throw new DivideByZeroException("errorNojoda" + ex);
                }
               
            }
        }

        /// <summary>
        /// Este metodo me controla la velocidad cuando acelera
        /// </summary>
        public void Acelerar(int _presionarPedalAcelerar)
        {
            if (_presionarPedalAcelerar > 0) {
                Velocidad = _presionarPedalAcelerar * 2;
                Velocidad = 0;
            }
        }

        #endregion
    }
}
