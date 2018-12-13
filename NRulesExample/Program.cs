using System;
using System.Reflection;
using Ninject;
using NRules;
using NRules.Fluent;
using NRulesExample.Inject;
using NRulesExample.Models;

namespace NRulesExample
{
    class Program
    {
        static void Main(string[] args)
        {

            var builder = new StandardKernel(new ServicesModule());
            var ruleRepository = new RuleRepository();
            ruleRepository.Activator = new NinjectRuleActivator(builder);
            ruleRepository.Load(r => r.From(Assembly.GetExecutingAssembly()));

            var factory = ruleRepository.Compile();
            var session = factory.CreateSession();
            session.DependencyResolver = new NinjectDependencyResolver(builder);

            var sale = new Sale {Name = "A"};
            session.Insert(sale);
            session.Fire();

            Console.ReadKey();
        }
    }
}
