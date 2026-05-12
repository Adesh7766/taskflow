using TaskFlow.Core.Entities.Enum;

namespace TaskFlow.Core.Entities
{
    public class ProjectMember
    {
        public Guid ProjectId { get; set; }

        public Guid UserId { get; set; }

        public ProjectRole Role { get; set; }

        public DateTime JoinedAt { get; set; }
    }
}