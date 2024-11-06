using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupStudent");

            migrationBuilder.DropPrimaryKey(
                name: "Application.Databases.Relational.Models.Courses.CourseTime_pk",
                table: "CourseTimes");

            migrationBuilder.AddPrimaryKey(
                name: "Application.Databases.Relational.Models.Courses.CourseMeet_pk",
                table: "CourseTimes",
                column: "CourseTimeId");

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    ApplicationDatabasesRelationalModelsGroupsGroupId = table.Column<Guid>(name: "Application.Databases.Relational.Models.Groups.GroupId", type: "uniqueidentifier", nullable: false),
                    ApplicationDatabasesRelationalModelsUsersStudentId = table.Column<Guid>(name: "Application.Databases.Relational.Models.Users.StudentId", type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => new { x.ApplicationDatabasesRelationalModelsGroupsGroupId, x.ApplicationDatabasesRelationalModelsUsersStudentId });
                    table.ForeignKey(
                        name: "Application.Databases.Relational.Models.Users.StudentApplication.Databases.Relational.Models.Groups.Group_Application.Databases.Relational.Models.Groups.Group",
                        column: x => x.ApplicationDatabasesRelationalModelsGroupsGroupId,
                        principalTable: "Groups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Application.Databases.Relational.Models.Users.StudentApplication.Databases.Relational.Models.Groups.Group_Application.Databases.Relational.Models.Users.Student",
                        column: x => x.ApplicationDatabasesRelationalModelsUsersStudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Group_Application.Databases.Relational.Models.Users.StudentId",
                table: "Group",
                column: "Application.Databases.Relational.Models.Users.StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropPrimaryKey(
                name: "Application.Databases.Relational.Models.Courses.CourseMeet_pk",
                table: "CourseTimes");

            migrationBuilder.AddPrimaryKey(
                name: "Application.Databases.Relational.Models.Courses.CourseTime_pk",
                table: "CourseTimes",
                column: "CourseTimeId");

            migrationBuilder.CreateTable(
                name: "GroupStudent",
                columns: table => new
                {
                    GroupsGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentsStudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupStudent", x => new { x.GroupsGroupId, x.StudentsStudentId });
                    table.ForeignKey(
                        name: "FK_GroupStudent_Groups_GroupsGroupId",
                        column: x => x.GroupsGroupId,
                        principalTable: "Groups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupStudent_Students_StudentsStudentId",
                        column: x => x.StudentsStudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GroupStudent_StudentsStudentId",
                table: "GroupStudent",
                column: "StudentsStudentId");
        }
    }
}
