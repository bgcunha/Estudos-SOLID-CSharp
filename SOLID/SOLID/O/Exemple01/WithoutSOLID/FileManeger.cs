using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.O.Exemple01.WithoutSOLID
{
    class FileManeger
    {
        public void GenerateFile(List<File> FileList)
        {
            foreach (var file in FileList)
            {
                if (file is Doc)
                {
                    ((Doc)file).DocGenerate();
                }
                else if (file is PDF)
                {
                    ((PDF)file).PDFGenerate();
                }///More if... one check for each type
            }
        }
    }
}
