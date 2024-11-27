using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateGameId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GamePlatforms_Platforms_PlatformId1",
                table: "GamePlatforms");

            migrationBuilder.DropIndex(
                name: "IX_GamePlatforms_PlatformId1",
                table: "GamePlatforms");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "StarRatings");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Platforms");

            migrationBuilder.DropColumn(
                name: "PlatformId1",
                table: "GamePlatforms");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "StarRatings",
                newName: "StarRatingId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Platforms",
                newName: "PlatformId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StarRatingId",
                table: "StarRatings",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PlatformId",
                table: "Platforms",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "StarRatings",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Platforms",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PlatformId1",
                table: "GamePlatforms",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GamePlatforms_PlatformId1",
                table: "GamePlatforms",
                column: "PlatformId1");

            migrationBuilder.AddForeignKey(
                name: "FK_GamePlatforms_Platforms_PlatformId1",
                table: "GamePlatforms",
                column: "PlatformId1",
                principalTable: "Platforms",
                principalColumn: "Id");
        }
    }
}
