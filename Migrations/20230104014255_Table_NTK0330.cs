using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NguyenThiKham330.Migrations
{
    /// <inheritdoc />
    public partial class TableNTK0330 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NTK0330",
                columns: table => new
                {
                    NTKId = table.Column<int>(type: "INTEGER", maxLength: 20, nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NTKName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    NTKGender = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NTK0330", x => x.NTKId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NTK0330");
        }
    }
}
