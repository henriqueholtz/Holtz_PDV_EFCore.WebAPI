using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore.Repo.Migrations
{
    public partial class _003 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UsuTip",
                table: "Usuario",
                type: "VARCHAR(1)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UsuNom",
                table: "Usuario",
                type: "VARCHAR(75)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProObs",
                table: "Produto",
                type: "VARCHAR(1000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProNom",
                table: "Produto",
                type: "VARCHAR(150)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(130)",
                oldMaxLength: 130,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProNcm",
                table: "Produto",
                type: "VARCHAR(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PesRaz",
                table: "Pessoa",
                type: "VARCHAR(150)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(130)",
                oldMaxLength: 130,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PesFan",
                table: "Pessoa",
                type: "VARCHAR(150)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(130)",
                oldMaxLength: 130,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PesCpfCnpj",
                table: "Pessoa",
                type: "VARCHAR(18)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FilRaz",
                table: "Filial",
                type: "VARCHAR(150)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(130)",
                oldMaxLength: 130,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FilFan",
                table: "Filial",
                type: "VARCHAR(150)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(130)",
                oldMaxLength: 130,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmpRaz",
                table: "Empresa",
                type: "VARCHAR(150)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(130)",
                oldMaxLength: 130,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmpFan",
                table: "Empresa",
                type: "VARCHAR(150)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(130)",
                oldMaxLength: 130,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmpCpfCnpj",
                table: "Empresa",
                type: "VARCHAR(18)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    MarCod = table.Column<int>(maxLength: 8, nullable: false),
                    EmpCod = table.Column<int>(maxLength: 8, nullable: false),
                    MarNom = table.Column<string>(type: "VARCHAR(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.MarCod);
                    table.ForeignKey(
                        name: "FK_Marca_Empresa_EmpCod",
                        column: x => x.EmpCod,
                        principalTable: "Empresa",
                        principalColumn: "EmpCod",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Marca_EmpCod",
                table: "Marca",
                column: "EmpCod");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Marca");

            migrationBuilder.AlterColumn<string>(
                name: "UsuTip",
                table: "Usuario",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UsuNom",
                table: "Usuario",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(75)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProObs",
                table: "Produto",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(1000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProNom",
                table: "Produto",
                type: "nvarchar(130)",
                maxLength: 130,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(150)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProNcm",
                table: "Produto",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PesRaz",
                table: "Pessoa",
                type: "nvarchar(130)",
                maxLength: 130,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(150)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PesFan",
                table: "Pessoa",
                type: "nvarchar(130)",
                maxLength: 130,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(150)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PesCpfCnpj",
                table: "Pessoa",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(18)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FilRaz",
                table: "Filial",
                type: "nvarchar(130)",
                maxLength: 130,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(150)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FilFan",
                table: "Filial",
                type: "nvarchar(130)",
                maxLength: 130,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(150)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmpRaz",
                table: "Empresa",
                type: "nvarchar(130)",
                maxLength: 130,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(150)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmpFan",
                table: "Empresa",
                type: "nvarchar(130)",
                maxLength: 130,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(150)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmpCpfCnpj",
                table: "Empresa",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(18)",
                oldNullable: true);
        }
    }
}
