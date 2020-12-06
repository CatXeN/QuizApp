using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizAppMainApi.Migrations
{
    public partial class AddedDoneQuizzess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DoneQuizzess",
                table: "Quizzes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoneQuizzess",
                table: "Quizzes");
        }
    }
}
