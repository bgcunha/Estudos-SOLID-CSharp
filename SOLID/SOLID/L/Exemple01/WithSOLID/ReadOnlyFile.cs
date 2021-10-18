using System;

namespace SOLID.L.Exemple01.WithSOLID
{
    class ReadOnlyFile : IReadFile
    {
        public void read()
        {
            Console.Write("Reading...");
        }
    }
}
