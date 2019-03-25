using Microsoft.EntityFrameworkCore.Migrations;

namespace AlbumCollectionMastery.Migrations
{
    public partial class ArtistNamesUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 2,
                column: "SongArtist",
                value: "Jimi Hendrix");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 3,
                column: "SongArtist",
                value: "Led Zeppelin");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 4,
                column: "SongArtist",
                value: "Jojo Mayer and the Nerve");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 5,
                column: "SongArtist",
                value: "Dave Brubeck Quartet");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 6,
                column: "SongArtist",
                value: "Dream Theater");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 7,
                column: "SongArtist",
                value: "Vulfpeck");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 8,
                column: "SongArtist",
                value: "KNOWER");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 9,
                column: "SongArtist",
                value: "Vulfpeck f/ Louis Cole");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
