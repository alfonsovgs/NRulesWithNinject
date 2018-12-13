using System;
using System.Collections.Generic;
using System.Linq;
using Ninject;
using Ninject.Modules;
using NRules.Fluent;
using NRules.Fluent.Dsl;

namespace NRulesExample.Inject
{
    public class NinjectRuleActivator : IRuleActivator
    {
        private readonly IKernel _kernel;

        public NinjectRuleActivator(INinjectModule container) : this(new StandardKernel(container))
        {
            
        }

        public NinjectRuleActivator(IKernel kernel)
        {
            _kernel = kernel;
        }

        public IEnumerable<Rule> Activate(Type type)
        {
            return _kernel.GetAll(type).Cast<Rule>();
        }
    }
}
