using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JWT.Data.Migrations
{
    public partial class _202006032323 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastDifine",
                table: "AppUsers");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifine",
                table: "AppUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Interactive_Historys",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Key = table.Column<string>(nullable: false),
                    Times = table.Column<DateTime>(nullable: false),
                    Actor = table.Column<string>(maxLength: 250, nullable: false),
                    Content = table.Column<string>(nullable: false),
                    TimeCreate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interactive_Historys", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Interactive_Historys");

            migrationBuilder.DropColumn(
                name: "LastModifine",
                table: "AppUsers");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastDifine",
                table: "AppUsers",
                type: "datetime2",
                nullable: true);
        }
    }
}
