using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Alaca.Entities.migrations
{
    public partial class _160821Start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "CurrencyValues",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreateUser",
                table: "CurrencyValues",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "CurrencyValues",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateUser",
                table: "CurrencyValues",
                type: "uniqueidentifier",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "CurrencyValues");

            migrationBuilder.DropColumn(
                name: "CreateUser",
                table: "CurrencyValues");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "CurrencyValues");

            migrationBuilder.DropColumn(
                name: "UpdateUser",
                table: "CurrencyValues");
        }
    }
}
