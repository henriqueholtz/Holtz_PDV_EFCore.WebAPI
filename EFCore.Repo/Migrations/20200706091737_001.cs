using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore.Repo.Migrations
{
    public partial class _001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    EmpCod = table.Column<int>(maxLength: 8, nullable: false),
                    EmpRaz = table.Column<string>(maxLength: 130, nullable: true),
                    EmpFan = table.Column<string>(maxLength: 130, nullable: true),
                    EmpCpfCnpj = table.Column<string>(maxLength: 18, nullable: true),
                    EmpSts = table.Column<int>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.EmpCod);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuCod = table.Column<int>(maxLength: 8, nullable: false),
                    UsuNom = table.Column<string>(maxLength: 70, nullable: true),
                    UsuSts = table.Column<int>(maxLength: 1, nullable: true),
                    UsuTip = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuCod);
                });

            migrationBuilder.CreateTable(
                name: "Filial",
                columns: table => new
                {
                    FilCod = table.Column<int>(maxLength: 8, nullable: false),
                    EmpCod = table.Column<int>(maxLength: 8, nullable: false),
                    FilRaz = table.Column<string>(maxLength: 130, nullable: true),
                    FilFan = table.Column<string>(maxLength: 130, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filial", x => x.FilCod);
                    table.ForeignKey(
                        name: "FK_Filial_Empresa_EmpCod",
                        column: x => x.EmpCod,
                        principalTable: "Empresa",
                        principalColumn: "EmpCod",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    PesCod = table.Column<int>(maxLength: 8, nullable: false),
                    EmpCod = table.Column<int>(maxLength: 8, nullable: false),
                    PesRaz = table.Column<string>(maxLength: 130, nullable: true),
                    PesFan = table.Column<string>(maxLength: 130, nullable: true),
                    PesCpfCnpj = table.Column<string>(maxLength: 18, nullable: true),
                    PesSts = table.Column<int>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.PesCod);
                    table.ForeignKey(
                        name: "FK_Pessoa_Empresa_EmpCod",
                        column: x => x.EmpCod,
                        principalTable: "Empresa",
                        principalColumn: "EmpCod",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    ProCod = table.Column<int>(maxLength: 8, nullable: false),
                    EmpCod = table.Column<int>(maxLength: 8, nullable: false),
                    ProNom = table.Column<string>(maxLength: 130, nullable: true),
                    ProObs = table.Column<string>(maxLength: 1000, nullable: true),
                    ProNcm = table.Column<string>(maxLength: 50, nullable: true),
                    ProSts = table.Column<int>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.ProCod);
                    table.ForeignKey(
                        name: "FK_Produto_Empresa_EmpCod",
                        column: x => x.EmpCod,
                        principalTable: "Empresa",
                        principalColumn: "EmpCod",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioEmpresas",
                columns: table => new
                {
                    UsuCod = table.Column<int>(maxLength: 8, nullable: false),
                    EmpCod = table.Column<int>(maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioEmpresas", x => x.UsuCod);
                    table.ForeignKey(
                        name: "FK_UsuarioEmpresas_Empresa_EmpCod",
                        column: x => x.EmpCod,
                        principalTable: "Empresa",
                        principalColumn: "EmpCod",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filial_EmpCod",
                table: "Filial",
                column: "EmpCod");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_EmpCod",
                table: "Pessoa",
                column: "EmpCod");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_EmpCod",
                table: "Produto",
                column: "EmpCod");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioEmpresas_EmpCod",
                table: "UsuarioEmpresas",
                column: "EmpCod");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filial");

            migrationBuilder.DropTable(
                name: "Pessoa");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "UsuarioEmpresas");

            migrationBuilder.DropTable(
                name: "Empresa");
        }
    }
}
