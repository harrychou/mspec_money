using System;

namespace mspec_money
{
    public class Money : Expression
    {
        protected int _amount;
        protected string _currency;

        public Money(int amount, string currency)
        {
            _amount = amount;
            _currency = currency;
        }

        public string Currency 
        {
            get { return _currency; }
        }

        public int Amount
        {
            get 
            {
                return _amount;
            }
        }

        public override bool Equals(object obj)
        {
            var money = (Money)obj;
            return (money.Currency.Equals(Currency) && money._amount.Equals(_amount));
        }

        public Money Reduce(Bank bank, string to)
        {
            int rate = bank.Rate(Currency, to);
            return new Money(Amount / rate, to);
        }

        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public virtual Money Times(int multiplier)
        {
            return new Money(_amount * multiplier, Currency);
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }

        public override string ToString()
        {
            return _amount + " " + Currency;
        }

        public Expression Plus(Money addend)
        {
            return new Sum(this, addend);
        }
    }
}