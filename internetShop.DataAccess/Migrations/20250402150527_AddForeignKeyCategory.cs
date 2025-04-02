using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace internetShop.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description" },
                values: new object[] { "Jon Skeet", "Guide to C#" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description" },
                values: new object[] { "Robert Martin", "Best Practice for writing code" });
        }
    }
}
