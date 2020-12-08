using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizAppMainApi.Migrations
{
    public partial class AddedQuestHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuizHistories",
                columns: table => new
                {
                    QuizHistoryId = table.Column<Guid>(nullable: false),
                    QuizId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    Score = table.Column<Guid>(nullable: false),
                    Date = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizHistories", x => x.QuizHistoryId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuizHistories");
        }
    }
}
