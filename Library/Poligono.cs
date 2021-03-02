using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    abstract class Poligono
    {
        public int _numeroDeLados;
        public double _area;
        string _tipo;

        public abstract double CalcularArea();

        public abstract double CalcularArea(double arg1, double arg2);

        public abstract double GetArea();

        private double CalcularArea_1()
        {
            return _area;
        }
    }
}
