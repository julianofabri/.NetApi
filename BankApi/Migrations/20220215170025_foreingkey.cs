using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankApi.Migrations
{
    public partial class foreingkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Statments_Users_userId",
                table: "Statments");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Statments",
                newName: "AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Statments_userId",
                table: "Statments",
                newName: "IX_Statments_AccountId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Statments",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Accounts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_UserId",
                table: "Accounts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Users_UserId",
                table: "Accounts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_Accounts_Users_UserId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Statments_Accounts_AccountId",
                table: "Statments");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_UserId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Statments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Accounts");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Statments",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_Statments_AccountId",
                table: "Statments",
                newName: "IX_Statments_userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Statments_Users_userId",
                table: "Statments",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
