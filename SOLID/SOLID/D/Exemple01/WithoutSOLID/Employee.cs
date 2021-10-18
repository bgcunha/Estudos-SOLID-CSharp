using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.D.Exemple01.WithoutSOLID
{
    class Employee
    {
        public double Salary { get;  set; }
        public double Commissinon { get; set; }
        public string Position { get; set; }

        public double GetAmount()
        {
            return Salary + Commissinon;
        }        

        public double GetComission()
        {
            return Commissinon;
        }

        public string GetPosition()
        {
            return Position;

        }


    }
}
