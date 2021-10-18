using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.D.Exemple01.WithSOLID
{
    class PaymentService
    {
        private IPayable payable;
        private IPayer payer;

        public PaymentService(IPayable payable, IPayer payer)
        {
            this.payable = payable;
            this.payer = payer;

            this.payer.SetPayable(payable);
        }

        public double Pay()
        {
            var Amount =  payer.GetAmount();
            Console.WriteLine("Payment finalized... Amount {0}", Amount);
            return Amount;
        }

    }
}
