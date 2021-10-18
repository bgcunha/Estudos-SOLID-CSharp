using System;

namespace SOLID.O.Exemple01.WithSOLID
{
    class PDF : File
    {
        public override void Generate()
        {
            Console.WriteLine("I generated the PDF file.");
        }
    }
}
