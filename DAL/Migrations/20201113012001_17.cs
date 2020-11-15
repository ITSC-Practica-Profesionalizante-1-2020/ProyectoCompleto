using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class _17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mensajes_Clientes_ParticipanteId",
                table: "Mensajes");

            migrationBuilder.AlterColumn<int>(
                name: "ParticipanteId",
                table: "Mensajes",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Mensajes_Clientes_ParticipanteId",
                table: "Mensajes",
                column: "ParticipanteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mensajes_Clientes_ParticipanteId",
                table: "Mensajes");

            migrationBuilder.AlterColumn<int>(
                name: "ParticipanteId",
                table: "Mensajes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Mensajes_Clientes_ParticipanteId",
                table: "Mensajes",
                column: "ParticipanteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
