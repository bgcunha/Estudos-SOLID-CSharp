using System;

namespace SOLID.I.Exemple01.WithoutSOLID
{
    class Square : IPolygon
    {
        public void Area()
        {
            Console.Write("Area: ");
        }

        public void Circumference()
        {
            throw new NotImplementedException();
        }

        public void Perimeter()
        {
            Console.Write("Perimeter: ");
        }

        public void Radius()
        {
            throw new NotImplementedException();
        }
    }
}
