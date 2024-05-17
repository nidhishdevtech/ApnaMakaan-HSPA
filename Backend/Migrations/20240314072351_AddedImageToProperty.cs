using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApnaMakaanAPI.Migrations
{
    public partial class AddedImageToProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Property",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Property");
        }
    }
}
