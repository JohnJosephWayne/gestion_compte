using System;

namespace ConsoleApp_epargne.model
{
    internal class User
    {
        private string name;
        private string accountNumber;
        private int account;
        private int saving;

        public User(string name, string accountNumber)
        {
            this.name = name;
            this.accountNumber = accountNumber;
            this.account = 0;
            this.saving = 0;
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string AccountNumber
        {
            set { accountNumber = value; }
            get { return accountNumber; }
        }

        public int Account
        {
            get { return account; }
            set { account = value; }
        }

        public int Saving
        {
            get { return saving; }
            set { saving = value; }
        }
    }
}
