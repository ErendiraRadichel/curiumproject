using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIHotProducts.Migrations
{
    public partial class AddingNewF : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LotNum",
                table: "Target",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LotNum",
                table: "Target");
        }
    }
}
