namespace Exercise008
{
    using System;
    public class Debt
    {
        public double balance;
        public double interestRate;

        public Debt(double initialBalance, double initialInterestRate)
        {
            this.balance = initialBalance;
            this.interestRate = initialInterestRate;
        }

        public void PrintBalance()
        {
            Console.WriteLine(balance);
        }

        public void WaitOneYear()
        {
            this.balance = balance * interestRate;
        }
    }
}