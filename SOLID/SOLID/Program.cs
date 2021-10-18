using System;
using System.Collections.Generic;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("******SOLID******\n");

            ////Exemple01 'O'
            //O.Exemple01.WithSOLID.Doc doc = new O.Exemple01.WithSOLID.Doc();
            //O.Exemple01.WithSOLID.PDF pdf = new O.Exemple01.WithSOLID.PDF();
            //O.Exemple01.WithSOLID.TXT txt = new O.Exemple01.WithSOLID.TXT();

            //List<O.Exemple01.WithSOLID.File> fileList = new List<O.Exemple01.WithSOLID.File>();

            //fileList.Add(doc);
            //fileList.Add(pdf);
            //fileList.Add(txt);

            //Console.WriteLine("Exemple01 'O'\n");
            //O.Exemple01.WithSOLID.FileManeger fm = new O.Exemple01.WithSOLID.FileManeger();
            //fm.GenerateFile(fileList);

            ////Exemple02 'O'
            //O.Exemplo02.WithSOLID.Rectangle rectangle = new O.Exemplo02.WithSOLID.Rectangle();
            //O.Exemplo02.WithSOLID.Circle circle = new O.Exemplo02.WithSOLID.Circle();
            //O.Exemplo02.WithSOLID.AreaCalculator areaCalculator = new O.Exemplo02.WithSOLID.AreaCalculator();
            //O.Exemplo02.WithSOLID.AbstractShape[] arr = new O.Exemplo02.WithSOLID.AbstractShape[2];

            //rectangle.Height = 10;
            //rectangle.Width = 5;

            //circle.Radios = 3;

            //arr[0] = rectangle;
            //arr[1] = circle;
            //Console.WriteLine("\n\nExemple02 'O'");
            //Console.WriteLine("\nTotal Area is: "+ areaCalculator.TotalArea( arr ).ToString("F2"));

            ////Exemple01 'l'
            //L.Exemple01.WithSOLID.ExecuteFile exeFile = new L.Exemple01.WithSOLID.ExecuteFile();
            //L.Exemple01.WithSOLID.IWriteFile writeFile = new L.Exemple01.WithSOLID.WriteFile();
            //L.Exemple01.WithSOLID.IReadFile readOnlyFile = new L.Exemple01.WithSOLID.ReadOnlyFile();
            //L.Exemple01.WithSOLID.IFile txtfile = new L.Exemple01.WithSOLID.Txtfile();


            //exeFile.Execute(writeFile);
            //exeFile.Execute(readOnlyFile);
            //exeFile.Execute(txtfile);

            double amount = 4987.89;
            double percentCommisiion = 5;
            double commission = amount * (percentCommisiion / 100);

            D.Exemple01.WithSOLID.IPayable payable = new D.Exemple01.WithSOLID.Employee(amount, commission );
            D.Exemple01.WithSOLID.IPayer payer = new D.Exemple01.WithSOLID.Payment();
                        
            payer.SetPayable(payable);

            D.Exemple01.WithSOLID.PaymentService paymentService = new D.Exemple01.WithSOLID.PaymentService(payable, payer);

            paymentService.Pay();

            Console.ReadKey();
        }
    }
}
