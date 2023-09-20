namespace aula135.Entities
{
    class BusinessAcount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAcount() { }

        public BusinessAcount(string holder, double balance, int number, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
