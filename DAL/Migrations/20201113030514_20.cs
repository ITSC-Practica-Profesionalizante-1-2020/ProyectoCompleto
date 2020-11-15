using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class _20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asistencias_Clientes_ParticipanteId",
                table: "Asistencias");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Salas_SalaId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_ConferenceRecordFiles_Clientes_DuenioId",
                table: "ConferenceRecordFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Mensajes_Clientes_ParticipanteId",
                table: "Mensajes");

            migrationBuilder.DropForeignKey(
                name: "FK_SalaParticipante_Clientes_ParticipanteId",
                table: "SalaParticipante");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_SalaId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "FechaAlta",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "FechaBaja",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Rol",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "SalaId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Token",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Clientes");

            migrationBuilder.CreateTable(
                name: "Participantes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Token = table.Column<string>(nullable: true),
                    FechaAlta = table.Column<DateTime>(nullable: false),
                    FechaBaja = table.Column<DateTime>(nullable: true),
                    Rol = table.Column<int>(nullable: false),
                    ClienteId = table.Column<int>(nullable: true),
                    SalaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Participantes_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Participantes_Salas_SalaId",
                        column: x => x.SalaId,
                        principalTable: "Salas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Participantes_ClienteId",
                table: "Participantes",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Participantes_SalaId",
                table: "Participantes",
                column: "SalaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asistencias_Participantes_ParticipanteId",
                table: "Asistencias",
                column: "ParticipanteId",
                principalTable: "Participantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ConferenceRecordFiles_Participantes_DuenioId",
                table: "ConferenceRecordFiles",
                column: "DuenioId",
                principalTable: "Participantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mensajes_Participantes_ParticipanteId",
                table: "Mensajes",
                column: "ParticipanteId",
                principalTable: "Participantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SalaParticipante_Participantes_ParticipanteId",
                table: "SalaParticipante",
                column: "ParticipanteId",
                principalTable: "Participantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asistencias_Participantes_ParticipanteId",
                table: "Asistencias");

            migrationBuilder.DropForeignKey(
                name: "FK_ConferenceRecordFiles_Participantes_DuenioId",
                table: "ConferenceRecordFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Mensajes_Participantes_ParticipanteId",
                table: "Mensajes");

            migrationBuilder.DropForeignKey(
                name: "FK_SalaParticipante_Participantes_ParticipanteId",
                table: "SalaParticipante");

            migrationBuilder.DropTable(
                name: "Participantes");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaAlta",
                table: "Clientes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBaja",
                table: "Clientes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rol",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SalaId",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_SalaId",
                table: "Clientes",
                column: "SalaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asistencias_Clientes_ParticipanteId",
                table: "Asistencias",
                column: "ParticipanteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Salas_SalaId",
                table: "Clientes",
                column: "SalaId",
                principalTable: "Salas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ConferenceRecordFiles_Clientes_DuenioId",
                table: "ConferenceRecordFiles",
                column: "DuenioId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mensajes_Clientes_ParticipanteId",
                table: "Mensajes",
                column: "ParticipanteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SalaParticipante_Clientes_ParticipanteId",
                table: "SalaParticipante",
                column: "ParticipanteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
