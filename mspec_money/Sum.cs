using System;

namespace mspec_money
{
    public class Sum: Expression {
        private readonly Money _augend;
        private readonly Money _addend;
        public Money Augend { get { return _augend; } }
        public Money Addend { get { return _addend; } }

        public Sum(Money augend, Money addend)
        {
            _augend = augend;
            _addend = addend;
        }

        public Money Reduce(Bank bank, string to)
        {
            return new Money(_augend.Amount + _addend.Amount, to);
        }
    }
}