using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TargetLifeCycle.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Target",
                columns: table => new
                {
                    TargetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TargetType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Target", x => x.TargetID);
                });

            migrationBuilder.CreateTable(
                name: "Warehouse",
                columns: table => new
                {
                    WarehouseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WarehouseCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarehouseLotNum = table.Column<int>(type: "int", nullable: false),
                    WarehouseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarehouseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TargetID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouse", x => x.WarehouseID);
                    table.ForeignKey(
                        name: "FK_Warehouse_Target_TargetID",
                        column: x => x.TargetID,
                        principalTable: "Target",
                        principalColumn: "TargetID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cyclotron",
                columns: table => new
                {
                    CyclotronID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CyclotronName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CyclotronDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TargetID = table.Column<int>(type: "int", nullable: false),
                    WarehouseID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cyclotron", x => x.CyclotronID);
                    table.ForeignKey(
                        name: "FK_Cyclotron_Target_TargetID",
                        column: x => x.TargetID,
                        principalTable: "Target",
                        principalColumn: "TargetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cyclotron_Warehouse_WarehouseID",
                        column: x => x.WarehouseID,
                        principalTable: "Warehouse",
                        principalColumn: "WarehouseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cyclotron_TargetID",
                table: "Cyclotron",
                column: "TargetID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cyclotron_WarehouseID",
                table: "Cyclotron",
                column: "WarehouseID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Warehouse_TargetID",
                table: "Warehouse",
                column: "TargetID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cyclotron");

            migrationBuilder.DropTable(
                name: "Warehouse");

            migrationBuilder.DropTable(
                name: "Target");
        }
    }
}
