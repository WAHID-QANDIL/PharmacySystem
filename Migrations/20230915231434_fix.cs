using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyProjectITI.Migrations
{
    /// <inheritdoc />
    public partial class fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Mediciens_user_UserID",
                table: "User_Mediciens");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Mediciens_user_UserID",
                table: "User_Mediciens",
                column: "UserID",
                principalTable: "user",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Mediciens_user_UserID",
                table: "User_Mediciens");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Mediciens_user_UserID",
                table: "User_Mediciens",
                column: "UserID",
                principalTable: "user",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
