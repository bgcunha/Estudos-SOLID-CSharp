using System;

namespace SOLID.L.Exemple01.WithoutSOLID
{
    class TxtFile : File
    {

        public override void read()
        {
            Console.Write("Reanding...");
        }

        public override void write()
        {
            Console.Write("Writing...");
        }

        
    }
}
