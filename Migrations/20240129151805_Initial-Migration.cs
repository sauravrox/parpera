using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parpera.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Datetime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "ID", "Amount", "Datetime", "Description", "Status" },
                values: new object[] { 11, 500.00m, new DateTime(2020, 9, 8, 22, 19, 23, 0, DateTimeKind.Local), "Bank Deposit", "Completed" });

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_ID_Datetime_Description_Amount_Status",
                table: "Transaction",
                columns: new[] { "ID", "Datetime", "Description", "Amount", "Status" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transaction");
        }
    }
}
