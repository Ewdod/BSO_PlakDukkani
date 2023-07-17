using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BSO_PlakDukkani.Migrations
{
    public partial class Dorduncu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albumler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlbumCikisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AlbumFiyati = table.Column<double>(type: "float", nullable: false),
                    IndirimOrani = table.Column<double>(type: "float", nullable: false),
                    Satistami = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albumler", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albumler");
        }
    }
}
