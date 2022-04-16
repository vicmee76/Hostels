using Microsoft.EntityFrameworkCore.Migrations;

namespace Hostels.Migrations
{
    public partial class updatedRoleName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RoleName",
                table: "Roles",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 10);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RoleName",
                table: "Roles",
                type: "int",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10);
        }
    }
}
