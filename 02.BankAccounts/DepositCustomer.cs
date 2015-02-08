namespace Problem_2.Bank_of_Kurtovo_Konare
{
    using System;

    class DepositCustomer : CustomerBase, IWithdraw, IDeposit
    {
        public DepositCustomer(string customer, double balance, double interestRate) 
            : base(customer, balance, interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public void Withdraw(double withDraw)
        {
            if (withDraw < 0)
            {
                throw new ArgumentException("Withdraw cannot be negative!");
            }
            this.Balance -= withDraw;
        }
        public override double CalculateInterest(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }
            return this.Balance * (1 + this.InterestRate * months);
        }
    }
}
