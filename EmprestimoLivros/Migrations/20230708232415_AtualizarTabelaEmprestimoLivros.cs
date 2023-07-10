using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmprestimoLivros.Migrations
{
    /// <inheritdoc />
    public partial class AtualizarTabelaEmprestimoLivros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_emprestimolivros",
                table: "emprestimolivros");

            migrationBuilder.RenameTable(
                name: "emprestimolivros",
                newName: "EmprestimoLivros");

            migrationBuilder.RenameColumn(
                name: "LivroEmrpestado",
                table: "EmprestimoLivros",
                newName: "LivroEmprestado");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmprestimoLivros",
                table: "EmprestimoLivros",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EmprestimoLivros",
                table: "EmprestimoLivros");

            migrationBuilder.RenameTable(
                name: "EmprestimoLivros",
                newName: "emprestimolivros");

            migrationBuilder.RenameColumn(
                name: "LivroEmprestado",
                table: "emprestimolivros",
                newName: "LivroEmrpestado");

            migrationBuilder.AddPrimaryKey(
                name: "PK_emprestimolivros",
                table: "emprestimolivros",
                column: "Id");
        }
    }
}
