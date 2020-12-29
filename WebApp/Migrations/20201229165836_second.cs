using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sales",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    beginDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    duration = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    touristId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    agentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    tourId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sales", x => x.id);
                    table.ForeignKey(
                        name: "FK_sales_Employees_agentId",
                        column: x => x.agentId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_sales_touristProfiles_touristId",
                        column: x => x.touristId,
                        principalTable: "touristProfiles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sales_tours_tourId",
                        column: x => x.tourId,
                        principalTable: "tours",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_sales_agentId",
                table: "sales",
                column: "agentId");

            migrationBuilder.CreateIndex(
                name: "IX_sales_tourId",
                table: "sales",
                column: "tourId");

            migrationBuilder.CreateIndex(
                name: "IX_sales_touristId",
                table: "sales",
                column: "touristId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sales");
        }
    }
}
