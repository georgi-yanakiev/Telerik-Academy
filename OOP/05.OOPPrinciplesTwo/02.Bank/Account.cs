namespace Bank
{
    using System;
    using System.Collections.Generic;

    public abstract class Account
    {
        // account properties
        public Customer Customer { get; protected set; }

        public decimal Balance { get; protected set; }

        public decimal InterestRate { get; protected set; }

        // account constructor
        public Account(Customer customer, decimal balance, decimal interest)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interest;
        }

        // withdraw method
        public Account Withdraw(decimal amount)
        {
            this.Balance -= amount;

            return this;
        }

        // interest calculation
        public virtual decimal CalculateInterest(decimal months)
        {
            if (!(months > 0))
            {
                return 0;
            }

            return this.Balance * this.InterestRate * months;
        }

        // printing account info
        public string ToString(string type)
        {
            List<string> info = new List<string>();

            info.Add(String.Empty); // Add empty line
            info.Add("Type: " + type);
            info.Add("Customer: ");
            info.Add(this.Customer.ToString());
            info.Add("Balance: " + this.Balance);
            info.Add("Interest rate: " + this.InterestRate);

            return String.Join(Environment.NewLine, info);
        }
    }
}