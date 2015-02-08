namespace Problem_2.Bank_of_Kurtovo_Konare
{
    using System;

    class Mortgage : CustomerBase
    {
        public Mortgage(string customer, double balance, double interestRate)
            : base(customer, balance, interestRate)
        {
            if (customer != "individual" && customer != "company")
            {
                throw new ArgumentException("Customer must be individual or company");
            }
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public override void Deposit(double deposit)
        {
            if (deposit < 0)
            {
                throw new ArgumentException("The deposit must be positive!");
            }
            this.Balance += deposit;
        }

        public override double CalculateInterest(int months)
        {
            if (this.Customer == "individual" && months < 6)
            {
                return 0;
            }
            if (this.Customer == "company" && months < 12)
            {
                return (this.Balance * (1 + this.InterestRate * months))/2;
            }
            return this.Balance * (1 + this.InterestRate * months);
        }
    }
}
