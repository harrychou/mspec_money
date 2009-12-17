using System;

namespace mspec_money
{
    public class Sum: Expression {
        private readonly Expression _augend;
        private readonly Expression _addend;
        public Expression Augend { get { return _augend; } }
        public Expression Addend { get { return _addend; } }

        public Sum(Expression augend, Expression addend)
        {
            _augend = augend;
            _addend = addend;
        }

        public Money Reduce(Bank bank, string to)
        {
            return new Money(_augend.Reduce(bank, to).Amount + _addend.Reduce(bank, to).Amount, to);
        }

        public Expression Plus(Expression addend)
        {
            return new Sum(this, addend);
        }

        public Expression Times(int multiplier)
        {
            return new Sum(_augend.Times(multiplier), _addend.Times(multiplier));
        }
    }
}