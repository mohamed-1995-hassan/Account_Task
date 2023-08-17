using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Account_Task.Migrations
{
    /// <inheritdoc />
    public partial class Account_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_ID = table.Column<int>(type: "int", nullable: false),
                    Server_DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTime_UTC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Update_DateTime_UTC = table.Column<int>(type: "int", nullable: false),
                    Account_Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Server_DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTime_UTC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Update_DateTime_UTC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    First_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Date_Of_Birth = table.Column<int>(type: "int", nullable: false),
                    Account_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Accounts_Account_ID",
                        column: x => x.Account_ID,
                        principalTable: "Accounts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_User_ID",
                table: "Accounts",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Account_ID",
                table: "Users",
                column: "Account_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Users_User_ID",
                table: "Accounts",
                column: "User_ID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Users_User_ID",
                table: "Accounts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
