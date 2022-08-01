using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TargetDataBase.Migrations
{
    public partial class CBodyC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CBodyCode",
                table: "TR30",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CBodyCode",
                table: "TR30");
        }
    }
}
