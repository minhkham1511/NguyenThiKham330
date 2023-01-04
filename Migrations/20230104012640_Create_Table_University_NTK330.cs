using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NguyenThiKham330.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableUniversityNTK330 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UniversityNTK330",
                columns: table => new
                {
                    UniversityId = table.Column<int>(type: "INTEGER", maxLength: 20, nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UniversityName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniversityNTK330", x => x.UniversityId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UniversityNTK330");
        }
    }
}
