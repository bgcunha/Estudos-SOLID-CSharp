using System;

namespace SOLID.L.Exemple01.WithSOLID
{
    class Txtfile : IReadFile, IWriteFile
    {
        public void read()
        {
            Console.Write("Reading...");
        }

        public void write()
        {
            Console.Write("Writing...");
        }
    }
}
