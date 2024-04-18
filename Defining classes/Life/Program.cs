using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace Life
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Person firstPerson = new Person();
            firstPerson.Name = "Denis";
            firstPerson.Age = 25;*/

            /* BankAccount account = new BankAccount();
             account.Id = int.Parse(Console.ReadLine());
             account.Balance = double.Parse(Console.ReadLine());
             Console.WriteLine($"Account {account.Id}, balance {account.Balance}");*/

            /*BankAccount account = new BankAccount();
            account.Id = 1;

            account.Deposit(15);
            account.Withdraw(5);

            Console.WriteLine(account.ToString());*/

            Dictionary<int, BankAccount> bankAccountsById = new Dictionary<int, BankAccount>();

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] commandData = command.Split();
                string commandName = commandData[0];
                int bankAccountId = int.Parse(commandData[1]);

                if (commandName == "Create")
                {
                    if (bankAccountsById.ContainsKey(bankAccountId))
                    {
                        Console.WriteLine("Account already exists");
                    }
                    else
                    {
                        BankAccount newAccount = new BankAccount();
                        newAccount.Id = bankAccountId;
                        bankAccountsById[newAccount.Id] = newAccount;
                    }
                }
                else
                {
                    if (!bankAccountsById.ContainsKey(bankAccountId))
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    else
                    {
                        BankAccount requestedAccount = bankAccountsById[bankAccountId];

                        if (commandName == "Deposit")
                        {
                            double amount = double.Parse(commandData[2]);
                            requestedAccount.Deposit(amount);
                        }
                        else if (commandName == "Withdraw")
                        {
                            double amount = double.Parse(commandData[2]);
                            if (amount > requestedAccount.Balance)
                            {
                                Console.WriteLine("Insufficient balance");
                            }
                            else
                            {
                                requestedAccount.Withdraw(amount);
                            }
                        }
                        else if (commandName == "Print")
                        {
                            Console.WriteLine(requestedAccount);
                        }
                    }
                }

                command = Console.ReadLine();
            }
            /* Input:
             Create 1
             Create 2
             Deposit 1 20
             Withdraw 1 30
             Withdraw 1 10
             Print 1
             End

             Output:
             Insufficient balance
             Account ID1, balance 10.00 */
        }
    }
}
