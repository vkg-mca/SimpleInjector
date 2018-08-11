
using SimpleInjector;

namespace SimpleInjectorSample
{
    public static class ObjectFactory
    {
        private static Container _container = new Container();
        public static Container Container { get; private set; } = _container;
        public static IEmployeeProcessor CreateEmployeeProcessor()
        {
            IEmployeeProcessor processor = Container.GetInstance<IEmployeeProcessor>();
            return processor;
        }
        public static ILogger CreateLogger()
        {
            ILogger logger = Container.GetInstance<ILogger>();
            return logger;
        }

    }
}
