using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Senai.Repository.Migrations
{
    public partial class mudeionomedocampoNOmedaescola : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Escola",
                newName: "Nome");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Escola",
                newName: "nome");
        }
    }
}
