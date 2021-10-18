using System;

namespace SOLID.O.Exemple01.WithSOLID
{
    class TXT : File
    {
        public override void Generate()
        {
            Console.WriteLine("I generated the TXT file.");
        }
    }
}
