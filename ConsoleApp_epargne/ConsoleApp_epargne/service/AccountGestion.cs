using ConsoleApp_epargne.model;

namespace ConsoleApp_epargne.service
{
    internal class AccountGestion
    {
        private User user;

        public AccountGestion(User user)
        {
            this.user = user;
        }

        public void DepositAccount(int amount)
        {
            if (amount > 0)
            {
                user.Account += amount;
                Console.WriteLine($"Added {amount} to the account. New balance: {user.Account}");
            }
            else
            {
                Console.WriteLine("Amount must be greater than zero.");
            }
        }

        public void CheckAccount()
        {
            Console.WriteLine($"Current account balance: {user.Account}");
        }

        public void DepositSaving(int amount)
        {
            if (amount > 0)
            {
                user.Saving += amount;
                Console.WriteLine($"Added {amount} to the account. New balance: {user.Account}");
            }
            else
            {
                Console.WriteLine("Amount must be greater than zero.");
            }
        }

        public void RemovalAccount(int amount)
        {
            if (amount < 0)
            {
                user.Account -= amount;
                Console.WriteLine($"Added {amount} to the account. New balance: {user.Account}");
            }
            else
            {
                Console.WriteLine("Amount must be greater than zero.");
            }
        }
        public void RemovalSaving(int amount)
        {
            if (amount < 0)
            {
                user.Saving -= amount;
                Console.WriteLine($"Added {amount} to the account. New balance: {user.Account}");
            }
            else
            {
                Console.WriteLine("Amount must be greater than zero.");
            }
        }
        public void CheckSaving()
        {
            Console.WriteLine($"Current account balance: {user.Saving}");
        }
    }
}
