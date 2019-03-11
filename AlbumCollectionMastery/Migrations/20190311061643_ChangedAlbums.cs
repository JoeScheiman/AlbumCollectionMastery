using Microsoft.EntityFrameworkCore.Migrations;

namespace AlbumCollectionMastery.Migrations
{
    public partial class ChangedAlbums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 5,
                column: "AlbumId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 6,
                column: "AlbumId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 7,
                column: "AlbumId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 8,
                column: "AlbumId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 9,
                column: "AlbumId",
                value: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 5,
                column: "AlbumId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 6,
                column: "AlbumId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 7,
                column: "AlbumId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 8,
                column: "AlbumId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 9,
                column: "AlbumId",
                value: 1);
        }
    }
}
