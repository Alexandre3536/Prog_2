using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PSIUWeb.Migrations
{
    public partial class MidiaPsicologo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsAvailable",
                table: "Psicos",
                newName: "Released");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Psicos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Midias",
                columns: table => new
                {
                    MidiaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoMidia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Midias", x => x.MidiaId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Psicos_UserId",
                table: "Psicos",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Psicos_AspNetUsers_UserId",
                table: "Psicos",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Psicos_AspNetUsers_UserId",
                table: "Psicos");

            migrationBuilder.DropTable(
                name: "Midias");

            migrationBuilder.DropIndex(
                name: "IX_Psicos_UserId",
                table: "Psicos");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Psicos");

            migrationBuilder.RenameColumn(
                name: "Released",
                table: "Psicos",
                newName: "IsAvailable");
        }
    }
}
