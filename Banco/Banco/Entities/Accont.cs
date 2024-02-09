namespace Banco.Entities
{
    internal class Accont
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balande { get; protected set; }

        
        public Accont() { 
        }

        public Accont(int number, string holder, double balande)
        {
            Number = number;
            Holder = holder;
            Balande = balande;
        }

        public void Withdraw(double amount)
        {
            Balande -= amount;
        }

        public void Deposit(double amount)
        {
            Balande += amount;
        }


    }
}
