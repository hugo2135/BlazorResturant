using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Server.Migrations
{
    public partial class ResturantsSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Resturants",
                columns: new[] { "Id", "Address", "Distance", "ImageURL", "Name", "Price", "Rating", "Style" },
                values: new object[] { 1, "Just near hear", 0.0, "", "PP1", 69m, 3.5, "Soso" });

            migrationBuilder.InsertData(
                table: "Resturants",
                columns: new[] { "Id", "Address", "Distance", "ImageURL", "Name", "Price", "Rating", "Style" },
                values: new object[] { 2, "Maybe near hear", 0.0, "https://i.pinimg.com/564x/10/c9/c0/10c9c02224ae9c08ba781bae2a856675.jpg", "PP0", 1600m, 4.5, "Delicious" });

            migrationBuilder.InsertData(
                table: "Resturants",
                columns: new[] { "Id", "Address", "Distance", "ImageURL", "Name", "Price", "Rating", "Style" },
                values: new object[] { 3, "Too far", 0.0, "", "PP2", 200m, 2.2000000000000002, "Yup" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Resturants",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Resturants",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Resturants",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
