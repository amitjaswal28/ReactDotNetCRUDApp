using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPIs.Migrations
{
    /// <inheritdoc />
    public partial class chagedMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "mobile",
                table: "dCandidates",
                type: "NVARCHAR(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "dCandidates",
                type: "NVARCHAR(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(10)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "mobile",
                table: "dCandidates",
                type: "NVARCHAR(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(10)");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "dCandidates",
                type: "NVARCHAR(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)");
        }
    }
}
