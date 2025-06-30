using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Reserve",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTimeStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    hourDuration = table.Column<int>(type: "int", nullable: false),
                    resourceType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    responsibleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserve", x => x.Id);
                    table.CheckConstraint("CK_DateTimeStart", "DateTimeStart >= '08:00:00' AND DateTimeStart <= '18:00:00'");
                    table.CheckConstraint("CK_hourDuration", "hourDuration BETWEEN 1 AND 8");
                    table.CheckConstraint("CK_resourceType", "resourceType IN ('room','vehicle','equipment')");
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reserve",
                schema: "dbo");
        }
    }
}
