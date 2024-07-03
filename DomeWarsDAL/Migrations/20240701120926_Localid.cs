using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DomeWarsDAL.Migrations
{
    /// <inheritdoc />
    public partial class Localid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Territory",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Territory");
        }
    }
}
