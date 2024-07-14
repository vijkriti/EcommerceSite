using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Samsung" },
                    { 2, "Apple" },
                    { 3, "OnePlus" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Phones" },
                    { 2, "TV" },
                    { 3, "Tablets" },
                    { 4, "Laptop" },
                    { 5, "Earphones" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Description", "ImgPath", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 3, "This is Samsung Tablet description.", "Tablet.jpg", "Samsung Tablet", 30000m, 30 },
                    { 2, 2, 3, "This is iPad description.", "iPad.jpg", "iPad", 100000m, 10 },
                    { 3, 1, 2, "This is Samsung TV description.", "TV.jpg", "Samsung TV", 80000m, 20 },
                    { 4, 1, 2, "This is Samsung M32 description.", "M32.jpg", "Samsung M32", 20000m, 20 },
                    { 5, 3, 1, "This is OnePlus 9 description.", "OnePlus9.jpg", "OnePlus 9", 45000m, 15 },
                    { 6, 2, 4, "This is MacBook Pro description.", "MacBookPro.jpg", "Apple MacBook Pro", 150000m, 8 },
                    { 7, 1, 2, "This is Samsung QLED TV description.", "QLED.jpg", "Samsung QLED 4K TV", 120000m, 12 },
                    { 8, 2, 3, "This is iPad Pro description.", "iPadPro.jpg", "iPad Pro", 120000m, 15 },
                    { 9, 3, 5, "This is OnePlus Buds description.", "OnePlusBuds.jpg", "OnePlus Buds", 8000m, 30 },
                    { 10, 1, 1, "This is Samsung Galaxy S21 description.", "GalaxyS21.jpg", "Samsung Galaxy S21", 80000m, 25 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
