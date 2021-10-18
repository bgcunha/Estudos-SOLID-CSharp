

namespace SOLID.L.Exemple01.WithoutSOLID
{
    class ExecuteFile
    {
        public void Execute(File file)
        {
            if (file is ReadOnlyFile)
            {
                file.read();
            }
            else
            {
                file.read();
                file.write();
            }
        }
    }
}
