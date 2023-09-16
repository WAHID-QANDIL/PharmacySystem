using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyProjectITI.Migrations
{
    /// <inheritdoc />
    public partial class addColumnAtUserMediciensTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "quantity",
                table: "User_Mediciens",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "quantity",
                table: "User_Mediciens");
        }
    }
}
