using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GameAPI.Migrations
{
    /// <inheritdoc />
    public partial class CreateGamePlatformTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_StarRatings_StarRatingId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Platforms_Games_GameId",
                table: "Platforms");

            migrationBuilder.DropTable(
                name: "StarRatings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Platforms",
                table: "Platforms");

            migrationBuilder.DropIndex(
                name: "IX_Platforms_GameId",
                table: "Platforms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Games",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_StarRatingId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "Platforms");

            migrationBuilder.RenameTable(
                name: "Platforms",
                newName: "platforms");

            migrationBuilder.RenameTable(
                name: "Games",
                newName: "games");

            migrationBuilder.RenameColumn(
                name: "StarRatingId",
                table: "games",
                newName: "NbRates");

            migrationBuilder.AddColumn<decimal>(
                name: "Rate",
                table: "games",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_platforms",
                table: "platforms",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_games",
                table: "games",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "game_platform",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "integer", nullable: false),
                    PlatformId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_game_platform", x => new { x.GameId, x.PlatformId });
                    table.ForeignKey(
                        name: "FK_game_platform_games_GameId",
                        column: x => x.GameId,
                        principalTable: "games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_game_platform_platforms_PlatformId",
                        column: x => x.PlatformId,
                        principalTable: "platforms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_game_platform_PlatformId",
                table: "game_platform",
                column: "PlatformId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "game_platform");

            migrationBuilder.DropPrimaryKey(
                name: "PK_platforms",
                table: "platforms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_games",
                table: "games");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "games");

            migrationBuilder.RenameTable(
                name: "platforms",
                newName: "Platforms");

            migrationBuilder.RenameTable(
                name: "games",
                newName: "Games");

            migrationBuilder.RenameColumn(
                name: "NbRates",
                table: "Games",
                newName: "StarRatingId");

            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "Platforms",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Platforms",
                table: "Platforms",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Games",
                table: "Games",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "StarRatings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NbRates = table.Column<int>(type: "integer", nullable: false),
                    Rate = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StarRatings", x => x.Id);
                });

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
    }
}
