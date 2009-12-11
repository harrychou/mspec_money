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
                    Dollar five = new Dollar(5);
                    five.Times(2).ShouldEqual(new Dollar(10));
                    five.Times(3).ShouldEqual(new Dollar(15));
                };

        private It should_be_able_to_test_equality =
            () =>
                {
                    new Dollar(5).Equals(new Dollar(5)).ShouldBeTrue();
                    new Dollar(5).Equals(new Dollar(6)).ShouldBeFalse();
                };
    }

}