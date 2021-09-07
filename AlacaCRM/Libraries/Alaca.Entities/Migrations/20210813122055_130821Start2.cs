using Microsoft.EntityFrameworkCore.Migrations;

namespace Alaca.Entities.migrations
{
    public partial class _130821Start2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey("PK_ProjectStatus", "ProjectStatus");
            migrationBuilder.DropColumn("ProjectStatuId", "ProjectStatus");
            migrationBuilder.AddColumn<byte>(
                name: "ProjectStatuId",
                table: "ProjectStatus",
                type: "tinyint",
                nullable: false)
                .Annotation("SqlServer:Identity", "1, 1");
            migrationBuilder.AddPrimaryKey("PK_ProjectStatus", "ProjectStatus", "ProjectStatuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
