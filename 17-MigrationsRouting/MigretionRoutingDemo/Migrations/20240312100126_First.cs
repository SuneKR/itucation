using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MigretionRoutingDemo.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    PID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.PID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CID = table.Column<int>(type: "int", nullable: false),
                    PID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OID);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CID",
                        column: x => x.CID,
                        principalTable: "Customers",
                        principalColumn: "CID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Products_PID",
                        column: x => x.PID,
                        principalTable: "Products",
                        principalColumn: "PID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CID", "City", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "Aalborg", "Mark Marksen", 74562819 },
                    { 2, "Esbjerg", "Freja Frejsen", 74579819 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "PID", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Gule Handker", 50 },
                    { 2, "Laptop", 5000 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OID", "CID", "OrderDate", "PID", "Quantity" },
                values: new object[] { 1, 2, new DateTime(2024, 3, 12, 11, 1, 24, 67, DateTimeKind.Local).AddTicks(1370), 1, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CID",
                table: "Orders",
                column: "CID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PID",
                table: "Orders",
                column: "PID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
