using System;

namespace mspec_money
{
    public class Dollar{
        private int _amount;

        public Dollar(int amount)
        {
            _amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(_amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            var dollar = (Dollar) obj;
            return dollar._amount == _amount;
        }
    }

    public class Franc
    {
        private int _amount;

        public Franc(int amount)
        {
            _amount = amount;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(_amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            var franc = (Franc)obj;
            return franc._amount == _amount;
        }
    } 
}