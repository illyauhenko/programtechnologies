using System;
using System.Collections.Generic;
using System.Text;

namespace lesson1.Base
{
    class InterestEarningAccount : BankAccount
    {

        public InterestEarningAccount(string fullname, decimal intialBalance) :
            base(fullname, intialBalance)
        { }

        public override void PerformMonthEndTransactions()
        {
            if (Balance > 500m)
                MakeDeposit(Balance * 0.1m, 
                    DateTime.Now,
                    "apply month interest");

        }
    }
}
