using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BSO_PlakDukkani.Migrations
{
    public partial class besinci : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sanatci",
                table: "Albumler",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sanatci",
                table: "Albumler");
        }
    }
}
