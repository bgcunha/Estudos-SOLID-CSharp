using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.O.Exemple01.WithoutSOLID
{
    class Doc : File
    {
        public void DocGenerate()
        {
            Console.WriteLine("I generated the doc file.");
        }
    }
}
