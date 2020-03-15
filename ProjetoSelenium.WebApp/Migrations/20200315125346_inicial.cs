using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoSelenium.WebApp.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Interessada",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interessada", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: false),
                    Senha = table.Column<string>(nullable: false),
                    InteressadaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Interessada_InteressadaId",
                        column: x => x.InteressadaId,
                        principalTable: "Interessada",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Favoritos",
                columns: table => new
                {
                    IdLeilao = table.Column<int>(nullable: false),
                    IdInteressada = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favoritos", x => new { x.IdLeilao, x.IdInteressada });
                    table.ForeignKey(
                        name: "FK_Favoritos_Interessada_IdInteressada",
                        column: x => x.IdInteressada,
                        principalTable: "Interessada",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lance",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<double>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false),
                    LeilaoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lance_Interessada_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Interessada",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Leiloes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(nullable: false),
                    Categoria = table.Column<string>(nullable: false),
                    Imagem = table.Column<string>(nullable: false),
                    ValorInicial = table.Column<double>(nullable: false),
                    InicioPregao = table.Column<DateTime>(nullable: false),
                    TerminoPregao = table.Column<DateTime>(nullable: false),
                    Estado = table.Column<string>(nullable: false),
                    GanhadorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leiloes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leiloes_Lance_GanhadorId",
                        column: x => x.GanhadorId,
                        principalTable: "Lance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Interessada",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Fulano de Tal" },
                    { 2, "Mariana Mary" },
                    { 3, "Sicrana Silva" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Email", "InteressadaId", "Senha" },
                values: new object[] { 3, "admin@example.org", null, "123" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Email", "InteressadaId", "Senha" },
                values: new object[] { 1, "fulano@example.org", 1, "123" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Email", "InteressadaId", "Senha" },
                values: new object[] { 2, "mariana@example.org", 2, "456" });

            migrationBuilder.CreateIndex(
                name: "IX_Favoritos_IdInteressada",
                table: "Favoritos",
                column: "IdInteressada");

            migrationBuilder.CreateIndex(
                name: "IX_Lance_ClienteId",
                table: "Lance",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Lance_LeilaoId",
                table: "Lance",
                column: "LeilaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Leiloes_GanhadorId",
                table: "Leiloes",
                column: "GanhadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_InteressadaId",
                table: "Usuarios",
                column: "InteressadaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Favoritos_Leiloes_IdLeilao",
                table: "Favoritos",
                column: "IdLeilao",
                principalTable: "Leiloes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lance_Leiloes_LeilaoId",
                table: "Lance",
                column: "LeilaoId",
                principalTable: "Leiloes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lance_Interessada_ClienteId",
                table: "Lance");

            migrationBuilder.DropForeignKey(
                name: "FK_Lance_Leiloes_LeilaoId",
                table: "Lance");

            migrationBuilder.DropTable(
                name: "Favoritos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Interessada");

            migrationBuilder.DropTable(
                name: "Leiloes");

            migrationBuilder.DropTable(
                name: "Lance");
        }
    }
}
