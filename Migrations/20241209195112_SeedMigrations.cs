using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ListagemAPi.Migrations
{
    /// <inheritdoc />
    public partial class SeedMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "senha",
                table: "Administradores",
                newName: "Senha");

            migrationBuilder.InsertData(
                table: "Administradores",
                columns: new[] { "Id", "Email", "Perfil", "Senha" },
                values: new object[] { 0, "Adm@teste.com", "Adm", "123456" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Administradores",
                keyColumn: "Id",
                keyValue: 0);

            migrationBuilder.RenameColumn(
                name: "Senha",
                table: "Administradores",
                newName: "senha");
        }
    }
}
