
namespace SOLID.O.Exemplo02.WithSOLID
{
    class AreaCalculator
    {
        public double TotalArea(AbstractShape[] arrShapes)
        {
            double area = 0;
            foreach (var objShaphes in arrShapes)
            {
                area += objShaphes.Area();
            }
            return area;
        }
    }
}
