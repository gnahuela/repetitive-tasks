using RTask.Common;
using System.Threading.Tasks;

namespace RTask.Common
{
    public interface ITaskDefinitionDAL
    {
        Task<TaskDefinition> GetTaskDefinitionById(int id);
    }
}