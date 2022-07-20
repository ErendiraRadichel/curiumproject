using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TargetDB.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CS30Curved",
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
                    table.PrimaryKey("PK_CS30Curved", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CS30CurvedTarget",
                columns: table => new
                {
                    CurvedTestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CS30CurvedID = table.Column<int>(type: "int", nullable: false),
                    JigTest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CS30CurvedTarget", x => x.CurvedTestID);
                    table.ForeignKey(
                        name: "FK_CS30CurvedTarget_CS30Curved_CS30CurvedID",
                        column: x => x.CS30CurvedID,
                        principalTable: "CS30Curved",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CS30CurvedTarget_CS30CurvedID",
                table: "CS30CurvedTarget",
                column: "CS30CurvedID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CS30CurvedTarget");

            migrationBuilder.DropTable(
                name: "CS30Curved");
        }
    }
}
