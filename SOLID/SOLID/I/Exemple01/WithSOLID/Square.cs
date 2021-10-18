using System;

namespace SOLID.I.Exemple01.WithSOLID
{
    class Square : INoSpherical
    {
        public void Area()
        {
            Console.Write("Area: ");
        }       

        public void Perimeter()
        {
            Console.Write("Perimeter: ");
        }
       
    }
}
