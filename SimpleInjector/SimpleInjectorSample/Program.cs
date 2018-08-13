using System;

namespace SimpleInjectorSample
{
    class Program
    {
        static void Main(string[] args)
        {

            var container = ObjectFactory.GetContainer();
            DiContainer.Register(container);

            ILogger logger = ObjectFactory.GetInstance<ILogger>();
            IEmployeeProcessor employeeProcessor = ObjectFactory.GetInstance<IEmployeeProcessor>();

            IEmployee initial = ObjectFactory.GetInstance<IEmployee>();
            logger.Log(initial);

            IEmployee updated = employeeProcessor.UpdateEmployee(123, "Vinod");
            logger.Log(updated);

            IEmployee processed = employeeProcessor.Process();
            logger.Log(processed);

            Console.ReadLine();
        }
    }
}
