using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankApi.Migrations
{
    public partial class foreingAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Statments_AccountId",
                table: "Statments",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Statments_Accounts_AccountId",
                table: "Statments",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Statments_Accounts_AccountId",
                table: "Statments");

            migrationBuilder.DropIndex(
                name: "IX_Statments_AccountId",
                table: "Statments");
        }
    }
}
