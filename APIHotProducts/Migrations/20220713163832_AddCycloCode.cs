using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIHotProducts.Migrations
{
    public partial class AddCycloCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CyclotronCode",
                table: "Target",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CyclotronCode",
                table: "Target");
        }
    }
}
