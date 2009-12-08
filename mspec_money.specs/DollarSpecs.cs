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
                    five.Times(2);
                    five.Amount.Equals(10);
                };
    }

}