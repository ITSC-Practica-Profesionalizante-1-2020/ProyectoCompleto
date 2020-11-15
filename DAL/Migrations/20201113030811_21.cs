using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class _21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participantes_Salas_SalaId",
                table: "Participantes");

            migrationBuilder.DropIndex(
                name: "IX_Participantes_SalaId",
                table: "Participantes");

            migrationBuilder.DropColumn(
                name: "SalaId",
                table: "Participantes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SalaId",
                table: "Participantes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Participantes_SalaId",
                table: "Participantes",
                column: "SalaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Participantes_Salas_SalaId",
                table: "Participantes",
                column: "SalaId",
                principalTable: "Salas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
