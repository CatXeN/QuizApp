using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizAppMainApi.Migrations
{
    public partial class addedDoneQuizzess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DoneQuizzess",
                table: "Categories",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoneQuizzess",
                table: "Categories");
        }
    }
}
