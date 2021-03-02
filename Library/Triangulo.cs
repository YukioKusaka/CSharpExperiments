using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
[assembly:InternalsVisibleTo("ConsoleProject")]

namespace Library
{
    internal class Triangulo : IPoligono
    {
        public int _baseTriangulo;
        public int _altura;
        public double _area;

        public Triangulo(int baseTriangulo, int altura)
        {
            _baseTriangulo = baseTriangulo;
            _altura = altura;
            _area = CalcularArea(baseTriangulo, altura);
        }

        public Triangulo()
        {

        }

        public double CalcularArea()
        {
            var result = (_baseTriangulo * _altura) / 2;
            return result;
        }

        public double CalcularArea(double arg1, double arg2)
        {
            double result = (arg1 * arg2) / 2;
            return result;
        }

        public double GetArea()
        {
            return _area;
        }

        public void test()
        {

        }

    }
}
