using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PineBerry01.Migrations
{
    public partial class Migration01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BerrySubjects",
                columns: table => new
                {
                    BerrySubjectName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BerrySubjects", x => x.BerrySubjectName);
                });

            migrationBuilder.CreateTable(
                name: "BerrySuggests",
                columns: table => new
                {
                    BerrySuggestKey = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuggestTitle = table.Column<string>(nullable: false),
                    SuggestContent = table.Column<string>(nullable: false),
                    SuggestDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BerrySuggests", x => x.BerrySuggestKey);
                });

            migrationBuilder.CreateTable(
                name: "Notices",
                columns: table => new
                {
                    NoticeNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoticeTitle = table.Column<string>(nullable: false),
                    NoticeContent = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notices", x => x.NoticeNo);
                });

            migrationBuilder.CreateTable(
                name: "QnASubjects",
                columns: table => new
                {
                    Subject = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QnASubjects", x => x.Subject);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    UserPw = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserNo);
                });

            migrationBuilder.CreateTable(
                name: "Berries",
                columns: table => new
                {
                    BerryNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BerryTitle = table.Column<string>(nullable: false),
                    BerryContent = table.Column<string>(nullable: false),
                    BerrySubjectName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Berries", x => x.BerryNo);
                    table.ForeignKey(
                        name: "FK_Berries_BerrySubjects_BerrySubjectName",
                        column: x => x.BerrySubjectName,
                        principalTable: "BerrySubjects",
                        principalColumn: "BerrySubjectName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Berries_BerrySubjectName",
                table: "Berries",
                column: "BerrySubjectName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Berries");

            migrationBuilder.DropTable(
                name: "BerrySuggests");

            migrationBuilder.DropTable(
                name: "Notices");

            migrationBuilder.DropTable(
                name: "QnASubjects");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "BerrySubjects");
        }
    }
}
