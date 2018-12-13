using Ninject.Modules;
using NRulesExample.Services;

namespace NRulesExample.Inject
{
    public class ServicesModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IExampleService>().To<ExampleService>();
        }
    }
}
