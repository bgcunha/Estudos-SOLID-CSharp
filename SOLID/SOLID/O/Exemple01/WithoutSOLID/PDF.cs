using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.O.Exemple01.WithoutSOLID
{
    class PDF : File
    {
        public void PDFGenerate()
        {
            Console.WriteLine("I generated the PDF file.");
        }
    }
}
