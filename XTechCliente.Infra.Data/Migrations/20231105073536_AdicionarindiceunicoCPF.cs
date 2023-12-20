using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XTechCliente.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarindiceunicoCPF : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "E-MAIL",
                table: "CLIENTE",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_CLIENTE_CPF",
                table: "CLIENTE",
                column: "CPF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CLIENTE_E-MAIL",
                table: "CLIENTE",
                column: "E-MAIL",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CLIENTE_CPF",
                table: "CLIENTE");

            migrationBuilder.DropIndex(
                name: "IX_CLIENTE_E-MAIL",
                table: "CLIENTE");

            migrationBuilder.AlterColumn<string>(
                name: "E-MAIL",
                table: "CLIENTE",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
