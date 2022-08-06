using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace TaskProjectTracker.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    projectId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    projectName = table.Column<string>(type: "text", nullable: true),
                    projectStartDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    projectCompletionDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    projectStatus = table.Column<int>(type: "integer", nullable: true),
                    projectPriority = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.projectId);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTask",
                columns: table => new
                {
                    taskId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    projectId = table.Column<int>(type: "integer", nullable: false),
                    taskName = table.Column<string>(type: "text", nullable: true),
                    projectTaskStatus = table.Column<int>(type: "integer", nullable: true),
                    taskDescription = table.Column<string>(type: "text", nullable: true),
                    taskPriority = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTask", x => x.taskId);
                    table.ForeignKey(
                        name: "FK_ProjectTask_Project_projectId",
                        column: x => x.projectId,
                        principalTable: "Project",
                        principalColumn: "projectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTask_projectId",
                table: "ProjectTask",
                column: "projectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectTask");

            migrationBuilder.DropTable(
                name: "Project");
        }
    }
}
