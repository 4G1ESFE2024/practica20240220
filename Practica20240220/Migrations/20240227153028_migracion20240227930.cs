using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practica20240220.Migrations
{
    public partial class migracion20240227930 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Apellido", "Email", "Estatus", "Nombre", "Password", "Rol" },
                values: new object[] { 1, "admin", "root@gmail.com", (byte)1, "root", "e10adc3949ba59abbe56e057f20f883e", "Administrador" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
