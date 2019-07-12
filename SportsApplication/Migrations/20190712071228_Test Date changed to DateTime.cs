using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsApplication.Migrations
{
    public partial class TestDatechangedtoDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Tests",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Date",
                table: "Tests",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
