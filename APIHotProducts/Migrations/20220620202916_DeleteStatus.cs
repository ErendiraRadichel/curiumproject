using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIHotProducts.Migrations
{
    public partial class DeleteStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BStatus",
                table: "Target");

            migrationBuilder.DropColumn(
                name: "C1Status",
                table: "Target");

            migrationBuilder.DropColumn(
                name: "C2Status",
                table: "Target");

            migrationBuilder.DropColumn(
                name: "CStatus",
                table: "Target");

            migrationBuilder.RenameColumn(
                name: "WStatus",
                table: "Target",
                newName: "Status");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Target",
                newName: "WStatus");

            migrationBuilder.AddColumn<string>(
                name: "BStatus",
                table: "Target",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "C1Status",
                table: "Target",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "C2Status",
                table: "Target",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CStatus",
                table: "Target",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
