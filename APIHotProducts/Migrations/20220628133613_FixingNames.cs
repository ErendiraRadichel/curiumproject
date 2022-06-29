using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIHotProducts.Migrations
{
    public partial class FixingNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BCode",
                table: "Target");

            migrationBuilder.DropColumn(
                name: "BLotNum",
                table: "Target");

            migrationBuilder.DropColumn(
                name: "BName",
                table: "Target");

            migrationBuilder.DropColumn(
                name: "C1Code",
                table: "Target");

            migrationBuilder.DropColumn(
                name: "C1LotNum",
                table: "Target");

            migrationBuilder.DropColumn(
                name: "C1Name",
                table: "Target");

            migrationBuilder.DropColumn(
                name: "C2Code",
                table: "Target");

            migrationBuilder.RenameColumn(
                name: "WName",
                table: "Target",
                newName: "WarehouseName");

            migrationBuilder.RenameColumn(
                name: "WLotNum",
                table: "Target",
                newName: "WarehouseCode");

            migrationBuilder.RenameColumn(
                name: "WCode",
                table: "Target",
                newName: "TargetType");

            migrationBuilder.RenameColumn(
                name: "Product",
                table: "Target",
                newName: "ProductName");

            migrationBuilder.RenameColumn(
                name: "CreationDate",
                table: "Target",
                newName: "WarehouseDate");

            migrationBuilder.RenameColumn(
                name: "CName",
                table: "Target",
                newName: "ProcessingName");

            migrationBuilder.RenameColumn(
                name: "CLotNum",
                table: "Target",
                newName: "PlatingName");

            migrationBuilder.RenameColumn(
                name: "CDate",
                table: "Target",
                newName: "ProcessingDate");

            migrationBuilder.RenameColumn(
                name: "CCode",
                table: "Target",
                newName: "PlatingCode");

            migrationBuilder.RenameColumn(
                name: "C2Name",
                table: "Target",
                newName: "CyclotronName");

            migrationBuilder.RenameColumn(
                name: "C2LotNum",
                table: "Target",
                newName: "BombardingName");

            migrationBuilder.RenameColumn(
                name: "C2Date",
                table: "Target",
                newName: "PlatingDate");

            migrationBuilder.RenameColumn(
                name: "C1Date",
                table: "Target",
                newName: "CyclotronDate");

            migrationBuilder.RenameColumn(
                name: "BDate",
                table: "Target",
                newName: "BombardingDate");

            migrationBuilder.AddColumn<int>(
                name: "PlatingLotNum",
                table: "Target",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TargetNum",
                table: "Target",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WarehouseLotNum",
                table: "Target",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlatingLotNum",
                table: "Target");

            migrationBuilder.DropColumn(
                name: "TargetNum",
                table: "Target");

            migrationBuilder.DropColumn(
                name: "WarehouseLotNum",
                table: "Target");

            migrationBuilder.RenameColumn(
                name: "WarehouseName",
                table: "Target",
                newName: "WName");

            migrationBuilder.RenameColumn(
                name: "WarehouseDate",
                table: "Target",
                newName: "CreationDate");

            migrationBuilder.RenameColumn(
                name: "WarehouseCode",
                table: "Target",
                newName: "WLotNum");

            migrationBuilder.RenameColumn(
                name: "TargetType",
                table: "Target",
                newName: "WCode");

            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "Target",
                newName: "Product");

            migrationBuilder.RenameColumn(
                name: "ProcessingName",
                table: "Target",
                newName: "CName");

            migrationBuilder.RenameColumn(
                name: "ProcessingDate",
                table: "Target",
                newName: "CDate");

            migrationBuilder.RenameColumn(
                name: "PlatingName",
                table: "Target",
                newName: "CLotNum");

            migrationBuilder.RenameColumn(
                name: "PlatingDate",
                table: "Target",
                newName: "C2Date");

            migrationBuilder.RenameColumn(
                name: "PlatingCode",
                table: "Target",
                newName: "CCode");

            migrationBuilder.RenameColumn(
                name: "CyclotronName",
                table: "Target",
                newName: "C2Name");

            migrationBuilder.RenameColumn(
                name: "CyclotronDate",
                table: "Target",
                newName: "C1Date");

            migrationBuilder.RenameColumn(
                name: "BombardingName",
                table: "Target",
                newName: "C2LotNum");

            migrationBuilder.RenameColumn(
                name: "BombardingDate",
                table: "Target",
                newName: "BDate");

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                table: "Target",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BLotNum",
                table: "Target",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BName",
                table: "Target",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "C1Code",
                table: "Target",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "C1LotNum",
                table: "Target",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "C1Name",
                table: "Target",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "C2Code",
                table: "Target",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
