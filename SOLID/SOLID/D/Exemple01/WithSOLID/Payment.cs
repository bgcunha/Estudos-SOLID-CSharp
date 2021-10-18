
namespace SOLID.D.Exemple01.WithSOLID
{
    class Payment : IPayer
    {        

        private IPayable payable;

        public void SetPayable(IPayable payable)
        {
            this.payable = payable;
        }       

        public double GetAmount()
        {
            return payable.GetAmount();
        }               

    }
}
