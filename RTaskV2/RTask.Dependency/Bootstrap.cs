using RTask.Common.IoC;
using RTask.Repository;
using TinyIoC;

namespace RTask.Dependency
{
    public static class Bootstrap
    {
        internal static TinyIoCContainer GetIoCContainer()
        {
            var container = new TinyIoCContainer();

            container.Register<ITaskRepository, TaskRepository>();

            return container;
        }

        public static IIoCLocator GetIoCLocator()
        {
            return new IoCLocator(GetIoCContainer());
        }
    }
}