using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace anot_ai.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoEstruturaAnotacaoImplementacaoSmart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AnotacaoId",
                table: "Anotacoes",
                newName: "Id");

            migrationBuilder.CreateTable(
                name: "Monitoramento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Check = table.Column<string>(type: "TEXT", nullable: false),
                    AnotacaoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitoramento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Monitoramento_Anotacoes_AnotacaoId",
                        column: x => x.AnotacaoId,
                        principalTable: "Anotacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanoAcao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AnotacaoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanoAcao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanoAcao_Anotacoes_AnotacaoId",
                        column: x => x.AnotacaoId,
                        principalTable: "Anotacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Smart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Specific = table.Column<string>(type: "TEXT", nullable: false),
                    Measurable = table.Column<string>(type: "TEXT", nullable: false),
                    Achievable = table.Column<string>(type: "TEXT", nullable: false),
                    Relevant = table.Column<string>(type: "TEXT", nullable: false),
                    Time = table.Column<string>(type: "TEXT", nullable: false),
                    AnotacaoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Smart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Smart_Anotacoes_AnotacaoId",
                        column: x => x.AnotacaoId,
                        principalTable: "Anotacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Etapa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NumeroEtapa = table.Column<int>(type: "INTEGER", nullable: false),
                    Acao = table.Column<string>(type: "TEXT", nullable: false),
                    Detalhes = table.Column<string>(type: "TEXT", nullable: false),
                    PlanoAcaoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etapa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Etapa_PlanoAcao_PlanoAcaoId",
                        column: x => x.PlanoAcaoId,
                        principalTable: "PlanoAcao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Etapa_PlanoAcaoId",
                table: "Etapa",
                column: "PlanoAcaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Monitoramento_AnotacaoId",
                table: "Monitoramento",
                column: "AnotacaoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlanoAcao_AnotacaoId",
                table: "PlanoAcao",
                column: "AnotacaoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Smart_AnotacaoId",
                table: "Smart",
                column: "AnotacaoId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Etapa");

            migrationBuilder.DropTable(
                name: "Monitoramento");

            migrationBuilder.DropTable(
                name: "Smart");

            migrationBuilder.DropTable(
                name: "PlanoAcao");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Anotacoes",
                newName: "AnotacaoId");
        }
    }
}
