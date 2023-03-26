using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Desktop_App_01.Migrations
{
    /// <inheritdoc />
    public partial class added_gpa_dob : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "ListofStudents",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<double>(
                name: "GPA",
                table: "ListofStudents",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "ListofStudents");

            migrationBuilder.DropColumn(
                name: "GPA",
                table: "ListofStudents");
        }
    }
}
