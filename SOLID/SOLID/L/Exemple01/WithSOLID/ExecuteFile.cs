namespace SOLID.L.Exemple01.WithSOLID
{
    class ExecuteFile
    {
        public void Execute(IFile file)
        {
            if (file is IReadFile)
                ((IReadFile)file).read();
            
            if (file is IWriteFile)
                ((IWriteFile)file).write();
            
        }
    }
}
