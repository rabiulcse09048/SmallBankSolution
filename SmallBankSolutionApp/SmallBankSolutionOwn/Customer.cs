namespace SmallBankSolutionOwn
{
    public class Customer
    {
        private string customerName;
        private string customerEmail;
        private Account customerAccount = null;


        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value;}
        }

        public string CustomerEmail
        {
            get { return customerEmail; }
            set { customerEmail = value; }
        }

        public Account CustomerAccount
        {
            get { return customerAccount; }
            set { customerAccount = value; }
        }

    }
}