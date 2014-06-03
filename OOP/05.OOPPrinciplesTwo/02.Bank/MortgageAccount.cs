namespace Bank
{
    using System;

    public class MortgageAccount : Account
    {
        // constructor
        public MortgageAccount(Customer customer, decimal balance, decimal interest) : base(customer, balance, interest)
        {
        }

        // override method for interest calculation
        public override decimal CalculateInterest(decimal months)
        {
            // interest calculation depends of customer type
            if (this.Customer is IndividualCustomer) 
            {
                return base.CalculateInterest(months - 6);
            }

            if (this.Customer is CompanyCustomer)
            {
                return base.CalculateInterest(Math.Min(months, 12) / 2 + Math.Max(months - 12, 0));
            }

            return base.CalculateInterest(months);
        }

        // printing
        public override string ToString()
        {
            return base.ToString("Mortgage Account");
        }
    }
}