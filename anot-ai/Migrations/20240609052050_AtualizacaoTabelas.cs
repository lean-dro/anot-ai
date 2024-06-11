using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace anot_ai.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Etapa_PlanoAcao_PlanoAcaoId",
                table: "Etapa");

            migrationBuilder.DropForeignKey(
                name: "FK_Monitoramento_Anotacoes_AnotacaoId",
                table: "Monitoramento");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanoAcao_Anotacoes_AnotacaoId",
                table: "PlanoAcao");

            migrationBuilder.DropForeignKey(
                name: "FK_Smart_Anotacoes_AnotacaoId",
                table: "Smart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Smart",
                table: "Smart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlanoAcao",
                table: "PlanoAcao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Monitoramento",
                table: "Monitoramento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Etapa",
                table: "Etapa");

            migrationBuilder.RenameTable(
                name: "Smart",
                newName: "Smarts");

            migrationBuilder.RenameTable(
                name: "PlanoAcao",
                newName: "PlanosAcao");

            migrationBuilder.RenameTable(
                name: "Monitoramento",
                newName: "Monitoramentos");

            migrationBuilder.RenameTable(
                name: "Etapa",
                newName: "Etapas");

            migrationBuilder.RenameIndex(
                name: "IX_Smart_AnotacaoId",
                table: "Smarts",
                newName: "IX_Smarts_AnotacaoId");

            migrationBuilder.RenameIndex(
                name: "IX_PlanoAcao_AnotacaoId",
                table: "PlanosAcao",
                newName: "IX_PlanosAcao_AnotacaoId");

            migrationBuilder.RenameIndex(
                name: "IX_Monitoramento_AnotacaoId",
                table: "Monitoramentos",
                newName: "IX_Monitoramentos_AnotacaoId");

            migrationBuilder.RenameIndex(
                name: "IX_Etapa_PlanoAcaoId",
                table: "Etapas",
                newName: "IX_Etapas_PlanoAcaoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Smarts",
                table: "Smarts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlanosAcao",
                table: "PlanosAcao",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Monitoramentos",
                table: "Monitoramentos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Etapas",
                table: "Etapas",
                column: "Id");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Smarts",
                table: "Smarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlanosAcao",
                table: "PlanosAcao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Monitoramentos",
                table: "Monitoramentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Etapas",
                table: "Etapas");

            migrationBuilder.RenameTable(
                name: "Smarts",
                newName: "Smart");

            migrationBuilder.RenameTable(
                name: "PlanosAcao",
                newName: "PlanoAcao");

            migrationBuilder.RenameTable(
                name: "Monitoramentos",
                newName: "Monitoramento");

            migrationBuilder.RenameTable(
                name: "Etapas",
                newName: "Etapa");

            migrationBuilder.RenameIndex(
                name: "IX_Smarts_AnotacaoId",
                table: "Smart",
                newName: "IX_Smart_AnotacaoId");

            migrationBuilder.RenameIndex(
                name: "IX_PlanosAcao_AnotacaoId",
                table: "PlanoAcao",
                newName: "IX_PlanoAcao_AnotacaoId");

            migrationBuilder.RenameIndex(
                name: "IX_Monitoramentos_AnotacaoId",
                table: "Monitoramento",
                newName: "IX_Monitoramento_AnotacaoId");

            migrationBuilder.RenameIndex(
                name: "IX_Etapas_PlanoAcaoId",
                table: "Etapa",
                newName: "IX_Etapa_PlanoAcaoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Smart",
                table: "Smart",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlanoAcao",
                table: "PlanoAcao",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Monitoramento",
                table: "Monitoramento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Etapa",
                table: "Etapa",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Etapa_PlanoAcao_PlanoAcaoId",
                table: "Etapa",
                column: "PlanoAcaoId",
                principalTable: "PlanoAcao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Monitoramento_Anotacoes_AnotacaoId",
                table: "Monitoramento",
                column: "AnotacaoId",
                principalTable: "Anotacoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanoAcao_Anotacoes_AnotacaoId",
                table: "PlanoAcao",
                column: "AnotacaoId",
                principalTable: "Anotacoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Smart_Anotacoes_AnotacaoId",
                table: "Smart",
                column: "AnotacaoId",
                principalTable: "Anotacoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
