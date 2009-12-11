using System;

namespace mspec_money
{
    public class Dollar{
        private int Amount;

        public Dollar(int amount)
        {
            Amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            var dollar = (Dollar) obj;
            return dollar.Amount == Amount;
        }
    }     
}