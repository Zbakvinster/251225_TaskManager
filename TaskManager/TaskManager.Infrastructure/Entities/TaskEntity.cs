namespace TaskManager.Infrastructure.Entities
{
    public class TaskEntity
    {
        public Guid Id { get; set; }
        public string Text { get; set; } = string.Empty;
        public int State { get; set; }
        public bool IsDeleted { get; set; }

    }
}
