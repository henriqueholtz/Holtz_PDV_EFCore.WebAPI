using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore.Repo.Migrations
{
    public partial class _002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UsuSts",
                table: "Usuario",
                type: "VARCHAR(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProSts",
                table: "Produto",
                type: "VARCHAR(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PesSts",
                table: "Pessoa",
                type: "VARCHAR(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmpSts",
                table: "Empresa",
                type: "VARCHAR(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 1,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UsuSts",
                table: "Usuario",
                type: "int",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProSts",
                table: "Produto",
                type: "int",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PesSts",
                table: "Pessoa",
                type: "int",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmpSts",
                table: "Empresa",
                type: "int",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(1)",
                oldMaxLength: 1,
                oldNullable: true);
        }
    }
}
