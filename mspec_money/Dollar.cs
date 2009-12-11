using System;

namespace mspec_money
{
    public abstract class Money
    {
        protected int _amount;

        public override bool Equals(object obj)
        {
            var money = (Money)obj;
            return (money.GetType() == GetType() && money._amount == _amount);
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount);
        }

        public abstract Money Times(int multiplier);

        public static Money Franc(int amount)
        {
            return new Franc(amount);
        }
    }

    public class Dollar: Money
    {
        public Dollar(int amount)
        {
            _amount = amount;
        }

        public override Money Times(int multiplier)
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

        public override Money Times(int multiplier)
        {
            return new Franc(_amount * multiplier);
        }
    } 
}