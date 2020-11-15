using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class _9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VideoRooms_UserEMPRESA_DuenioId",
                table: "VideoRooms");

            migrationBuilder.DropIndex(
                name: "IX_VideoRooms_DuenioId",
                table: "VideoRooms");

            migrationBuilder.DropColumn(
                name: "DuenioId",
                table: "VideoRooms");

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "Clientes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_EmpresaId",
                table: "Clientes",
                column: "EmpresaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Empresas_EmpresaId",
                table: "Clientes",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Empresas_EmpresaId",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_EmpresaId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "Clientes");

            migrationBuilder.AddColumn<int>(
                name: "DuenioId",
                table: "VideoRooms",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VideoRooms_DuenioId",
                table: "VideoRooms",
                column: "DuenioId");

            migrationBuilder.AddForeignKey(
                name: "FK_VideoRooms_UserEMPRESA_DuenioId",
                table: "VideoRooms",
                column: "DuenioId",
                principalTable: "UserEMPRESA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
