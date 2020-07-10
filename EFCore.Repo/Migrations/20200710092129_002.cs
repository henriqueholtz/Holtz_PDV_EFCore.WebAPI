using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore.Repo.Migrations
{
    public partial class _002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "UsuTip",
                table: "Usuario",
                type: "TINYINT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(1)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UsuTip",
                table: "Usuario",
                type: "VARCHAR(1)",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "TINYINT",
                oldNullable: true);
        }
    }
}
