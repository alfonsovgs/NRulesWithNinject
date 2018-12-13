using NRules.Fluent.Dsl;
using NRulesExample.Models;
using NRulesExample.Services;

namespace NRulesExample.Rules
{
    public class ExampleRule : Rule
    {
        public override void Define()
        {
            Sale sale = null;
            IExampleService service = null;

            Dependency()
                .Resolve(() => service);

            When()
                .Match<Sale>(() => sale, c => c.Name == "A");

            Then()
                .Do(_ => service.Notify());
        }
    }
}
