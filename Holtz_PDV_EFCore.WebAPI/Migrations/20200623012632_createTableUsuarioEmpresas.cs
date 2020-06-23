using Microsoft.EntityFrameworkCore.Migrations;

namespace Holtz_PDV_EFCore.WebAPI.Migrations
{
    public partial class createTableUsuarioEmpresas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsuarioEmpresas",
                columns: table => new
                {
                    UsuCod = table.Column<int>(nullable: false),
                    EmpCod = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioEmpresas", x => new { x.UsuCod, x.EmpCod });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsuarioEmpresas");
        }
    }
}
