namespace Bank
{
    using System;

    public class LoanAccount : Account
    {
        // constructor
        public LoanAccount(Customer customer, decimal balance, decimal interest) : base(customer, balance, interest)
        {
        }

        // overrided method for interest calculation
        public override decimal CalculateInterest(decimal months)
        {
            // interest calculation depends of customer type
            if (this.Customer is IndividualCustomer)
            {
                return base.CalculateInterest(months - 3);
            }

            if (this.Customer is CompanyCustomer)
            {
                return base.CalculateInterest(months - 2);
            }

            return base.CalculateInterest(months);
        }

        // printing
        public override string ToString()
        {
            return base.ToString("Loan Account");
        }
    }
}