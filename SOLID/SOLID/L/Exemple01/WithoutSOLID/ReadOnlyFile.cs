using System;

namespace SOLID.L.Exemple01.WithoutSOLID
{
    class ReadOnlyFile : File
    {
        public override void write()
        {
            throw new NotImplementedException();
        }

        public override void read()
        {
            Console.Write("Reading...");
        }
    }
}
