using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TargetDataBase.Migrations
{
    public partial class IBA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IBA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_IBA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "IBATest",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IBAID = table.Column<int>(type: "int", nullable: false),
                    TestType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HNum = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IBATest", x => x.ID);
                    table.ForeignKey(
                        name: "FK_IBATest_IBA_IBAID",
                        column: x => x.IBAID,
                        principalTable: "IBA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IBATest_IBAID",
                table: "IBATest",
                column: "IBAID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IBATest");

            migrationBuilder.DropTable(
                name: "IBA");
        }
    }
}
