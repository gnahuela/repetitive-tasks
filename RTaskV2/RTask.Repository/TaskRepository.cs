using RTask.Business;
using RTask.Common.IoC;

namespace RTask.Repository
{
    public class TaskRepository : ITaskRepository
    {
        public TaskRepository()
        { }

        public TaskDefinition GetTaskDefinition(int taskId)
        {
            return new TaskDefinition { Id = taskId, Name = taskId.ToString() };
        }
    }
}