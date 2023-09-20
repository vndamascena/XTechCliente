using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XTechCliente.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CLIENTE",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    EMAIL = table.Column<string>(name: "E-MAIL", type: "nvarchar(max)", nullable: false),
                    DATANASCIMENTO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATACRIACAO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATAULTIMAATUALIZACAO = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENTE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HISTORICOATIVIDADE",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DATAHORA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TIPO = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HISTORICOATIVIDADE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HISTORICOATIVIDADE_CLIENTE_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "CLIENTE",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_HISTORICOATIVIDADE_ClienteId",
                table: "HISTORICOATIVIDADE",
                column: "ClienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HISTORICOATIVIDADE");

            migrationBuilder.DropTable(
                name: "CLIENTE");
        }
    }
}
