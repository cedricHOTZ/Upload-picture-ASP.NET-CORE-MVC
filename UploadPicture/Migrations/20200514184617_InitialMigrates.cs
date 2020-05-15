using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UploadPicture.Migrations
{
    public partial class InitialMigrates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateDeSortie",
                table: "Movie");

            migrationBuilder.AddColumn<string>(
                name: "ProfileImage",
                table: "Movie",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfileImage",
                table: "Movie");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeSortie",
                table: "Movie",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
