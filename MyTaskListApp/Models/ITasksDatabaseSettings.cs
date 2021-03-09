namespace MyTaskListApp.Models
{
    public interface ITasksDatabaseSettings
    {
        public string TasksCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
