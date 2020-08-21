using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBusinessLookup.Migrations
{
    public partial class RestaurantSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "Address", "City", "Cuisine", "Name", "PhoneNumber", "State" },
                values: new object[,]
                {
                    { 1, "203 Villa Rd", "Newberg", "American(Traditional)", "Newbergundian Bistro", "971-832-8687", "OR" },
                    { 2, "910 E 1st St", "Newberg", "Thai, Food Tucks", "Bangkok Noi Thai", "503-726-6067", "OR" },
                    { 3, "808 E Hancock St", "Newberg", "Coffee & Tea, Bakeries", "Coffee Cottage", "503-538-5126", "OR" },
                    { 4, "3777 Portland Rd", "Newberg", "Russian, Coffee & Tea", "From Russia With Love", "971-832-8579", "OR" },
                    { 5, "155 SW 7th St", "Dundee", "Sandwiches, Pizza", "Red Hills Market", "971-832-8414", "OR" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 5);
        }
    }
}
