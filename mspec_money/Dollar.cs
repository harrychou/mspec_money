using System;

namespace mspec_money
{
    public class Money
    {
        protected int _amount;

        public override bool Equals(object obj)
        {
            var money = (Money)obj;
            return money._amount == _amount;
        }
    }

    public class Dollar: Money
    {
        public Dollar(int amount)
        {
            _amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(_amount * multiplier);
        }

    }

    public class Franc: Money
    {
        public Franc(int amount)
        {
            _amount = amount;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(_amount * multiplier);
        }
    } 
}