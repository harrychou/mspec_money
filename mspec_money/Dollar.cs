namespace mspec_money
{
    public abstract class Money
    {
        protected int _amount;
        protected string _currency;

        protected Money(int amount, string currency)
        {
            _amount = amount;
            _currency = currency;
        }

        public string Currency 
        {
            get { return _currency; }
        }

        public override bool Equals(object obj)
        {
            var money = (Money)obj;
            return (money.GetType() == GetType() && money._amount == _amount);
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public abstract Money Times(int multiplier);

        public static Money Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }
    }

    public class Dollar: Money
    {
        public Dollar(int amount, string currency): base(amount, currency)
        {
        }

        public override Money Times(int multiplier)
        {
            return Money.Dollar(_amount * multiplier);
        }

    }

    public class Franc: Money
    {
        public Franc(int amount, string currency): base(amount, currency)
        {
        }

        public override Money Times(int multiplier)
        {
            return Money.Franc(_amount * multiplier);
        }
    } 
}