using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practice2.Migrations
{
    /// <inheritdoc />
    public partial class AddSalary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblSalary",
                columns: table => new
                {
                    SId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SMonth = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SAmount = table.Column<int>(type: "int", nullable: false),
                    SDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblSalary", x => x.SId);
                    table.ForeignKey(
                        name: "FK_TblSalary_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblSalary_EmployeeId",
                table: "TblSalary",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblSalary");
        }
    }
}
