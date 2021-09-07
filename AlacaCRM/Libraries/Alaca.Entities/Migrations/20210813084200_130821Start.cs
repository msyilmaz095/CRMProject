using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Alaca.Entities.migrations
{
    public partial class _130821Start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MilestoneStatuId",
                table: "ProjectMilestones");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "MilestoneStatuId",
                table: "ProjectMilestones",
                type: "uniqueidentifier",
                nullable: true);
        }
    }
}
