using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskProjectTracker.Models
{
    public enum projectCurrentStatus
    {
        NotStarted, Active, Completed
    }

    public class Project
    {
        [Key]
        public int projectId { get; set; }

        public ICollection<ProjectTask> ProjectTasks { get; set; }

        public string projectName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime projectStartDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime projectCompletionDate { get; set; }

        public projectCurrentStatus? projectStatus { get; set; }

        public int projectPriority { get; set; }
    }
}
