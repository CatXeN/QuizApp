using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizAppMainApi.Migrations
{
    public partial class AddedAnswers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AnswerA",
                table: "Quests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AnswerB",
                table: "Quests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AnswerC",
                table: "Quests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AnswerD",
                table: "Quests",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CorrectAnswer",
                table: "Quests",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnswerA",
                table: "Quests");

            migrationBuilder.DropColumn(
                name: "AnswerB",
                table: "Quests");

            migrationBuilder.DropColumn(
                name: "AnswerC",
                table: "Quests");

            migrationBuilder.DropColumn(
                name: "AnswerD",
                table: "Quests");

            migrationBuilder.DropColumn(
                name: "CorrectAnswer",
                table: "Quests");
        }
    }
}
