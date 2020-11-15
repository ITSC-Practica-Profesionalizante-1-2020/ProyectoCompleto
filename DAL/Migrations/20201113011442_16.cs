using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class _16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_VideoRooms_VideoRoomId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_VideoRooms_Clientes_DuenioId",
                table: "VideoRooms");

            migrationBuilder.DropIndex(
                name: "IX_VideoRooms_DuenioId",
                table: "VideoRooms");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_VideoRoomId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "DuenioId",
                table: "VideoRooms");

            migrationBuilder.DropColumn(
                name: "VideoRoomId",
                table: "Clientes");

            migrationBuilder.AddColumn<string>(
                name: "PasswordSala",
                table: "Salas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SalaId",
                table: "Clientes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_SalaId",
                table: "Clientes",
                column: "SalaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Salas_SalaId",
                table: "Clientes",
                column: "SalaId",
                principalTable: "Salas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Salas_SalaId",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_SalaId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "PasswordSala",
                table: "Salas");

            migrationBuilder.DropColumn(
                name: "SalaId",
                table: "Clientes");

            migrationBuilder.AddColumn<int>(
                name: "DuenioId",
                table: "VideoRooms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VideoRoomId",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VideoRooms_DuenioId",
                table: "VideoRooms",
                column: "DuenioId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_VideoRoomId",
                table: "Clientes",
                column: "VideoRoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_VideoRooms_VideoRoomId",
                table: "Clientes",
                column: "VideoRoomId",
                principalTable: "VideoRooms",
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
    }
}
