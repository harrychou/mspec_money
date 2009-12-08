using System;

namespace mspec_money
{
    public class Dollar{
        public int Amount;

        public Dollar(int amount)
        {
            Amount = amount;
        }

        public void Times(int multiplier)
        {
            Amount *= multiplier;
        }
    }     
}