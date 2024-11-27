using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StarRatings_Games_GameId",
                table: "StarRatings");

            migrationBuilder.DropTable(
                name: "GamePlatforms");

            migrationBuilder.DropIndex(
                name: "IX_StarRatings_GameId",
                table: "StarRatings");

            migrationBuilder.DropColumn(
                name: "Review",
                table: "StarRatings");

            migrationBuilder.RenameColumn(
                name: "GameId",
                table: "StarRatings",
                newName: "NbRates");

            migrationBuilder.RenameColumn(
                name: "StarRatingId",
                table: "StarRatings",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PlatformId",
                table: "Platforms",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Games",
                newName: "Name");

            migrationBuilder.AddColumn<double>(
                name: "Rate",
                table: "StarRatings",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Platforms",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "Platforms",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StarRatingId",
                table: "Games",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Platforms_GameId",
                table: "Platforms",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_StarRatingId",
                table: "Games",
                column: "StarRatingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_StarRatings_StarRatingId",
                table: "Games",
                column: "StarRatingId",
                principalTable: "StarRatings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Platforms_Games_GameId",
                table: "Platforms",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_StarRatings_StarRatingId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Platforms_Games_GameId",
                table: "Platforms");

            migrationBuilder.DropIndex(
                name: "IX_Platforms_GameId",
                table: "Platforms");

            migrationBuilder.DropIndex(
                name: "IX_Games_StarRatingId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "StarRatings");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Platforms");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "Platforms");

            migrationBuilder.DropColumn(
                name: "StarRatingId",
                table: "Games");

            migrationBuilder.RenameColumn(
                name: "NbRates",
                table: "StarRatings",
                newName: "GameId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "StarRatings",
                newName: "StarRatingId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Platforms",
                newName: "PlatformId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Games",
                newName: "Title");

            migrationBuilder.AddColumn<string>(
                name: "Review",
                table: "StarRatings",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "GamePlatforms",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "integer", nullable: false),
                    PlatformId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamePlatforms", x => new { x.GameId, x.PlatformId });
                    table.ForeignKey(
                        name: "FK_GamePlatforms_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GamePlatforms_Platforms_PlatformId",
                        column: x => x.PlatformId,
                        principalTable: "Platforms",
                        principalColumn: "PlatformId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StarRatings_GameId",
                table: "StarRatings",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GamePlatforms_PlatformId",
                table: "GamePlatforms",
                column: "PlatformId");

            migrationBuilder.AddForeignKey(
                name: "FK_StarRatings_Games_GameId",
                table: "StarRatings",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
