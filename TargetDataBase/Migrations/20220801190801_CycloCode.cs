using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TargetDataBase.Migrations
{
    public partial class CycloCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CBodyCode",
                table: "TR30",
                newName: "CycloCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CycloCode",
                table: "TR30",
                newName: "CBodyCode");
        }
    }
}
