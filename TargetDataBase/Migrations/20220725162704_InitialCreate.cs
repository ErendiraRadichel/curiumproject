using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TargetDataBase.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CS30",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TargetType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarehouseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WarehouseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarehouseCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarehouseLotNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CyclotronDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CyclotronName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CyclotronCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlatingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PlatingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlatingCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlatingLotNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TargetNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BombardingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BombardingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProcessingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessingLotNum = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CS30", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CS30Test",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CS30ID = table.Column<int>(type: "int", nullable: false),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HNum = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CS30Test", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CS30Test_CS30_CS30ID",
                        column: x => x.CS30ID,
                        principalTable: "CS30",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CS30Test_CS30ID",
                table: "CS30Test",
                column: "CS30ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CS30Test");

            migrationBuilder.DropTable(
                name: "CS30");
        }
    }
}
