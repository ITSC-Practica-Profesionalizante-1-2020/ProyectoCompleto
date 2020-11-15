using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class _19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "salaUserEMPRESAS");

            migrationBuilder.CreateTable(
                name: "SalaParticipante",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    SalaId = table.Column<int>(nullable: true),
                    ParticipanteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaParticipante", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalaParticipante_Clientes_ParticipanteId",
                        column: x => x.ParticipanteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalaParticipante_Salas_SalaId",
                        column: x => x.SalaId,
                        principalTable: "Salas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SalaParticipante_ParticipanteId",
                table: "SalaParticipante",
                column: "ParticipanteId");

            migrationBuilder.CreateIndex(
                name: "IX_SalaParticipante_SalaId",
                table: "SalaParticipante",
                column: "SalaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalaParticipante");

            migrationBuilder.CreateTable(
                name: "salaUserEMPRESAS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ParticipanteId = table.Column<int>(type: "int", nullable: true),
                    SalaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salaUserEMPRESAS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_salaUserEMPRESAS_Clientes_ParticipanteId",
                        column: x => x.ParticipanteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_salaUserEMPRESAS_Salas_SalaId",
                        column: x => x.SalaId,
                        principalTable: "Salas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_salaUserEMPRESAS_ParticipanteId",
                table: "salaUserEMPRESAS",
                column: "ParticipanteId");

            migrationBuilder.CreateIndex(
                name: "IX_salaUserEMPRESAS_SalaId",
                table: "salaUserEMPRESAS",
                column: "SalaId");
        }
    }
}
