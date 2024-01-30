using RTask.Common.IoC;
using TinyIoC;

namespace RTask.Dependency
{
    public class IoCLocator : IIoCLocator
    {
        private TinyIoCContainer _container;

        public IoCLocator(TinyIoCContainer container)
        {
            _container = container;
        }

        public T GetInstance<T>() where T : class
        {
            return _container.Resolve<T>();
        }

        public void Register<T>() where T : class
        {
            _container.Register<T>();
        }
    }
}