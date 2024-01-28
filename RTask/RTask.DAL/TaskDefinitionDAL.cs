using RTask.Common;
using System.Threading.Tasks;

namespace RTask.DAL
{
    public class TaskDefinitionDAL : ITaskDefinitionDAL
    {
        public async Task<TaskDefinition> GetTaskDefinitionById(int id)
        {
            return new TaskDefinition();
        }
    }
}