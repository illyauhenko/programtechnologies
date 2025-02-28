using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1.ValueObjects
{

    struct Transaction
    {

        public decimal Amount { get; }

        public DateTime Date { get; }

        public string Note { get; }


        public Transaction(decimal amount, DateTime data, string note)
        {
            Amount = amount;
            Date = data;
            Note = note;
        }

        public override string ToString()
        {
            return $"Data: {Date}\tAmount: {Amount}\tNote: {Note}";
        }
    }
}
