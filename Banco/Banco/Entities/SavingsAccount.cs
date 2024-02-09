namespace Banco.Entities
{
    class SavingsAccount : Accont
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { 
        }

        public SavingsAccount(int number, string holder, double balande, double interestRate)
            : base(number, holder, balande)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalande()
        {
            Balande += Balande * InterestRate;
        }

    }
}
