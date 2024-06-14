using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_Access_Layer.Migrations
{
    /// <inheritdoc />
    public partial class Napalm2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlbumKullanicilar_Albumler_AlbumId",
                table: "AlbumKullanicilar");

            migrationBuilder.DropForeignKey(
                name: "FK_AlbumKullanicilar_Kullanicilar_KullaniciId",
                table: "AlbumKullanicilar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AlbumKullanicilar",
                table: "AlbumKullanicilar");

            migrationBuilder.RenameTable(
                name: "AlbumKullanicilar",
                newName: "AlbumKullanıcılar");

            migrationBuilder.RenameIndex(
                name: "IX_AlbumKullanicilar_KullaniciId",
                table: "AlbumKullanıcılar",
                newName: "IX_AlbumKullanıcılar_KullaniciId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AlbumKullanıcılar",
                table: "AlbumKullanıcılar",
                columns: new[] { "AlbumId", "KullaniciId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AlbumKullanıcılar_Albumler_AlbumId",
                table: "AlbumKullanıcılar",
                column: "AlbumId",
                principalTable: "Albumler",
                principalColumn: "AlbumId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AlbumKullanıcılar_Kullanicilar_KullaniciId",
                table: "AlbumKullanıcılar",
                column: "KullaniciId",
                principalTable: "Kullanicilar",
                principalColumn: "KullaniciId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlbumKullanıcılar_Albumler_AlbumId",
                table: "AlbumKullanıcılar");

            migrationBuilder.DropForeignKey(
                name: "FK_AlbumKullanıcılar_Kullanicilar_KullaniciId",
                table: "AlbumKullanıcılar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AlbumKullanıcılar",
                table: "AlbumKullanıcılar");

            migrationBuilder.RenameTable(
                name: "AlbumKullanıcılar",
                newName: "AlbumKullanicilar");

            migrationBuilder.RenameIndex(
                name: "IX_AlbumKullanıcılar_KullaniciId",
                table: "AlbumKullanicilar",
                newName: "IX_AlbumKullanicilar_KullaniciId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AlbumKullanicilar",
                table: "AlbumKullanicilar",
                columns: new[] { "AlbumId", "KullaniciId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AlbumKullanicilar_Albumler_AlbumId",
                table: "AlbumKullanicilar",
                column: "AlbumId",
                principalTable: "Albumler",
                principalColumn: "AlbumId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AlbumKullanicilar_Kullanicilar_KullaniciId",
                table: "AlbumKullanicilar",
                column: "KullaniciId",
                principalTable: "Kullanicilar",
                principalColumn: "KullaniciId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
