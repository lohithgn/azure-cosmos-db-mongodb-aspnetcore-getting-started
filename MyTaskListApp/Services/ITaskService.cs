using System.Collections.Generic;
using System.Threading.Tasks;
using MyTaskListApp.Models;

namespace MyTaskListApp.Services
{
    public interface ITaskService
    {
        Task<TaskModel> CreateAsync(TaskModel newTask);
        Task<List<TaskModel>> GetAsync();
    }
}
