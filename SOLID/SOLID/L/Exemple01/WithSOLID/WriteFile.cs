using System;

namespace SOLID.L.Exemple01.WithSOLID
{
    class WriteFile : IWriteFile
    {
        public void write()
        {
            Console.Write("Writing...");
        }    
    }
}
