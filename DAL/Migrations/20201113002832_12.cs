using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class _12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConferenceRecordFiles_UserEMPRESA_DuenioId",
                table: "ConferenceRecordFiles");

            migrationBuilder.DropTable(
                name: "UserEMPRESA");

            migrationBuilder.DropColumn(
                name: "Id_UserEMPRESA",
                table: "salaUserEMPRESAS");

            migrationBuilder.AddColumn<int>(
                name: "DuenioId",
                table: "VideoRooms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id_Participante",
                table: "salaUserEMPRESAS",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VideoRoomId",
                table: "Participantes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VideoRooms_DuenioId",
                table: "VideoRooms",
                column: "DuenioId");

            migrationBuilder.CreateIndex(
                name: "IX_Participantes_VideoRoomId",
                table: "Participantes",
                column: "VideoRoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConferenceRecordFiles_Participantes_DuenioId",
                table: "ConferenceRecordFiles",
                column: "DuenioId",
                principalTable: "Participantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Participantes_VideoRooms_VideoRoomId",
                table: "Participantes",
                column: "VideoRoomId",
                principalTable: "VideoRooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VideoRooms_Participantes_DuenioId",
                table: "VideoRooms",
                column: "DuenioId",
                principalTable: "Participantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConferenceRecordFiles_Participantes_DuenioId",
                table: "ConferenceRecordFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Participantes_VideoRooms_VideoRoomId",
                table: "Participantes");

            migrationBuilder.DropForeignKey(
                name: "FK_VideoRooms_Participantes_DuenioId",
                table: "VideoRooms");

            migrationBuilder.DropIndex(
                name: "IX_VideoRooms_DuenioId",
                table: "VideoRooms");

            migrationBuilder.DropIndex(
                name: "IX_Participantes_VideoRoomId",
                table: "Participantes");

            migrationBuilder.DropColumn(
                name: "DuenioId",
                table: "VideoRooms");

            migrationBuilder.DropColumn(
                name: "Id_Participante",
                table: "salaUserEMPRESAS");

            migrationBuilder.DropColumn(
                name: "VideoRoomId",
                table: "Participantes");

            migrationBuilder.AddColumn<int>(
                name: "Id_UserEMPRESA",
                table: "salaUserEMPRESAS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UserEMPRESA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VideoRoomId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEMPRESA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserEMPRESA_VideoRooms_VideoRoomId",
                        column: x => x.VideoRoomId,
                        principalTable: "VideoRooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserEMPRESA_VideoRoomId",
                table: "UserEMPRESA",
                column: "VideoRoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConferenceRecordFiles_UserEMPRESA_DuenioId",
                table: "ConferenceRecordFiles",
                column: "DuenioId",
                principalTable: "UserEMPRESA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
