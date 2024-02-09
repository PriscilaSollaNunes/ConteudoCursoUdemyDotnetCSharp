namespace Banco.Entities
{
    internal class BusinessAccount : Accont
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balande, double LoanLimit) : base(number, holder, balande)
        {
            LoanLimit = LoanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balande += amount;
            }
        }

    }
}
