using System;

namespace SOLID.O.Exemplo02.WithSOLID
{
    class Circle : AbstractShape
    {
        public double Radios { get; protected set; }
        public override double Area()
        {
            return Radios * Radios * Math.PI;
        }
    }
}
