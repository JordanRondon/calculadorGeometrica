using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraGeometrica
{
    internal class Cuadrilatero
    {
        public float baseCuadrilatero { set; get; }
        public float alturaCuadrilatero { set; get; }

        public Cuadrilatero()
        {

        }

        public Cuadrilatero(float baseCuadrilatero, float alturaCuadrilatero)
        {
            this.baseCuadrilatero = baseCuadrilatero;
            this.alturaCuadrilatero = alturaCuadrilatero;
        }

        public float area()
        {
            return baseCuadrilatero * alturaCuadrilatero;
        }

        public float perimetro()
        {
            return baseCuadrilatero * 2 + alturaCuadrilatero * 2;
        }
    }
}
