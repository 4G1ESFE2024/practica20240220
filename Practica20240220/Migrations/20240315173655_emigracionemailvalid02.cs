using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practica20240220.Migrations
{
    public partial class emigracionemailvalid02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "ValidEmail",
                table: "Usuarios",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "ValidEmail",
                value: (byte)1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValidEmail",
                table: "Usuarios");
        }
    }
}
