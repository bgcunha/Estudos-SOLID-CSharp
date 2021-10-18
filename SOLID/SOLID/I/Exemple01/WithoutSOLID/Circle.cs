using System;

namespace SOLID.I.Exemple01.WithoutSOLID
{
    class Circle : IPolygon
    {
        public void Area()
        {
            Console.Write("Area: ");
        }

        public void Circumference()
        {
            Console.Write("Circumference: ");
        }

        public void Perimeter()
        {
            Console.Write("Perimeter: ");
        }

        public void Radius()
        {
            Console.Write("Radius: ");
        }
    }
}
