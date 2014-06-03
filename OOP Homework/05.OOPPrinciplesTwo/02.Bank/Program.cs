// 02. A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
// Customers could be individuals or companies.	All accounts have customer, balance and interest rate (monthly based). 
// Deposit accounts are allowed to deposit and with draw money. Loan and mortgage accounts can only deposit money.
// All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as 
// follows: number_of_months * interest_rate.
// Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
// Deposit accounts have no interest if their balance is positive and less than 1000. Mortgage accounts have ½ interest for the first 
// 12 months for companies and no interest for the first 6 months for individuals.  Your task is to write a program to model the bank 
// system by classes and interfaces. You should identify the classes, interfaces, base classes and abstract actions and implement 
// the calculation of the interest functionality through overridden methods.

namespace Bank
{
    using System;

    public class Program
    {
        static void TestInterest(Account account, int months = 12)
        {
            Console.WriteLine(account.Customer);

            for (int i = 1; i <= months; i++)
            {
                Console.WriteLine(account.CalculateInterest(i));
            }

            Console.WriteLine();
        }

        static void Main()
        {
            Console.WriteLine("#Bank Name#");

            Console.WriteLine(
                new Bank("UBB").AddAccount(
                new DepositAccount(
                    new CompanyCustomer("Coca Cola"), 0, 0.1M).Deposit(150).Withdraw(50),
                new LoanAccount(
                    new IndividualCustomer("Murdjo"), 50, 0.07M).Withdraw(20),
                new MortgageAccount(
                    new IndividualCustomer("Gurdjo"), 0, 0.05M)));

            Console.WriteLine("# Calculate Loan account interest");
            TestInterest(new LoanAccount(
                new IndividualCustomer("Tony Montana"), 100, 0.1M));
            TestInterest(new LoanAccount(
                new CompanyCustomer("Microsoft"), 100, 0.1M));

            Console.WriteLine("# Calculate Deposit account interest");
            TestInterest(new DepositAccount(
                new IndividualCustomer("Tony Montana"), 1000, 0.1M));
            TestInterest(new DepositAccount(
                new CompanyCustomer("Microsoft"), 100, 0.1M));

            Console.WriteLine("# Calculate Mortgage account interest");
            TestInterest(new MortgageAccount(
                new IndividualCustomer("Tony Montana"), 100, 0.1M));
            TestInterest(new MortgageAccount(
                new CompanyCustomer("Microsoft"), 100, 0.1M), months: 13);
        }
    }
}