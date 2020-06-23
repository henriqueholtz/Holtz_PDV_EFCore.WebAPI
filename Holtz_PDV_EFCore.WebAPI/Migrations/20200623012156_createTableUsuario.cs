using Microsoft.EntityFrameworkCore.Migrations;

namespace Holtz_PDV_EFCore.WebAPI.Migrations
{
    public partial class createTableUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    EmpCod = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpRaz = table.Column<string>(nullable: true),
                    EmpFan = table.Column<string>(nullable: true),
                    EmpCpfCnpj = table.Column<string>(nullable: true),
                    EmpSts = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.EmpCod);
                });

            migrationBuilder.CreateTable(
                name: "Filial",
                columns: table => new
                {
                    EmpCod = table.Column<int>(nullable: false),
                    FilCod = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filial", x => new { x.EmpCod, x.FilCod });
                });

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    EmpCod = table.Column<int>(nullable: false),
                    PesCod = table.Column<int>(nullable: false),
                    PesRaz = table.Column<string>(nullable: true),
                    PesFan = table.Column<string>(nullable: true),
                    PesCpfCnpj = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => new { x.EmpCod, x.PesCod });
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    EmpCod = table.Column<int>(nullable: false),
                    ProCod = table.Column<int>(nullable: false),
                    ProNom = table.Column<string>(nullable: true),
                    ProObs = table.Column<string>(nullable: true),
                    ProNcm = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => new { x.EmpCod, x.ProCod });
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuCod = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuNom = table.Column<string>(nullable: true),
                    UsuSts = table.Column<string>(nullable: true),
                    UsuTip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuCod);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "Filial");

            migrationBuilder.DropTable(
                name: "Pessoa");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
