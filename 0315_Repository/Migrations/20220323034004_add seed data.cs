using Microsoft.EntityFrameworkCore.Migrations;

namespace _0315_Repository.Migrations
{
    public partial class addseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreateUser", "IsPromotion", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "A", false, "蛋糕", 10m },
                    { 2, "A", true, "餅乾", 20m },
                    { 3, "A", false, "蛋塔", 30m },
                    { 4, "B", true, "奶酪", 40m },
                    { 5, "B", false, "蛋捲", 50m },
                    { 6, "B", true, "飲料", 60m }
                });
        }

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
        }
    }
}
