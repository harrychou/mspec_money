namespace mspec_money
{
    public interface Expression{
        Money Reduce(Bank bank, string to);
    }
}