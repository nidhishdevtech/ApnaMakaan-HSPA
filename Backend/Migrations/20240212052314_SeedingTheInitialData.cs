using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApnaMakaanAPI.Migrations
{
    public partial class SeedingTheInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "id", "cityName", "CountryName" },
                values: new object[,]
                {
                    { 1, "Pune", "India" },
                    { 2, "Faridabad", "India" },
                    { 3, "Nagpur", "India" }
                });

            migrationBuilder.InsertData(
                table: "FurnishingType",
                columns: new[] { "id", "furnishing_Type" },
                values: new object[,]
                {
                    { 1, "FullyFurnished" },
                    { 2, "SemiFurnished" },
                    { 3, "UnFurnished" }
                });

            migrationBuilder.InsertData(
                table: "PropertyType",
                columns: new[] { "id", "property_Type" },
                values: new object[,]
                {
                    { 1, "House" },
                    { 2, "Duplex" },
                    { 3, "Apartment" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "id", "FullName", "isAdmin", "Password", "PhoneNumber", "UserName" },
                values: new object[,]
                {
                    { 1, "Himanshu Tembhurne", false, "himanshu123", "9876543210", "himanshuxx" },
                    { 2, "Satyam Verma", false, "satyam123", "9876543211", "satyam" },
                    { 3, "Isha Mulajkar", false, "isha123", "9876543212", "isha" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FurnishingType",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FurnishingType",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FurnishingType",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PropertyType",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PropertyType",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PropertyType",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
