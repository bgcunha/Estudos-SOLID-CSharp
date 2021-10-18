
namespace SOLID.D.Exemple01.WithSOLID
{
    class Employee : IPayable
    {
        public Employee(double amount)
        {
            Amount = amount;
        }

        public Employee(double amount, double commissinon)
        {
            Amount = amount;
            Commissinon = commissinon;
        }
       
        public double Amount { get; protected set; }
        public double Commissinon { get; protected set; }        

        

        public double GetAmount()
        {
            return Amount + Commissinon;
        }       
        
        public double GetComission()
        {
            return Commissinon;
        }

    }
}
