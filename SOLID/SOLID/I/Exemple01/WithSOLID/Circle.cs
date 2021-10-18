using System;

namespace SOLID.I.Exemple01.WithSOLID
{
    class Circle : ISpherical
    {
        public void Area()
        {
            Console.Write("Area: ");
        }

        public void Circumference()
        {
            Console.Write("Circumference: ");
        }       

        public void Radius()
        {
            Console.Write("Radius: ");
        }
    }
}
