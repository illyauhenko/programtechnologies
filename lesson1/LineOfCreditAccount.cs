using System;
using System.Collections.Generic;
using System.Text;

namespace lesson1.Base
{
    class LineOfCreditAccount: BankAccount
    {
        public LineOfCreditAccount(string fullname, decimal intialBalance) :
           base(fullname, intialBalance)
        { }

        public override void PerformMonthEndTransactions()
        {
            if (Balance < 0)
                MakeWithdrawal(Balance * 0.2m, DateTime.Now, "Charge monthly interest");
        }
    }
}
