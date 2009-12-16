using System;
using System.Collections.Generic;

namespace mspec_money
{
    public class Bank{
        private Dictionary<Pair, int> _rates = new Dictionary<Pair, int>();

        private class Pair
        {
            private readonly string _from;
            private readonly string _to;

            public Pair(string from, string to)
            {
                _from = from;
                _to = to;
            }

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                if (obj.GetType() != typeof (Pair)) return false;
                return Equals((Pair) obj);
            }

            public bool Equals(Pair other)
            {
                if (ReferenceEquals(null, other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Equals(other._from, _from) && Equals(other._to, _to);
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    return ((_from != null ? _from.GetHashCode() : 0)*397) ^ (_to != null ? _to.GetHashCode() : 0);
                }
            }
        }

        public Money Reduce(Expression source, string to)
        {
            return source.Reduce(this, to);
        }

        public void AddRate(string currencyFrom, string currentTo, int rate)
        {
            Pair pair = new Pair(currencyFrom, currentTo);
            _rates.Add(pair, rate);
        }

        public int Rate(string from, string to)
        {
            if (from.Equals(to)) return 1;
            return _rates[new Pair(from, to)];
        }
    }
}