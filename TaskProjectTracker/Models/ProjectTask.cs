using System.ComponentModel.DataAnnotations;

namespace TaskProjectTracker.Models
{
    public enum taskStatus
    {
        ToDo, InProgress, Done
    }

    public class ProjectTask
    {
        [Key]
        public int taskId { get; set; }

        public int projectId { get; set; }
        public Project Project { get; set; }

        public string taskName { get; set; }

        public taskStatus? projectTaskStatus { get; set; }

        public string taskDescription { get; set; }

        public int taskPriority { get; set; }
    }
}
