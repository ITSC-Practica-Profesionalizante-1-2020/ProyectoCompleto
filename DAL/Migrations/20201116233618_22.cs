using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class _22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mensajes_Participantes_ParticipanteId",
                table: "Mensajes");

            migrationBuilder.DropIndex(
                name: "IX_Mensajes_ParticipanteId",
                table: "Mensajes");

            migrationBuilder.DropColumn(
                name: "ParticipanteId",
                table: "Mensajes");

            migrationBuilder.AddColumn<int>(
                name: "EmisorId",
                table: "Mensajes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReceptorId",
                table: "Mensajes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SalaId",
                table: "Mensajes",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "userEMPRESA",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    IdEmpresa = table.Column<int>(nullable: false),
                    IdCliente = table.Column<int>(nullable: false),
                    EmpresaId = table.Column<int>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userEMPRESA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_userEMPRESA_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_userEMPRESA_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mensajes_EmisorId",
                table: "Mensajes",
                column: "EmisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Mensajes_ReceptorId",
                table: "Mensajes",
                column: "ReceptorId");

            migrationBuilder.CreateIndex(
                name: "IX_Mensajes_SalaId",
                table: "Mensajes",
                column: "SalaId");

            migrationBuilder.CreateIndex(
                name: "IX_userEMPRESA_ClienteId",
                table: "userEMPRESA",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_userEMPRESA_EmpresaId",
                table: "userEMPRESA",
                column: "EmpresaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mensajes_Participantes_EmisorId",
                table: "Mensajes",
                column: "EmisorId",
                principalTable: "Participantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mensajes_Participantes_ReceptorId",
                table: "Mensajes",
                column: "ReceptorId",
                principalTable: "Participantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mensajes_Salas_SalaId",
                table: "Mensajes",
                column: "SalaId",
                principalTable: "Salas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mensajes_Participantes_EmisorId",
                table: "Mensajes");

            migrationBuilder.DropForeignKey(
                name: "FK_Mensajes_Participantes_ReceptorId",
                table: "Mensajes");

            migrationBuilder.DropForeignKey(
                name: "FK_Mensajes_Salas_SalaId",
                table: "Mensajes");

            migrationBuilder.DropTable(
                name: "userEMPRESA");

            migrationBuilder.DropIndex(
                name: "IX_Mensajes_EmisorId",
                table: "Mensajes");

            migrationBuilder.DropIndex(
                name: "IX_Mensajes_ReceptorId",
                table: "Mensajes");

            migrationBuilder.DropIndex(
                name: "IX_Mensajes_SalaId",
                table: "Mensajes");

            migrationBuilder.DropColumn(
                name: "EmisorId",
                table: "Mensajes");

            migrationBuilder.DropColumn(
                name: "ReceptorId",
                table: "Mensajes");

            migrationBuilder.DropColumn(
                name: "SalaId",
                table: "Mensajes");

            migrationBuilder.AddColumn<int>(
                name: "ParticipanteId",
                table: "Mensajes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mensajes_ParticipanteId",
                table: "Mensajes",
                column: "ParticipanteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mensajes_Participantes_ParticipanteId",
                table: "Mensajes",
                column: "ParticipanteId",
                principalTable: "Participantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
