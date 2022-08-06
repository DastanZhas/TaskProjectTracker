using TaskProjectTracker.Models;
using System;
using System.Linq;

namespace TaskProjectTracker.Data_Access_Layer
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Projects.Any())
            {
                return; // DB has been seeded
            }

            var projects = new Project[]
            {
                new Project
                {
                    projectName = "TaskMaster",
                    projectStartDate = DateTime.Parse("2022-08-01"),
                    projectCompletionDate = DateTime.Parse("2022-08-04"),
                    projectStatus = projectCurrentStatus.Completed,
                    projectPriority = 1
                }
            };

            foreach (Project p in projects)
            {
                context.Projects.Add(p);
            }
            context.SaveChanges();

            var projectTasks = new ProjectTask[]
            {
                new ProjectTask
                {
                    projectId = 1,
                    taskName = "test",
                    projectTaskStatus = taskStatus.ToDo,
                    taskDescription = "description",
                    taskPriority = 1
                }
            };

            foreach(ProjectTask t in projectTasks)
            {
                context.ProjectTasks.Add(t);
            }
            context.SaveChanges();
        }
    }
}
