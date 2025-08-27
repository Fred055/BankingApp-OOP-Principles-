namespace BankAccountsApp
{
    public class BankAccount
    {
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; protected set; }

        public BankAccount(string owner)
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0; // Initial balance is set to 0

        }

        public virtual string Deposit(decimal amount)
        {
            if (amount <= 0)

                return "You can not dedposit $" + amount;
            if (amount > 20000)

                return "Aml Deposit Limit Exceeded";

            Balance += amount;
            return $"Successfully deposited";
        }

        public string Withdraw(decimal amount)
        {
            if (amount <= 0)

                return "You can not withdraw $" + amount;

            if (amount > Balance)

                return "You don't have enough money";

            Balance -= amount;
            return $"Withdraw successfully completed ";
        }
    }
}
