using RTask.Business;

namespace RTask.Common.IoC
{
    public interface ITaskRepository
    {
        TaskDefinition GetTaskDefinition(int taskId);
    }
}