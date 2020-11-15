using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class _15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asistencias_AspNetUsers_ParticipanteId",
                table: "Asistencias");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_VideoRooms_VideoRoomId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ConferenceRecordFiles_AspNetUsers_DuenioId",
                table: "ConferenceRecordFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Mensajes_AspNetUsers_ParticipanteId1",
                table: "Mensajes");

            migrationBuilder.DropForeignKey(
                name: "FK_salaUserEMPRESAS_AspNetUsers_ParticipanteId",
                table: "salaUserEMPRESAS");

            migrationBuilder.DropForeignKey(
                name: "FK_VideoRooms_AspNetUsers_DuenioId",
                table: "VideoRooms");

            migrationBuilder.DropIndex(
                name: "IX_Mensajes_ParticipanteId1",
                table: "Mensajes");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_VideoRoomId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ParticipanteId1",
                table: "Mensajes");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FechaAlta",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FechaBaja",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Rol",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Token",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "VideoRoomId",
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
                name: "NombreCompleto",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Pais",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Provincia",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CUIT",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FechaInicioActividades",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Logo",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RazonSocial",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "DuenioId",
                table: "VideoRooms",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ParticipanteId",
                table: "salaUserEMPRESAS",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DuenioId",
                table: "ConferenceRecordFiles",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ParticipanteId",
                table: "Asistencias",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    Provincia = table.Column<string>(nullable: false),
                    Pais = table.Column<string>(nullable: true),
                    IdentityUsuarioId = table.Column<string>(nullable: true),
                    NombreCompleto = table.Column<string>(nullable: false),
                    CUIL = table.Column<string>(nullable: false),
                    FechaNac = table.Column<DateTime>(nullable: false),
                    Foto = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Token = table.Column<string>(nullable: true),
                    FechaAlta = table.Column<DateTime>(nullable: true),
                    FechaBaja = table.Column<DateTime>(nullable: true),
                    Rol = table.Column<int>(nullable: true),
                    VideoRoomId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_VideoRooms_VideoRoomId",
                        column: x => x.VideoRoomId,
                        principalTable: "VideoRooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clientes_AspNetUsers_IdentityUsuarioId",
                        column: x => x.IdentityUsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    Provincia = table.Column<string>(nullable: false),
                    Pais = table.Column<string>(nullable: true),
                    IdentityUsuarioId = table.Column<string>(nullable: true),
                    RazonSocial = table.Column<string>(nullable: false),
                    CUIT = table.Column<string>(nullable: false),
                    FechaInicioActividades = table.Column<DateTime>(nullable: false),
                    Logo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empresas_AspNetUsers_IdentityUsuarioId",
                        column: x => x.IdentityUsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mensajes_ParticipanteId",
                table: "Mensajes",
                column: "ParticipanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_VideoRoomId",
                table: "Clientes",
                column: "VideoRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_IdentityUsuarioId",
                table: "Clientes",
                column: "IdentityUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_IdentityUsuarioId",
                table: "Empresas",
                column: "IdentityUsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asistencias_Clientes_ParticipanteId",
                table: "Asistencias",
                column: "ParticipanteId",
                principalTable: "Clientes",
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
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_salaUserEMPRESAS_Clientes_ParticipanteId",
                table: "salaUserEMPRESAS",
                column: "ParticipanteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VideoRooms_Clientes_DuenioId",
                table: "VideoRooms",
                column: "DuenioId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asistencias_Clientes_ParticipanteId",
                table: "Asistencias");

            migrationBuilder.DropForeignKey(
                name: "FK_ConferenceRecordFiles_Clientes_DuenioId",
                table: "ConferenceRecordFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Mensajes_Clientes_ParticipanteId",
                table: "Mensajes");

            migrationBuilder.DropForeignKey(
                name: "FK_salaUserEMPRESAS_Clientes_ParticipanteId",
                table: "salaUserEMPRESAS");

            migrationBuilder.DropForeignKey(
                name: "FK_VideoRooms_Clientes_DuenioId",
                table: "VideoRooms");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropIndex(
                name: "IX_Mensajes_ParticipanteId",
                table: "Mensajes");

            migrationBuilder.AlterColumn<string>(
                name: "DuenioId",
                table: "VideoRooms",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ParticipanteId",
                table: "salaUserEMPRESAS",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParticipanteId1",
                table: "Mensajes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DuenioId",
                table: "ConferenceRecordFiles",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaAlta",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBaja",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rol",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VideoRoomId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

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

            migrationBuilder.AddColumn<string>(
                name: "CUIT",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaInicioActividades",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Logo",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RazonSocial",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ParticipanteId",
                table: "Asistencias",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mensajes_ParticipanteId1",
                table: "Mensajes",
                column: "ParticipanteId1");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_VideoRoomId",
                table: "AspNetUsers",
                column: "VideoRoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asistencias_AspNetUsers_ParticipanteId",
                table: "Asistencias",
                column: "ParticipanteId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_VideoRooms_VideoRoomId",
                table: "AspNetUsers",
                column: "VideoRoomId",
                principalTable: "VideoRooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ConferenceRecordFiles_AspNetUsers_DuenioId",
                table: "ConferenceRecordFiles",
                column: "DuenioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mensajes_AspNetUsers_ParticipanteId1",
                table: "Mensajes",
                column: "ParticipanteId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_salaUserEMPRESAS_AspNetUsers_ParticipanteId",
                table: "salaUserEMPRESAS",
                column: "ParticipanteId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VideoRooms_AspNetUsers_DuenioId",
                table: "VideoRooms",
                column: "DuenioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
