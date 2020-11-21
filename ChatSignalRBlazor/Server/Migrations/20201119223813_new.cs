using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatSignalRBlazor.Server.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mensaje",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contenido = table.Column<string>(nullable: true),
                    Fecha_Hora = table.Column<DateTime>(nullable: true),
                    SalaId = table.Column<int>(nullable: true),
                    ParticipanteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensaje", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mensaje");
        }
    }
}
