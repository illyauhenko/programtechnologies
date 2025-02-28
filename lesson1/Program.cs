using lesson1.Base;
using System;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            var account1 = new InterestEarningAccount("Petrov", 100000000);
            var account2 = new LineOfCreditAccount("Garbchev", 50000);

            Console.WriteLine($"Account {account1.Number.Value} was created for {account1.Owner} " +
            $"whih {account1.Balance} initial Balance");

            Console.WriteLine($"Account {account2.Number.Value} was created for {account2.Owner} " +
            $"whih {account2.Balance} initial Balance");

            try
            {
                account1.MakeWithdrawal(100000m, DateTime.Now, "затроллили хехе");
                account2.MakeDeposit(-100m, DateTime.Now, "asdasd");

            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message, e.ParamName, e.ToString());
            }

            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message, e.ToString());
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message, e.ToString()); 
            }
            finally
            {
                Console.WriteLine("выполняется всегда");

            }
        }
    }
}