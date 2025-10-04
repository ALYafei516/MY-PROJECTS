using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EjadHR_API.Migrations
{
    /// <inheritdoc />
    public partial class Thirdmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CompanyFrom",
                table: "EmpDetails",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "EmpDetails",
                type: "nvarchar(250)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CompanyTo",
                table: "EmpDetails",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CourseCenter",
                table: "EmpDetails",
                type: "nvarchar(250)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CourseFrom",
                table: "EmpDetails",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CourseName",
                table: "EmpDetails",
                type: "nvarchar(250)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CourseTo",
                table: "EmpDetails",
                type: "date",
                nullable: true);


            migrationBuilder.AddColumn<string>(
                name: "JobTitle",
                table: "EmpDetails",
                type: "nvarchar(250)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Salary",
                table: "EmpDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyFrom",
                table: "EmpDetails");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "EmpDetails");

            migrationBuilder.DropColumn(
                name: "CompanyTo",
                table: "EmpDetails");

            migrationBuilder.DropColumn(
                name: "CourseCenter",
                table: "EmpDetails");

            migrationBuilder.DropColumn(
                name: "CourseFrom",
                table: "EmpDetails");

            migrationBuilder.DropColumn(
                name: "CourseName",
                table: "EmpDetails");

            migrationBuilder.DropColumn(
                name: "CourseTo",
                table: "EmpDetails");

            migrationBuilder.DropColumn(
                name: "FileCV",
                table: "EmpDetails");

            migrationBuilder.DropColumn(
                name: "JobTitle",
                table: "EmpDetails");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "EmpDetails");
        }
    }
}
