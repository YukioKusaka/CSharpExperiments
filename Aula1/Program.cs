using System;
using Library;


namespace ConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo1 = new Triangulo(9, 10);

            Triangulo triangulo2 = new Triangulo(5,10);
            Triangulo triangulo3 = new Triangulo(7, 8);

            Retangulo retangulo1;
            retangulo1 = new Retangulo();
            
            Retangulo retangulo2;
            retangulo2 = new Retangulo(10, 50);

            double areaRetangulo = retangulo2.GetArea();

            double areaRetangulo2 = retangulo2._area;
            
            double area2 = triangulo2.CalcularArea();

            double areaTriangulo = triangulo1.CalcularArea(10, 20);            

            Console.WriteLine(areaRetangulo);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
