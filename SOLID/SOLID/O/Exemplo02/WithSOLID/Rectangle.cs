
namespace SOLID.O.Exemplo02.WithSOLID
{
    class Rectangle : AbstractShape
    {
        public double Height { get; protected set; }
        public double Width { get; protected set; }

        public override double Area()
        {
            return Height * Width;
        }
    }
}
