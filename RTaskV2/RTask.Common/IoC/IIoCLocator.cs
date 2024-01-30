namespace RTask.Common.IoC
{
    public interface IIoCLocator
    {
        T GetInstance<T>() where T : class;

        void Register<T>() where T : class;
    }
}