using Microsoft.EntityFrameworkCore.Migrations;

namespace IMDB.Migrations
{
    public partial class comrealizador : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RealizadorId",
                table: "Filmes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Realizador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Realizador", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filmes_RealizadorId",
                table: "Filmes",
                column: "RealizadorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Filmes_Realizador_RealizadorId",
                table: "Filmes",
                column: "RealizadorId",
                principalTable: "Realizador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filmes_Realizador_RealizadorId",
                table: "Filmes");

            migrationBuilder.DropTable(
                name: "Realizador");

            migrationBuilder.DropIndex(
                name: "IX_Filmes_RealizadorId",
                table: "Filmes");

            migrationBuilder.DropColumn(
                name: "RealizadorId",
                table: "Filmes");
        }
    }
}
