using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMVC.Migrations
{
    /// <inheritdoc />
    public partial class InitialSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LIBRARYCARDs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LIBRARYCARDs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BOOKs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Author = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    publishedYear = table.Column<int>(type: "int", nullable: false),
                    librarycardId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOOKs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BOOKs_LIBRARYCARDs_librarycardId",
                        column: x => x.librarycardId,
                        principalTable: "LIBRARYCARDs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BOOKs_ID",
                table: "BOOKs",
                column: "ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BOOKs_librarycardId",
                table: "BOOKs",
                column: "librarycardId");

            migrationBuilder.CreateIndex(
                name: "IX_LIBRARYCARDs_Id",
                table: "LIBRARYCARDs",
                column: "Id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BOOKs");

            migrationBuilder.DropTable(
                name: "LIBRARYCARDs");
        }
    }
}
