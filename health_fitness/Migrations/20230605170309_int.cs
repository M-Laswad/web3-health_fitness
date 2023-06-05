using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace health_fitness.Migrations
{
    /// <inheritdoc />
    public partial class @int : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StepSInfo",
                columns: table => new
                {
                    time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    stepsnumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StepSInfo", x => x.time);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StepSInfo");
        }
    }
}
