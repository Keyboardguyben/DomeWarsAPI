using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DomeWarsDAL.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Business_Territory_TerritoryId",
                table: "Business");

            migrationBuilder.DropForeignKey(
                name: "FK_Gang_Game_GameId",
                table: "Gang");

            migrationBuilder.DropForeignKey(
                name: "FK_Gang_Player_PlayerId",
                table: "Gang");

            migrationBuilder.DropForeignKey(
                name: "FK_Territory_Game_GameId",
                table: "Territory");

            migrationBuilder.AlterColumn<int>(
                name: "TerritoryId",
                table: "Unit",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GameId",
                table: "Territory",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PlayerId",
                table: "Gang",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GameId",
                table: "Gang",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TerritoryId",
                table: "Business",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_GangId",
                table: "Unit",
                column: "GangId");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_TerritoryId",
                table: "Unit",
                column: "TerritoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Business_Territory_TerritoryId",
                table: "Business",
                column: "TerritoryId",
                principalTable: "Territory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Gang_Game_GameId",
                table: "Gang",
                column: "GameId",
                principalTable: "Game",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Gang_Player_PlayerId",
                table: "Gang",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Territory_Game_GameId",
                table: "Territory",
                column: "GameId",
                principalTable: "Game",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Unit_Gang_GangId",
                table: "Unit",
                column: "GangId",
                principalTable: "Gang",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Unit_Territory_TerritoryId",
                table: "Unit",
                column: "TerritoryId",
                principalTable: "Territory",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Business_Territory_TerritoryId",
                table: "Business");

            migrationBuilder.DropForeignKey(
                name: "FK_Gang_Game_GameId",
                table: "Gang");

            migrationBuilder.DropForeignKey(
                name: "FK_Gang_Player_PlayerId",
                table: "Gang");

            migrationBuilder.DropForeignKey(
                name: "FK_Territory_Game_GameId",
                table: "Territory");

            migrationBuilder.DropForeignKey(
                name: "FK_Unit_Gang_GangId",
                table: "Unit");

            migrationBuilder.DropForeignKey(
                name: "FK_Unit_Territory_TerritoryId",
                table: "Unit");

            migrationBuilder.DropIndex(
                name: "IX_Unit_GangId",
                table: "Unit");

            migrationBuilder.DropIndex(
                name: "IX_Unit_TerritoryId",
                table: "Unit");

            migrationBuilder.AlterColumn<int>(
                name: "TerritoryId",
                table: "Unit",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GameId",
                table: "Territory",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PlayerId",
                table: "Gang",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GameId",
                table: "Gang",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TerritoryId",
                table: "Business",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Business_Territory_TerritoryId",
                table: "Business",
                column: "TerritoryId",
                principalTable: "Territory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gang_Game_GameId",
                table: "Gang",
                column: "GameId",
                principalTable: "Game",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gang_Player_PlayerId",
                table: "Gang",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Territory_Game_GameId",
                table: "Territory",
                column: "GameId",
                principalTable: "Game",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
