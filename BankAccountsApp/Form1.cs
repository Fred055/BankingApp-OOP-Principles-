namespace BankAccountsApp
{
    public partial class Form1 : Form
    {
        List<BankAccount> BankAccounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();

            // Past Version Below
            //BankAccount bankAccount = new BankAccount("Farid Jafarli");
            /*bankAccount.Owner = "Farid Jafarli";
            bankAccount.AccountNumber = Guid.NewGuid();
            bankAccount.Balance = 1000000;*/


            //BankAccount bankAccount2 = new BankAccount("Donald Trump");
            /*bankAccount2.Owner = "Donald Trump";
            bankAccount2.AccountNumber = Guid.NewGuid();
            bankAccount2.Balance = 100000000;*/

            // BankAccount bankAccount3 = new BankAccount("Bill Gates");
            /* bankAccount3.Owner = "Bill Gates";
             bankAccount3.AccountNumber = Guid.NewGuid();
             bankAccount3.Balance = 150;*/

            //BankAccount bankAccount4 = new BankAccount("Warren Buffet");


            //List<BankAccount> bankAccounts = new List<BankAccount>();
            /*bankAccounts.Add(bankAccount);
            bankAccounts.Add(bankAccount2);
            bankAccounts.Add(bankAccount3);
            bankAccounts.Add(bankAccount4);*/


            //BanksAccountsGrid.DataSource = bankAccounts;

        }

        private void CreateButtonBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(OwnerTxt.Text))
            {
                MessageBox.Show("Please enter an owner name.");
                return;
            }


            if (InterestRateNum.Value > 0)
                BankAccounts.Add(new SavingsAccount(OwnerTxt.Text, InterestRateNum.Value));

            else
                BankAccounts.Add(new BankAccount(OwnerTxt.Text));




            Refreshgrid();
            OwnerTxt.Text = "";
            InterestRateNum.Value = 0;
        }

        private void Refreshgrid()
        {
            BanksAccountsGrid.DataSource = null; // Clear the current data source
            BanksAccountsGrid.DataSource = BankAccounts; // Set the new data source
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if (BanksAccountsGrid.SelectedRows.Count == 1)
            {
                BankAccount selectedBankAccount = BanksAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;

                string message = selectedBankAccount.Deposit(AmountNum.Value);
                Refreshgrid();
                AmountNum.Value = 0;
                MessageBox.Show(message);

            }
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            if (BanksAccountsGrid.SelectedRows.Count == 1)
            {
                BankAccount selectedBankAccount = BanksAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;

                string message = selectedBankAccount.Withdraw(AmountNum.Value);
                Refreshgrid();
                AmountNum.Value = 0;
                MessageBox.Show(message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
