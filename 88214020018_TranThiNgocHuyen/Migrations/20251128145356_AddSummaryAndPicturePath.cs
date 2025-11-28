using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _88214020018_TranThiNgocHuyen.Migrations
{
    /// <inheritdoc />
    public partial class AddSummaryAndPicturePath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PicturePath",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Summary",
                table: "Movies",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PicturePath",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Summary",
                table: "Movies");
        }
    }
}
