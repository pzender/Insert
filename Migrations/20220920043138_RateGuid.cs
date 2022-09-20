using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsertRekrutacja.Migrations
{
    public partial class RateGuid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CurrencyRates",
                table: "CurrencyRates");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "CurrencyRates",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_CurrencyRates",
                table: "CurrencyRates",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CurrencyRates",
                table: "CurrencyRates");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CurrencyRates");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CurrencyRates",
                table: "CurrencyRates",
                column: "Code");
        }
    }
}
