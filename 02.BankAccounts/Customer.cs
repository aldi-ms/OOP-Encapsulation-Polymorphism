namespace Problem_2.Bank_of_Kurtovo_Konare
{
    using System;

    public abstract class CustomerBase : IDeposit
    {
        public string Customer { get; set; }
        public double Balance { get; set; }
        public double InterestRate { get; set; }

        public CustomerBase(string customer, double balance, double interestRate)
        {
            if (customer != "individual" && customer != "company")
            {
                throw new ArgumentException("The customer must be individual or company");
            }
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public virtual void Deposit(double deposit)
        {
            if (deposit < 0)
            {
                throw new ArgumentException("The deposit must be positive!");
            }
            this.Balance += deposit;
        }

        public virtual double CalculateInterest(int months)
        {
            return 0;
        }

        public override string ToString()
        {
            return string.Format("{0}   Customer: {1}    Balance: {2}   Interest Rate: {3}\n",
    this.GetType().Name, this.Customer, this.Balance, this.InterestRate);
        }
    }
}
