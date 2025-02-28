using System;
using System.Collections.Generic;
using System.Text;

namespace lesson1.Base
{
    class GiftCardAccount: BankAccount
    {
        public GiftCardAccount(string fullname, decimal intialBalance) :
           base(fullname, intialBalance)
        { }

        public override void PerformMonthEndTransactions()
        {
            MakeWithdrawal(-Balance, DateTime.Now, ";(((");
        }
    }
}
