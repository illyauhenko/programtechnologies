using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.ValueObjects
{
    struct NumberBankAccount
    {
        public int Value { get; set; }

        public NumberBankAccount(int number)
        {
            if (number < 1000000000 || number >= 10000000000)
                throw new System.ArgumentOutOfRangeException(nameof(number), "ты ошибка!");

            Value = number;
        }

    }
}
