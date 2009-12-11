using System.Diagnostics;
using Machine.Specifications;
using mspec_money;

namespace mspec_demo.specs
{
    [Subject("Dollar")]
    public class DollarSpecs
    {
        private It should_be_able_to_do_multiplication = 
            () =>
                {
                    Money five = Money.Dollar(5);
                    five.Times(2).ShouldEqual(Money.Dollar(10));
                    five.Times(3).ShouldEqual(Money.Dollar(15));
                };

        private It should_be_able_to_test_equality =
            () =>
                {
                    Money.Dollar(5).Equals(Money.Dollar(5)).ShouldBeTrue();
                    Money.Dollar(5).Equals(Money.Dollar(6)).ShouldBeFalse();
                    Money.Franc(5).Equals(Money.Franc(5)).ShouldBeTrue();
                    Money.Franc(5).Equals(Money.Franc(6)).ShouldBeFalse();
                    Money.Franc(5).Equals(Money.Dollar(5)).ShouldBeFalse();
                };

        private It should_be_able_to_test_franc_multiplication =
        () =>
        {
            Money five = Money.Franc(5);
            five.Times(2).ShouldEqual(Money.Franc(10));
            five.Times(3).ShouldEqual(Money.Franc(15));
        };
    }

}