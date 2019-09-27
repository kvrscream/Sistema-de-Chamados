using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace avaliacao.Data.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CpfCnpj = table.Column<string>(type: "VARCHAR", maxLength: 14, nullable: true),
                    RazaoSocialNome = table.Column<string>(type: "VARCHAR", maxLength: 60, nullable: true),
                    CEP = table.Column<string>(type: "VARCHAR", maxLength: 8, nullable: true),
                    Logradouro = table.Column<string>(type: "VARCHAR", maxLength: 60, nullable: true),
                    LogradouroNumero = table.Column<int>(type: "VARCHAR", maxLength: 10, nullable: false),
                    LogradouroComplemento = table.Column<string>(type: "VARCHAR", maxLength: 60, nullable: true),
                    LogradouroBairro = table.Column<string>(type: "VARCHAR", maxLength: 60, nullable: true),
                    LogradouroCidade = table.Column<string>(type: "VARCHAR", maxLength: 60, nullable: true),
                    LogradouroUF = table.Column<string>(type: "VARCHAR", maxLength: 2, nullable: true),
                    Telefone = table.Column<string>(type: "VARCHAR", maxLength: 12, nullable: true),
                    SLARespostaTempo = table.Column<int>(nullable: false, defaultValue: 4)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chamados",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    clienteId = table.Column<long>(nullable: true),
                    DataHoraAbertura = table.Column<DateTime>(nullable: false),
                    Fechado = table.Column<bool>(nullable: false, defaultValue: false),
                    DataHoraFechamento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chamados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chamados_Clientes_clienteId",
                        column: x => x.clienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chamados_clienteId",
                table: "Chamados",
                column: "clienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chamados");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
