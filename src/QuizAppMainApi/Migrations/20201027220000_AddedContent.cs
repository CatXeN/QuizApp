using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizAppMainApi.Migrations
{
    public partial class AddedContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Quests");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Quizzes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Quizzes");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Quests",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
