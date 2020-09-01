using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkWithUsRazor.Migrations
{
    public partial class AddNameToVacancyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Vacancy",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Vacancy");
        }
    }
}
