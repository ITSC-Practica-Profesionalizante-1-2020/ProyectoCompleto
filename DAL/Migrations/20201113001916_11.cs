using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class _11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asistencias_UserEMPRESA_ParticipanteId",
                table: "Asistencias");

            migrationBuilder.DropForeignKey(
                name: "FK_Mensajes_UserEMPRESA_ParticipanteId",
                table: "Mensajes");

            migrationBuilder.DropForeignKey(
                name: "FK_salaUserEMPRESAS_UserEMPRESA_ParticipanteId",
                table: "salaUserEMPRESAS");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "UserEMPRESA");

            migrationBuilder.DropColumn(
                name: "FechaAlta",
                table: "UserEMPRESA");

            migrationBuilder.DropColumn(
                name: "FechaBaja",
                table: "UserEMPRESA");

            migrationBuilder.DropColumn(
                name: "Rol",
                table: "UserEMPRESA");

            migrationBuilder.DropColumn(
                name: "Token",
                table: "UserEMPRESA");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "UserEMPRESA");

            migrationBuilder.CreateTable(
                name: "Participantes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Token = table.Column<string>(nullable: true),
                    FechaAlta = table.Column<DateTime>(nullable: false),
                    FechaBaja = table.Column<DateTime>(nullable: true),
                    Rol = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participantes", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Asistencias_Participantes_ParticipanteId",
                table: "Asistencias",
                column: "ParticipanteId",
                principalTable: "Participantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mensajes_Participantes_ParticipanteId",
                table: "Mensajes",
                column: "ParticipanteId",
                principalTable: "Participantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_salaUserEMPRESAS_Participantes_ParticipanteId",
                table: "salaUserEMPRESAS",
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
                name: "FK_Mensajes_Participantes_ParticipanteId",
                table: "Mensajes");

            migrationBuilder.DropForeignKey(
                name: "FK_salaUserEMPRESAS_Participantes_ParticipanteId",
                table: "salaUserEMPRESAS");

            migrationBuilder.DropTable(
                name: "Participantes");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "UserEMPRESA",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaAlta",
                table: "UserEMPRESA",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBaja",
                table: "UserEMPRESA",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rol",
                table: "UserEMPRESA",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "UserEMPRESA",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "UserEMPRESA",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Asistencias_UserEMPRESA_ParticipanteId",
                table: "Asistencias",
                column: "ParticipanteId",
                principalTable: "UserEMPRESA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mensajes_UserEMPRESA_ParticipanteId",
                table: "Mensajes",
                column: "ParticipanteId",
                principalTable: "UserEMPRESA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_salaUserEMPRESAS_UserEMPRESA_ParticipanteId",
                table: "salaUserEMPRESAS",
                column: "ParticipanteId",
                principalTable: "UserEMPRESA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
