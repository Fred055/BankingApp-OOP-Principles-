namespace BankAccountsApp
{
    public class SavingsAccount : BankAccount
    {

        public decimal InterestRate { get; set; }
        public SavingsAccount(string owner, decimal interestRate) : base(owner + "(" + interestRate + "%)")
        {
            InterestRate = interestRate;

        }

        public override string Deposit(decimal amount)
        {
            if (amount <= 0)

                return "You can not dedposit $" + amount;
            if (amount > 20000)

                return "Aml Deposit Limit Exceeded";

            decimal interestAmount = amount * (InterestRate / 100) * amount;
            Balance += amount + interestAmount;
            return $"Successfully deposited";
        }
    }
}
