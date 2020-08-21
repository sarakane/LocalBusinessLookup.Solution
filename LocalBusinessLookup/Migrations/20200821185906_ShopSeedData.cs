using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBusinessLookup.Migrations
{
    public partial class ShopSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "ShopId", "Address", "Category", "City", "Name", "PhoneNumber", "State" },
                values: new object[,]
                {
                    { 1, "117 S College St", "Cards & Stationery", "Newberg", "Pulp & Circumstance", "971-264-0563", "OR" },
                    { 2, "602 E 1st St", "Women's clothing", "Newberg", "Nikki Jane's Boutique", "503-538-2620", "OR" },
                    { 3, "23855 SW 195th Pl", "Gift Shops, Holiday Decorations", "Sherwood", "Sleighbells Farm & Gift Shop", "503-625-6052", "OR" },
                    { 4, "22275 SW Pacific Hwy", "Antiques", "Sherwood", "Unger's Trading Post", "503-625-7834", "OR" },
                    { 5, "110 SW 7th St", "Women's Clothing", "Dundee", "Joy's Uptown Style", "503-223-3400", "OR" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 5);
        }
    }
}
