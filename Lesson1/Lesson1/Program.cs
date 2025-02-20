using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            var account1 = new BankAccount("Petrov", 100000000);
            var account2 = new BankAccount("Garbchev", 50000);

            Console.WriteLine($"Account {account1.Number.Value} was created for {account1.Owner} " +
            $"whih {account1.Balance} initial Balance");

            Console.WriteLine($"Account {account2.Number.Value} was created for {account2.Owner} " +
            $"whih {account2.Balance} initial Balance");
        }
    }
}
