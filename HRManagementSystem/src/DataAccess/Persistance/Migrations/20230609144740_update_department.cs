using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRManagementSystem.DataAccess.Persistance.Migrations
{
    public partial class update_department : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Departments_DepartmentId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_DepartmentId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Departments");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_SupDepartmentId",
                table: "Departments",
                column: "SupDepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Departments_SupDepartmentId",
                table: "Departments",
                column: "SupDepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Departments_SupDepartmentId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_SupDepartmentId",
                table: "Departments");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_DepartmentId",
                table: "Departments",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Departments_DepartmentId",
                table: "Departments",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");
        }
    }
}
