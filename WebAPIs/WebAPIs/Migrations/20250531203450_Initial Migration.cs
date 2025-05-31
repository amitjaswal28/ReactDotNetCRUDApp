using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPIs.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dCandidates",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    mobile = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    email = table.Column<string>(type: "NVARCHAR(10)", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    bloodGroup = table.Column<string>(type: "NVARCHAR(4)", nullable: false),
                    address = table.Column<string>(type: "NVARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dCandidates", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dCandidates");
        }
    }
}
