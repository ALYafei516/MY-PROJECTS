using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EjadHR_API.Migrations
{
    /// <inheritdoc />
    public partial class Forthmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "EmpDetails",
                type: "nvarchar(250)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Language",
                table: "EmpDetails");
        }
    }
}
