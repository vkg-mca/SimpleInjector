
using SimpleInjector;

namespace SimpleInjectorSample
{
    public static class ObjectFactory
    {
        private static Container _container = new Container();

        public static Container GetContainer()
        {
            return _container;
        }

        public static T GetInstance<T>() where T : class
        {
            return _container.GetInstance<T>();
        }

    }
}
