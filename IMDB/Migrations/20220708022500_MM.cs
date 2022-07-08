using Microsoft.EntityFrameworkCore.Migrations;

namespace IMDB.Migrations
{
    public partial class MM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filmes_Realizador_RealizadorId",
                table: "Filmes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Realizador",
                table: "Realizador");

            migrationBuilder.RenameTable(
                name: "Realizador",
                newName: "Realizadores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Realizadores",
                table: "Realizadores",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Actores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilmesActores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmeId = table.Column<int>(type: "int", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmesActores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FilmesActores_Actores_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmesActores_Filmes_FilmeId",
                        column: x => x.FilmeId,
                        principalTable: "Filmes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmesActores_ActorId",
                table: "FilmesActores",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmesActores_FilmeId",
                table: "FilmesActores",
                column: "FilmeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Filmes_Realizadores_RealizadorId",
                table: "Filmes",
                column: "RealizadorId",
                principalTable: "Realizadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filmes_Realizadores_RealizadorId",
                table: "Filmes");

            migrationBuilder.DropTable(
                name: "FilmesActores");

            migrationBuilder.DropTable(
                name: "Actores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Realizadores",
                table: "Realizadores");

            migrationBuilder.RenameTable(
                name: "Realizadores",
                newName: "Realizador");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Realizador",
                table: "Realizador",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Filmes_Realizador_RealizadorId",
                table: "Filmes",
                column: "RealizadorId",
                principalTable: "Realizador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
