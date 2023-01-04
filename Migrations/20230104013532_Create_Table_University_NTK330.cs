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
            migrationBuilder.AlterColumn<string>(
                name: "UniversityId",
                table: "UniversityNTK330",
                type: "TEXT",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldMaxLength: 20)
                .OldAnnotation("Sqlite:Autoincrement", true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UniversityId",
                table: "UniversityNTK330",
                type: "INTEGER",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 20)
                .Annotation("Sqlite:Autoincrement", true);
        }
    }
}
