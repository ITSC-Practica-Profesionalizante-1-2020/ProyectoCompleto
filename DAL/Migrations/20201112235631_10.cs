using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class _10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserEMPRESA_Clientes_IdClienteId",
                table: "UserEMPRESA");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEMPRESA_Empresas_IdEmpresaId",
                table: "UserEMPRESA");

            migrationBuilder.DropIndex(
                name: "IX_UserEMPRESA_IdClienteId",
                table: "UserEMPRESA");

            migrationBuilder.DropIndex(
                name: "IX_UserEMPRESA_IdEmpresaId",
                table: "UserEMPRESA");

            migrationBuilder.DropColumn(
                name: "IdClienteId",
                table: "UserEMPRESA");

            migrationBuilder.DropColumn(
                name: "IdEmpresaId",
                table: "UserEMPRESA");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdClienteId",
                table: "UserEMPRESA",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdEmpresaId",
                table: "UserEMPRESA",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserEMPRESA_IdClienteId",
                table: "UserEMPRESA",
                column: "IdClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEMPRESA_IdEmpresaId",
                table: "UserEMPRESA",
                column: "IdEmpresaId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserEMPRESA_Clientes_IdClienteId",
                table: "UserEMPRESA",
                column: "IdClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserEMPRESA_Empresas_IdEmpresaId",
                table: "UserEMPRESA",
                column: "IdEmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
