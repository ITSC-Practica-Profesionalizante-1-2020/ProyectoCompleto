using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asistencias_UserEMPRESAS_ParticipanteId",
                table: "Asistencias");

            migrationBuilder.DropForeignKey(
                name: "FK_ConferenceRecordFiles_UserEMPRESAS_DuenioId",
                table: "ConferenceRecordFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Mensajes_UserEMPRESAS_ParticipanteId",
                table: "Mensajes");

            migrationBuilder.DropForeignKey(
                name: "FK_salaUserEMPRESAS_UserEMPRESAS_ParticipanteId",
                table: "salaUserEMPRESAS");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEMPRESAS_AspNetUsers_IdClienteId",
                table: "UserEMPRESAS");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEMPRESAS_Empresas_IdEmpresaId",
                table: "UserEMPRESAS");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEMPRESAS_VideoRooms_VideoRoomId",
                table: "UserEMPRESAS");

            migrationBuilder.DropForeignKey(
                name: "FK_VideoRooms_UserEMPRESAS_DuenioId",
                table: "VideoRooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserEMPRESAS",
                table: "UserEMPRESAS");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CUIL",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FechaNac",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Foto",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Localidad",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NombreCompleto",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Pais",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Provincia",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "UserEMPRESAS",
                newName: "UserEMPRESA");

            migrationBuilder.RenameIndex(
                name: "IX_UserEMPRESAS_VideoRoomId",
                table: "UserEMPRESA",
                newName: "IX_UserEMPRESA_VideoRoomId");

            migrationBuilder.RenameIndex(
                name: "IX_UserEMPRESAS_IdEmpresaId",
                table: "UserEMPRESA",
                newName: "IX_UserEMPRESA_IdEmpresaId");

            migrationBuilder.RenameIndex(
                name: "IX_UserEMPRESAS_IdClienteId",
                table: "UserEMPRESA",
                newName: "IX_UserEMPRESA_IdClienteId");

            migrationBuilder.AlterColumn<int>(
                name: "IdClienteId",
                table: "UserEMPRESA",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserEMPRESA",
                table: "UserEMPRESA",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    NombreCompleto = table.Column<string>(nullable: false),
                    CUIL = table.Column<string>(nullable: false),
                    FechaNac = table.Column<DateTime>(nullable: false),
                    Pais = table.Column<string>(nullable: false),
                    Provincia = table.Column<string>(nullable: false),
                    Localidad = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: true),
                    Foto = table.Column<string>(nullable: true),
                    UsuarioId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_UsuarioId",
                table: "Clientes",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asistencias_UserEMPRESA_ParticipanteId",
                table: "Asistencias",
                column: "ParticipanteId",
                principalTable: "UserEMPRESA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ConferenceRecordFiles_UserEMPRESA_DuenioId",
                table: "ConferenceRecordFiles",
                column: "DuenioId",
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

            migrationBuilder.AddForeignKey(
                name: "FK_UserEMPRESA_VideoRooms_VideoRoomId",
                table: "UserEMPRESA",
                column: "VideoRoomId",
                principalTable: "VideoRooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VideoRooms_UserEMPRESA_DuenioId",
                table: "VideoRooms",
                column: "DuenioId",
                principalTable: "UserEMPRESA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asistencias_UserEMPRESA_ParticipanteId",
                table: "Asistencias");

            migrationBuilder.DropForeignKey(
                name: "FK_ConferenceRecordFiles_UserEMPRESA_DuenioId",
                table: "ConferenceRecordFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Mensajes_UserEMPRESA_ParticipanteId",
                table: "Mensajes");

            migrationBuilder.DropForeignKey(
                name: "FK_salaUserEMPRESAS_UserEMPRESA_ParticipanteId",
                table: "salaUserEMPRESAS");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEMPRESA_Clientes_IdClienteId",
                table: "UserEMPRESA");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEMPRESA_Empresas_IdEmpresaId",
                table: "UserEMPRESA");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEMPRESA_VideoRooms_VideoRoomId",
                table: "UserEMPRESA");

            migrationBuilder.DropForeignKey(
                name: "FK_VideoRooms_UserEMPRESA_DuenioId",
                table: "VideoRooms");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserEMPRESA",
                table: "UserEMPRESA");

            migrationBuilder.RenameTable(
                name: "UserEMPRESA",
                newName: "UserEMPRESAS");

            migrationBuilder.RenameIndex(
                name: "IX_UserEMPRESA_VideoRoomId",
                table: "UserEMPRESAS",
                newName: "IX_UserEMPRESAS_VideoRoomId");

            migrationBuilder.RenameIndex(
                name: "IX_UserEMPRESA_IdEmpresaId",
                table: "UserEMPRESAS",
                newName: "IX_UserEMPRESAS_IdEmpresaId");

            migrationBuilder.RenameIndex(
                name: "IX_UserEMPRESA_IdClienteId",
                table: "UserEMPRESAS",
                newName: "IX_UserEMPRESAS_IdClienteId");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CUIL",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNac",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Foto",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Localidad",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NombreCompleto",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pais",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Provincia",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdClienteId",
                table: "UserEMPRESAS",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserEMPRESAS",
                table: "UserEMPRESAS",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Asistencias_UserEMPRESAS_ParticipanteId",
                table: "Asistencias",
                column: "ParticipanteId",
                principalTable: "UserEMPRESAS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ConferenceRecordFiles_UserEMPRESAS_DuenioId",
                table: "ConferenceRecordFiles",
                column: "DuenioId",
                principalTable: "UserEMPRESAS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mensajes_UserEMPRESAS_ParticipanteId",
                table: "Mensajes",
                column: "ParticipanteId",
                principalTable: "UserEMPRESAS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_salaUserEMPRESAS_UserEMPRESAS_ParticipanteId",
                table: "salaUserEMPRESAS",
                column: "ParticipanteId",
                principalTable: "UserEMPRESAS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserEMPRESAS_AspNetUsers_IdClienteId",
                table: "UserEMPRESAS",
                column: "IdClienteId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserEMPRESAS_Empresas_IdEmpresaId",
                table: "UserEMPRESAS",
                column: "IdEmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserEMPRESAS_VideoRooms_VideoRoomId",
                table: "UserEMPRESAS",
                column: "VideoRoomId",
                principalTable: "VideoRooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VideoRooms_UserEMPRESAS_DuenioId",
                table: "VideoRooms",
                column: "DuenioId",
                principalTable: "UserEMPRESAS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
