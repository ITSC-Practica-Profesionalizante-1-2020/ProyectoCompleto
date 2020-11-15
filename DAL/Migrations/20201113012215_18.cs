using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class _18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_Participante",
                table: "salaUserEMPRESAS");

            migrationBuilder.DropColumn(
                name: "Id_Sala",
                table: "salaUserEMPRESAS");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id_Participante",
                table: "salaUserEMPRESAS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_Sala",
                table: "salaUserEMPRESAS",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
