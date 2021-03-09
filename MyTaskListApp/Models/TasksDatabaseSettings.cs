namespace MyTaskListApp.Models
{
    public class TasksDatabaseSettings : ITasksDatabaseSettings
    {
        public string TasksCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
