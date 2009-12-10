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
                    Dollar product = five.Times(2);
                    product.Amount.ShouldEqual(10);
                    product = five.Times(3);
                    product.Amount.ShouldEqual(15);
                };
    }

}