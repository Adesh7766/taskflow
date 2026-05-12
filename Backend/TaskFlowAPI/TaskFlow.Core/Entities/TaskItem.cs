using TaskFlow.Core.Entities.Enum;

namespace TaskFlow.Core.Entities
{
    public class TaskItem
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public TaskItemStatus Status { get; set; }

        public Guid ProjectId { get; set; }

        public Guid? AssignedUserId { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}