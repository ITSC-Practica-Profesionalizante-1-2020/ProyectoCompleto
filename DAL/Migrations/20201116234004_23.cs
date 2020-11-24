using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class _23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userEMPRESA_Clientes_ClienteId",
                table: "userEMPRESA");

            migrationBuilder.DropForeignKey(
                name: "FK_userEMPRESA_Empresas_EmpresaId",
                table: "userEMPRESA");

            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "userEMPRESA");

            migrationBuilder.DropColumn(
                name: "IdEmpresa",
                table: "userEMPRESA");

            migrationBuilder.AlterColumn<int>(
                name: "EmpresaId",
                table: "userEMPRESA",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "userEMPRESA",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_userEMPRESA_Clientes_ClienteId",
                table: "userEMPRESA",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_userEMPRESA_Empresas_EmpresaId",
                table: "userEMPRESA",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userEMPRESA_Clientes_ClienteId",
                table: "userEMPRESA");

            migrationBuilder.DropForeignKey(
                name: "FK_userEMPRESA_Empresas_EmpresaId",
                table: "userEMPRESA");

            migrationBuilder.AlterColumn<int>(
                name: "EmpresaId",
                table: "userEMPRESA",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "userEMPRESA",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCliente",
                table: "userEMPRESA",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdEmpresa",
                table: "userEMPRESA",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_userEMPRESA_Clientes_ClienteId",
                table: "userEMPRESA",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userEMPRESA_Empresas_EmpresaId",
                table: "userEMPRESA",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
