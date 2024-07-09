using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace anot_ai.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoCascade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Etapas_PlanosAcao_PlanoAcaoId",
                table: "Etapas");

            migrationBuilder.DropForeignKey(
                name: "FK_Monitoramentos_Anotacoes_AnotacaoId",
                table: "Monitoramentos");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanosAcao_Anotacoes_AnotacaoId",
                table: "PlanosAcao");

            migrationBuilder.DropForeignKey(
                name: "FK_Smarts_Anotacoes_AnotacaoId",
                table: "Smarts");

            migrationBuilder.AddForeignKey(
                name: "FK_Etapas_PlanosAcao_PlanoAcaoId",
                table: "Etapas",
                column: "PlanoAcaoId",
                principalTable: "PlanosAcao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Monitoramentos_Anotacoes_AnotacaoId",
                table: "Monitoramentos",
                column: "AnotacaoId",
                principalTable: "Anotacoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanosAcao_Anotacoes_AnotacaoId",
                table: "PlanosAcao",
                column: "AnotacaoId",
                principalTable: "Anotacoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Smarts_Anotacoes_AnotacaoId",
                table: "Smarts",
                column: "AnotacaoId",
                principalTable: "Anotacoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Etapas_PlanosAcao_PlanoAcaoId",
                table: "Etapas");

            migrationBuilder.DropForeignKey(
                name: "FK_Monitoramentos_Anotacoes_AnotacaoId",
                table: "Monitoramentos");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanosAcao_Anotacoes_AnotacaoId",
                table: "PlanosAcao");

            migrationBuilder.DropForeignKey(
                name: "FK_Smarts_Anotacoes_AnotacaoId",
                table: "Smarts");

            migrationBuilder.AddForeignKey(
                name: "FK_Etapas_PlanosAcao_PlanoAcaoId",
                table: "Etapas",
                column: "PlanoAcaoId",
                principalTable: "PlanosAcao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Monitoramentos_Anotacoes_AnotacaoId",
                table: "Monitoramentos",
                column: "AnotacaoId",
                principalTable: "Anotacoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanosAcao_Anotacoes_AnotacaoId",
                table: "PlanosAcao",
                column: "AnotacaoId",
                principalTable: "Anotacoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Smarts_Anotacoes_AnotacaoId",
                table: "Smarts",
                column: "AnotacaoId",
                principalTable: "Anotacoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
