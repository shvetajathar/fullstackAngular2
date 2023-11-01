using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMVC.Migrations
{
    /// <inheritdoc />
    public partial class InitialSetUP1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "LIBRARYCARDs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookId",
                table: "LIBRARYCARDs");
        }
    }
}
