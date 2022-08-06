﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TaskProjectTracker.Data_Access_Layer;

namespace TaskProjectTracker.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("TaskProjectTracker.Models.Project", b =>
                {
                    b.Property<int>("projectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("projectCompletionDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("projectName")
                        .HasColumnType("text");

                    b.Property<int>("projectPriority")
                        .HasColumnType("integer");

                    b.Property<DateTime>("projectStartDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("projectStatus")
                        .HasColumnType("integer");

                    b.HasKey("projectId");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("TaskProjectTracker.Models.ProjectTask", b =>
                {
                    b.Property<int>("taskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("projectId")
                        .HasColumnType("integer");

                    b.Property<int?>("projectTaskStatus")
                        .HasColumnType("integer");

                    b.Property<string>("taskDescription")
                        .HasColumnType("text");

                    b.Property<string>("taskName")
                        .HasColumnType("text");

                    b.Property<int>("taskPriority")
                        .HasColumnType("integer");

                    b.HasKey("taskId");

                    b.HasIndex("projectId");

                    b.ToTable("ProjectTask");
                });

            modelBuilder.Entity("TaskProjectTracker.Models.ProjectTask", b =>
                {
                    b.HasOne("TaskProjectTracker.Models.Project", "Project")
                        .WithMany("ProjectTasks")
                        .HasForeignKey("projectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("TaskProjectTracker.Models.Project", b =>
                {
                    b.Navigation("ProjectTasks");
                });
#pragma warning restore 612, 618
        }
    }
}