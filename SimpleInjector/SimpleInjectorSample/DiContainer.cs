using SimpleInjector;

namespace SimpleInjectorSample
{
    public class DiContainer
    {
        public static void Register(Container container)
        {
            container.RegisterSingleton<IEmployeeProcessor, EmployeeProcessor>();
            container.RegisterSingleton<IEmployee>(() => new Employee(0, "raw"));
            container.RegisterSingleton<ILogger, ConsoleLogger>();
        }

    }
}
