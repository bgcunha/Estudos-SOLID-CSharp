using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.D.Exemple01.WithSOLID
{
    interface IPayer
    {
        void SetPayable(IPayable payable);
        double GetAmount();
    }
}
