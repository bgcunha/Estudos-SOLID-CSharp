using System;

namespace SOLID.O.Exemple01.WithSOLID
{
    class Doc : File
    {
        public override void Generate()
        {
            Console.WriteLine("I generated the doc file.");
        }
    }
}
