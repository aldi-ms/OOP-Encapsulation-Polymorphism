namespace Problem_2.Bank_of_Kurtovo_Konare
{
    interface IDeposit
    {
        void Deposit(double deposit);
        double CalculateInterest(int months);
    }
}
