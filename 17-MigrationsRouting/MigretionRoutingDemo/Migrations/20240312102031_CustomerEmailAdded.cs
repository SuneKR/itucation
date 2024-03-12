using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MigretionRoutingDemo.Migrations
{
    /// <inheritdoc />
    public partial class CustomerEmailAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CID",
                keyValue: 1,
                column: "Email",
                value: "MM@mail.dk");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CID",
                keyValue: 2,
                column: "Email",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OID",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 3, 12, 11, 20, 29, 501, DateTimeKind.Local).AddTicks(3705));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OID",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 3, 12, 11, 1, 24, 67, DateTimeKind.Local).AddTicks(1370));
        }
    }
}
