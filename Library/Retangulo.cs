using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    internal class Retangulo : IPoligono
    {
        public double _lado1;
        public double _lado2;
        public double _area;

        public Retangulo(double lado1, double lado2)
        {
            _lado1 = lado1;
            _lado2 = lado2;
            _area = CalcularArea(lado1, lado2);
        }

        public Retangulo()
        {

        }

        public double CalcularArea()
        {
            double result = _lado1 * _lado2;
            return result;
        }

        public double CalcularArea(double arg1, double arg2)
        {
            double result = arg1 * arg2;
            return result;
        }

        public double GetArea()
        {
            return _area;
        }   
    }    
}
