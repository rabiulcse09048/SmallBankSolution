namespace SmallBankSolutionOwn
{
    public class Account
    {
        private string accountNumber;
        private string openingDate;
        private double balance;

        public Account()
        {
            balance = 0;
        }
        public Account(string accountNumber,string openingDate)
        {
            this.accountNumber = accountNumber;
            this.openingDate = openingDate;
        }

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public string OpeningDate
        {
            get { return openingDate; }
            set { openingDate = value; }
        }

        public double Balance
        {
            get { return balance; }
        }

        public bool Deposit(double amount)
        {
            balance = balance + amount;
            return true;
        }

        public bool Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance = balance - amount;
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}