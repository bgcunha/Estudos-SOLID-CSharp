using System.Collections.Generic;


namespace SOLID.O.Exemple01.WithSOLID
{
    class FileManeger
    {
        public void GenerateFile(List<File> FileList)
        {
            foreach (var file in FileList)
            {
                ((File)file).Generate();               
            }
        }
    }
}
