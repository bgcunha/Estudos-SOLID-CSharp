using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.D.Exemple01.WithoutSOLID
{
    class Payment
    {
        private Employee employee;

        public double GetPaymant()
        {

            return employee.GetAmount();
        }
    }
}
