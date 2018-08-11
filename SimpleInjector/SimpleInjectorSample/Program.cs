using System;

namespace SimpleInjectorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            DiContainer.Register(ObjectFactory.Container);
            ILogger logger = ObjectFactory.CreateLogger();
            IEmployeeProcessor employeeProcessor = ObjectFactory.CreateEmployeeProcessor();
            IEmployee initial = ObjectFactory.Container.GetInstance<IEmployee>();
            logger.Log(initial);
            IEmployee updated = employeeProcessor.UpdateEmployee(123, "Vinod");
            logger.Log(updated);
            IEmployee processed = employeeProcessor.Process();
            logger.Log(processed);
            Console.ReadLine();
        }
    }
}
