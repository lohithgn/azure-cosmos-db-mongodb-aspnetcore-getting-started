using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;
using MyTaskListApp.Models;

namespace MyTaskListApp.Services
{
    public class TaskService : ITaskService
    {
        private readonly IMongoCollection<TaskModel> _tasks;

        public TaskService(ITasksDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _tasks = database.GetCollection<TaskModel>(settings.TasksCollectionName);
        }

        public async Task<TaskModel> CreateAsync(TaskModel newTask)
        {
            await _tasks.InsertOneAsync(newTask);
            return newTask;
        }

        public async Task<List<TaskModel>> GetAsync() => 
            await _tasks.Find(task => true).ToListAsync();
    }
}
