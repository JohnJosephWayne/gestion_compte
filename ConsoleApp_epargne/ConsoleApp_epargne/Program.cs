using System;
using ConsoleApp_epargne.model;
using ConsoleApp_epargne.service;

namespace ConsoleApp_epargne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("John Doe", "123456789");
            AccountGestion accountGestion = new AccountGestion(user);

            int choice;

            do
            {
                DisplayMenu();
                Console.Write("Entrez votre choix : ");
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Veuillez entrer un numéro valide.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Entrez le montant à déposer sur le compte : ");
                        if (int.TryParse(Console.ReadLine(), out int depositAccountAmount))
                        {
                            accountGestion.DepositAccount(depositAccountAmount);
                        }
                        else
                        {
                            Console.WriteLine("Montant invalide.");
                        }
                        break;

                    case 2:
                        Console.Write("Entrez le montant à retirer du compte : ");
                        if (int.TryParse(Console.ReadLine(), out int removalAccountAmount))
                        {
                            accountGestion.RemovalAccount(removalAccountAmount);
                        }
                        else
                        {
                            Console.WriteLine("Montant invalide.");
                        }
                        break;

                    case 3:
                        accountGestion.CheckAccount();
                        break;

                    case 4:
                        Console.Write("Entrez le montant à déposer sur l'épargne : ");
                        if (int.TryParse(Console.ReadLine(), out int depositSavingAmount))
                        {
                            accountGestion.DepositSaving(depositSavingAmount);
                        }
                        else
                        {
                            Console.WriteLine("Montant invalide.");
                        }
                        break;

                    case 5:
                        Console.Write("Entrez le montant à retirer de l'épargne : ");
                        if (int.TryParse(Console.ReadLine(), out int removalSavingAmount))
                        {
                            accountGestion.RemovalSaving(removalSavingAmount);
                        }
                        else
                        {
                            Console.WriteLine("Montant invalide.");
                        }
                        break;

                    case 6:
                        accountGestion.CheckSaving();
                        break;

                    case 7:
                        Console.WriteLine(user.Name);
                        Console.WriteLine(user.AccountNumber);
                        break;

                    case 8:
                        Console.WriteLine("Programme terminé. À bientôt !");
                        break;

                    default:
                        Console.WriteLine("Choix invalide, veuillez réessayer.");
                        break;
                }
            } while (choice != 8);
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1. Déposer sur le compte");
            Console.WriteLine("2. Retirer du compte");
            Console.WriteLine("3. Vérifier le solde du compte");
            Console.WriteLine("4. Déposer sur l'épargne");
            Console.WriteLine("5. Retirer de l'épargne");
            Console.WriteLine("6. Vérifier le solde de l'épargne");
            Console.WriteLine("7. Information du compte");
            Console.WriteLine("8. Quitter");
            Console.WriteLine("============");
        }
    }
}
