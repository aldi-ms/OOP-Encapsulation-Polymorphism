namespace Problem_2.Bank_of_Kurtovo_Konare
{
    using System;

    class TestBank
    {
        static void Main()
        {
            DepositCustomer deposit = new DepositCustomer("company", 1000, 2);
            LoanAccount loan = new LoanAccount("individual", 1000, 2);
            Mortgage mortgage = new Mortgage("company", 1000, 2);

            Console.WriteLine(deposit);
            Console.WriteLine(loan);
            Console.WriteLine(mortgage);

            deposit.Withdraw(123.3);
            Console.WriteLine(deposit);  // работи

            deposit.Deposit(123.3);
            Console.WriteLine(deposit);// работи

            loan.Deposit(1233);
            Console.WriteLine(loan);// работи

            Console.WriteLine(loan.CalculateInterest(12));// работи


        }
    }
}
