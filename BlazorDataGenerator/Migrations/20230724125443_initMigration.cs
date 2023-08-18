using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BlazorDataGenerator.Migrations
{
    /// <inheritdoc />
    public partial class initMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateTable(
                name: "Employee",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    First_Name = table.Column<string>(type: "character varying", maxLength: 100, nullable: true),
                    Last_Name = table.Column<string>(type: "character varying", maxLength: 100, nullable: true),
                    Salary = table.Column<int>(type: "integer", nullable: true),
                    Recruitment = table.Column<DateOnly>(type: "date", nullable: false),
                    Country = table.Column<string>(type: "character varying", nullable: true),
                    City = table.Column<string>(type: "character varying", nullable: true),
                    Street = table.Column<string>(type: "character varying", nullable: true),
                    Age = table.Column<int>(type: "integer", nullable: true),
                    Position = table.Column<string>(type: "character varying", nullable: true),
                    Email = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee",
                schema: "public");
        }
    }
}
