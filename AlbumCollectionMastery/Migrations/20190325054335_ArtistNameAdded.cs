using Microsoft.EntityFrameworkCore.Migrations;

namespace AlbumCollectionMastery.Migrations
{
    public partial class ArtistNameAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SongArtist",
                table: "Songs",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 1,
                column: "SongArtist",
                value: "Rush");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 2,
                column: "SongArtist",
                value: "Rush");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 3,
                column: "SongArtist",
                value: "Rush");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 4,
                column: "SongArtist",
                value: "Rush");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 5,
                column: "SongArtist",
                value: "Rush");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 6,
                column: "SongArtist",
                value: "Rush");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 7,
                column: "SongArtist",
                value: "Rush");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 8,
                column: "SongArtist",
                value: "Rush");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 9,
                column: "SongArtist",
                value: "Rush");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SongArtist",
                table: "Songs");
        }
    }
}
