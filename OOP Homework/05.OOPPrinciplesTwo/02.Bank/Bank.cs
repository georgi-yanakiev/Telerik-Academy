namespace Bank
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Bank
    {
        // account list
        private readonly List<Account> accounts = new List<Account>();

        // property
        public string Name { get; private set; }

        // constructor
        public Bank(string name)
        {
            this.Name = name;
        }

        // adding accounts method
        public Bank AddAccount(params Account[] accounts)
        {
            foreach (Account account in accounts)
            {
                this.accounts.Add(account);
            }

            return this;
        }

        // remove account method
        public Bank RemoveAccout(Account account)
        {
            this.accounts.Remove(account);

            return this;
        }

        // printing bank info
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.AppendLine("Bank: " + this.Name);

            foreach (Account account in accounts)
            {
                info.AppendLine(account.ToString());
            }

            return info.ToString();
        }
    }
}