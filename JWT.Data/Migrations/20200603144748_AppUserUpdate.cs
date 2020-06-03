using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JWT.Data.Migrations
{
    public partial class AppUserUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastDifine",
                table: "AppUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "STT",
                table: "AppUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserCreate",
                table: "AppUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserModifine",
                table: "AppUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastDifine",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "STT",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "UserCreate",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "UserModifine",
                table: "AppUsers");
        }
    }
}
