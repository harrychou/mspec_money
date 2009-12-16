namespace mspec_money
{
    public class Bank{
        public Money Reduce(Expression source, string to)
        {
            return source.Reduce(to);
        }
    }
}