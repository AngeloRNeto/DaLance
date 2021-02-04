using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DaLance.Entity.Migrations
{
    public partial class Init_Migrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "produtos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    data_alteracao = table.Column<DateTime>(nullable: false),
                    data_criacao = table.Column<DateTime>(nullable: false),
                    situacao = table.Column<int>(nullable: false),
                    nome = table.Column<string>(nullable: true),
                    valor = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    data_alteracao = table.Column<DateTime>(nullable: false),
                    data_criacao = table.Column<DateTime>(nullable: false),
                    situacao = table.Column<int>(nullable: false),
                    nome = table.Column<string>(nullable: true),
                    idade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "lances",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    data_alteracao = table.Column<DateTime>(nullable: false),
                    data_criacao = table.Column<DateTime>(nullable: false),
                    situacao = table.Column<int>(nullable: false),
                    produtoid = table.Column<int>(nullable: true),
                    usuarioid = table.Column<int>(nullable: true),
                    valor = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lances", x => x.id);
                    table.ForeignKey(
                        name: "FK_lances_produtos_produtoid",
                        column: x => x.produtoid,
                        principalTable: "produtos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_lances_usuarios_usuarioid",
                        column: x => x.usuarioid,
                        principalTable: "usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_lances_produtoid",
                table: "lances",
                column: "produtoid");

            migrationBuilder.CreateIndex(
                name: "IX_lances_usuarioid",
                table: "lances",
                column: "usuarioid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "lances");

            migrationBuilder.DropTable(
                name: "produtos");

            migrationBuilder.DropTable(
                name: "usuarios");
        }
    }
}
