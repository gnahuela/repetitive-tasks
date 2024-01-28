using RTask.Common;
using RTask.DAL;
using TinyIoC;

namespace RTask.Dependency
{
    public static class Bootstrap
    {
        internal static TinyIoCContainer GetIoCContainer()
        {
            var container = new TinyIoCContainer();

            container.Register<ITaskDefinitionDAL, TaskDefinitionDAL>();

            return container;
        }

        public static IIoCLocator GetIoCLocator()
        {
            return new IoCLocator(GetIoCContainer());
        }
    }
}