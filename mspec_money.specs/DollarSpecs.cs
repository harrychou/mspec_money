using System;
using System.Diagnostics;
using Machine.Specifications;
using mspec_money;

namespace mspec_demo.specs
{
    [Subject("Dollar")]
    public class DollarSpecs
    {
        private It should_be_able_to_test_dollar_multiplication = 
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
                    Money.Franc(5).Equals(Money.Dollar(5)).ShouldBeFalse();
                };

        private It should_be_able_to_test_Currency =
            () =>
                {
                    Money.Dollar(1).Currency.ShouldEqual("USD");
                    Money.Franc(1).Currency.ShouldEqual("CHF");
                };

        private It should_be_able_to_test_difference_class_equality =
            () =>
                {
                    var money = new Money(10, "CHF");
                    var expected = Money.Franc(10);
                    money.ShouldEqual(expected);
                };
    }
}