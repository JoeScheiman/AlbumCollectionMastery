using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AlbumCollectionMastery.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    AlbumId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlbumTitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.AlbumId);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    SongId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SongTitle = table.Column<string>(nullable: true),
                    AlbumId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.SongId);
                    table.ForeignKey(
                        name: "FK_Songs_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "AlbumId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "AlbumTitle" },
                values: new object[] { 1, "Classic Rock" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "AlbumTitle" },
                values: new object[] { 2, "Programming Tunez" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "AlbumTitle" },
                values: new object[] { 3, "Funky-ish" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "AlbumId", "SongTitle" },
                values: new object[,]
                {
                    { 1, 1, "Tom Sawyer" },
                    { 2, 1, "All Along the Watchtower" },
                    { 3, 1, "Dazed and Confused" },
                    { 5, 1, "Take Five" },
                    { 6, 1, "Stream of Consciousness" },
                    { 7, 1, "Dean Town" },
                    { 8, 1, "Time Traveler" },
                    { 9, 1, "It Gets Funkier IV" },
                    { 4, 2, "Jabon" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Songs_AlbumId",
                table: "Songs",
                column: "AlbumId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Albums");
        }
    }
}
