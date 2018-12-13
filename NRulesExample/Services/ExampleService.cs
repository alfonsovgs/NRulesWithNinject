using System;

namespace NRulesExample.Services
{
    public class ExampleService : IExampleService
    {
        public void Notify()
        {
            Console.WriteLine("Notificando con inyección de dependencias");
        }
    }
}
