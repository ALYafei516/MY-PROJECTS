using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EjadHR_API.Migrations
{
    /// <inheritdoc />
    public partial class secondmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "EmpDetails",
                type: "nvarchar(250)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Linkedin",
                table: "EmpDetails",
                type: "nvarchar(250)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "EmpDetails",
                type: "nvarchar(250)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "EmpDetails");

            migrationBuilder.DropColumn(
                name: "Linkedin",
                table: "EmpDetails");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "EmpDetails");
        }
    }
}
