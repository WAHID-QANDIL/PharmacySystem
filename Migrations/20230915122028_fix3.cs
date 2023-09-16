using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyProjectITI.Migrations
{
    /// <inheritdoc />
    public partial class fix3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_mediciens_categaries_cid",
                table: "mediciens");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Mediciens_mediciens_mid_id",
                table: "User_Mediciens");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Mediciens_users_UserID",
                table: "User_Mediciens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_mediciens",
                table: "mediciens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categaries",
                table: "categaries");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "user");

            migrationBuilder.RenameTable(
                name: "mediciens",
                newName: "medicien");

            migrationBuilder.RenameTable(
                name: "categaries",
                newName: "categarie");

            migrationBuilder.RenameIndex(
                name: "IX_mediciens_cid",
                table: "medicien",
                newName: "IX_medicien_cid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user",
                table: "user",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_medicien",
                table: "medicien",
                column: "mid_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categarie",
                table: "categarie",
                column: "cid");

            migrationBuilder.AddForeignKey(
                name: "FK_medicien_categarie_cid",
                table: "medicien",
                column: "cid",
                principalTable: "categarie",
                principalColumn: "cid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Mediciens_medicien_mid_id",
                table: "User_Mediciens",
                column: "mid_id",
                principalTable: "medicien",
                principalColumn: "mid_id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_medicien_categarie_cid",
                table: "medicien");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Mediciens_medicien_mid_id",
                table: "User_Mediciens");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Mediciens_user_UserID",
                table: "User_Mediciens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user",
                table: "user");

            migrationBuilder.DropPrimaryKey(
                name: "PK_medicien",
                table: "medicien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categarie",
                table: "categarie");

            migrationBuilder.RenameTable(
                name: "user",
                newName: "users");

            migrationBuilder.RenameTable(
                name: "medicien",
                newName: "mediciens");

            migrationBuilder.RenameTable(
                name: "categarie",
                newName: "categaries");

            migrationBuilder.RenameIndex(
                name: "IX_medicien_cid",
                table: "mediciens",
                newName: "IX_mediciens_cid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_mediciens",
                table: "mediciens",
                column: "mid_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categaries",
                table: "categaries",
                column: "cid");

            migrationBuilder.AddForeignKey(
                name: "FK_mediciens_categaries_cid",
                table: "mediciens",
                column: "cid",
                principalTable: "categaries",
                principalColumn: "cid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Mediciens_mediciens_mid_id",
                table: "User_Mediciens",
                column: "mid_id",
                principalTable: "mediciens",
                principalColumn: "mid_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Mediciens_users_UserID",
                table: "User_Mediciens",
                column: "UserID",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
