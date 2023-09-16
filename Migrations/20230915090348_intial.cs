using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyProjectITI.Migrations
{
    /// <inheritdoc />
    public partial class intial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categaries",
                columns: table => new
                {
                    cid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categaries", x => x.cid);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    uName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mediciens",
                columns: table => new
                {
                    mid_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mid_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mid_price = table.Column<float>(type: "real", nullable: false),
                    productionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    expireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    cid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mediciens", x => x.mid_id);
                    table.ForeignKey(
                        name: "FK_mediciens_categaries_cid",
                        column: x => x.cid,
                        principalTable: "categaries",
                        principalColumn: "cid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User_Mediciens",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mid_id = table.Column<int>(type: "int", nullable: false),
                    mid_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Mediciens", x => x.ID);
                    table.ForeignKey(
                        name: "FK_User_Mediciens_mediciens_mid_id",
                        column: x => x.mid_id,
                        principalTable: "mediciens",
                        principalColumn: "mid_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Mediciens_users_UserID",
                        column: x => x.UserID,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_mediciens_cid",
                table: "mediciens",
                column: "cid");

            migrationBuilder.CreateIndex(
                name: "IX_User_Mediciens_mid_id",
                table: "User_Mediciens",
                column: "mid_id");

            migrationBuilder.CreateIndex(
                name: "IX_User_Mediciens_UserID",
                table: "User_Mediciens",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User_Mediciens");

            migrationBuilder.DropTable(
                name: "mediciens");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "categaries");
        }
    }
}
