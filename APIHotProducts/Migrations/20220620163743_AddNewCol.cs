using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIHotProducts.Migrations
{
    public partial class AddNewCol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LotNum",
                table: "Target");

            migrationBuilder.RenameColumn(
                name: "TargetType",
                table: "Target",
                newName: "WStatus");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Target",
                newName: "WName");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Target",
                newName: "WLotNum");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Target",
                newName: "CreationDate");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Target",
                newName: "WCode");

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                table: "Target",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BDate",
                table: "Target",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                name: "BStatus",
                table: "Target",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "C1Code",
                table: "Target",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "C1Date",
                table: "Target",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                name: "C1Status",
                table: "Target",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "C2Code",
                table: "Target",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "C2Date",
                table: "Target",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "C2LotNum",
                table: "Target",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "C2Name",
                table: "Target",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "C2Status",
                table: "Target",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CCode",
                table: "Target",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CDate",
                table: "Target",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CLotNum",
                table: "Target",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CName",
                table: "Target",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CStatus",
                table: "Target",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BCode",
                table: "Target");

            migrationBuilder.DropColumn(
                name: "BDate",
                table: "Target");

            migrationBuilder.DropColumn(
                name: "BLotNum",
                table: "Target");

            migrationBuilder.DropColumn(
                name: "BName",
                table: "Target");

            migrationBuilder.DropColumn(
                name: "BStatus",
                table: "Target");

            migrationBuilder.DropColumn(
                name: "C1Code",
                table: "Target");

            migrationBuilder.DropColumn(
                name: "C1Date",
                table: "Target");

            migrationBuilder.DropColumn(
                name: "C1LotNum",
                table: "Target");

            migrationBuilder.DropColumn(
                name: "C1Name",
                table: "Target");

            migrationBuilder.DropColumn(
                name: "C1Status",
                table: "Target");

            migrationBuilder.DropColumn(
                name: "C2Code",
                table: "Target");

            migrationBuilder.DropColumn(
                name: "C2Date",
                table: "Target");

            migrationBuilder.DropColumn(
                name: "C2LotNum",
                table: "Target");

            migrationBuilder.DropColumn(
                name: "C2Name",
                table: "Target");

            migrationBuilder.DropColumn(
                name: "C2Status",
                table: "Target");

            migrationBuilder.DropColumn(
                name: "CCode",
                table: "Target");

            migrationBuilder.DropColumn(
                name: "CDate",
                table: "Target");

            migrationBuilder.DropColumn(
                name: "CLotNum",
                table: "Target");

            migrationBuilder.DropColumn(
                name: "CName",
                table: "Target");

            migrationBuilder.DropColumn(
                name: "CStatus",
                table: "Target");

            migrationBuilder.RenameColumn(
                name: "WStatus",
                table: "Target",
                newName: "TargetType");

            migrationBuilder.RenameColumn(
                name: "WName",
                table: "Target",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "WLotNum",
                table: "Target",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "WCode",
                table: "Target",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "CreationDate",
                table: "Target",
                newName: "Date");

            migrationBuilder.AddColumn<int>(
                name: "LotNum",
                table: "Target",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
