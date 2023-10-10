using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APIWeb.Data.Migrations
{
    public partial class CriarTabelasBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Passageiro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomePassageiro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailPassageiro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Residencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Passageiro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_Aeroporto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Origem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Destino = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Passageiro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Aeroporto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Aeroporto_tb_Passageiro_Id_Passageiro",
                        column: x => x.Id_Passageiro,
                        principalTable: "tb_Passageiro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Aviao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Companhia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Poltrona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroVoo = table.Column<int>(type: "int", nullable: false),
                    DataPartida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataChegada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_Aeroporto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Aviao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Aviao_tb_Aeroporto_Id_Aeroporto",
                        column: x => x.Id_Aeroporto,
                        principalTable: "tb_Aeroporto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Pagamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Preco = table.Column<float>(type: "real", nullable: false),
                    QtdePassageiro = table.Column<int>(type: "int", nullable: false),
                    Id_Aviao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Pagamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Pagamento_tb_Aviao_Id_Aviao",
                        column: x => x.Id_Aviao,
                        principalTable: "tb_Aviao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Aeroporto_Id_Passageiro",
                table: "tb_Aeroporto",
                column: "Id_Passageiro");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Aviao_Id_Aeroporto",
                table: "tb_Aviao",
                column: "Id_Aeroporto");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Pagamento_Id_Aviao",
                table: "tb_Pagamento",
                column: "Id_Aviao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Pagamento");

            migrationBuilder.DropTable(
                name: "tb_Aviao");

            migrationBuilder.DropTable(
                name: "tb_Aeroporto");

            migrationBuilder.DropTable(
                name: "tb_Passageiro");
        }
    }
}
