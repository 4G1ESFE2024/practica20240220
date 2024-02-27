using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practica20240220.Migrations
{
    public partial class migracion202402271005 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comentario",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comentario",
                table: "Usuarios");
        }
    }
}
