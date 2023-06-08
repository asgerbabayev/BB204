using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Data.DataAccess.Migrations
{
    public partial class addData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Count", "CreatedBy", "LastModified", "LastModifiedBy", "Name", "Price" },
                values: new object[] { 1, 12, null, null, null, "Test 1", 5m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Count", "CreatedBy", "LastModified", "LastModifiedBy", "Name", "Price" },
                values: new object[] { 2, 12, null, null, null, "Test 2", 5m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Count", "CreatedBy", "LastModified", "LastModifiedBy", "Name", "Price" },
                values: new object[] { 3, 12, null, null, null, "Test 3", 5m });
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
        }
    }
}
