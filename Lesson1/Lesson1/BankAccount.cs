using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson1.ValueObjects;
namespace Lesson1
{
    class BankAccount
    {
        private List<Transaction> _allTransaction = new List<Transaction>();
        private static NumberBankAccount s_accountNumberSeed = new(1000000000);

        public NumberBankAccount Number { get; }
        public string Owner { get; private set; }


        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in _allTransaction)
                {
                    balance = item.Amount;
                }
                return balance;
            }
        }



        public BankAccount(string fullname, decimal intialBalance)
        {
            Number = s_accountNumberSeed
                ;
            s_accountNumberSeed.Value++;
            Owner = fullname;


            MakeDeposit(intialBalance, DateTime.Now, "in. balance ");
         

        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must positive");
            var deposit = new Transaction(amount, date, note);
            _allTransaction.Add(deposit);


        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must positive");
            if (amount >= 0)
                throw new InvalidOperationException("no money");
            _allTransaction.Add(new Transaction(-amount,date,note));
                       
        }
    }
}
