using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TargetDataBase.Migrations
{
    public partial class TR30 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TR30",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarehouseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WarehouseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WFaceCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WBodyCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WFaceLotNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WBodyLotNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CyclotronDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CyclotronName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CFaceCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CBodyCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_TR30", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TR30Test",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TR30ID = table.Column<int>(type: "int", nullable: false),
                    TestType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HNum = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TR30Test", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TR30Test_TR30_TR30ID",
                        column: x => x.TR30ID,
                        principalTable: "TR30",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TR30Test_TR30ID",
                table: "TR30Test",
                column: "TR30ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TR30Test");

            migrationBuilder.DropTable(
                name: "TR30");
        }
    }
}
