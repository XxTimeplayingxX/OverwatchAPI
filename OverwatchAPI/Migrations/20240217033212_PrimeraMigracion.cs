using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OverwatchAPI.Migrations
{
    /// <inheritdoc />
    public partial class PrimeraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetalleHabilidades",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeroID = table.Column<int>(type: "int", nullable: false),
                    HabilidadesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleHabilidades", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Habilidades",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetalleID = table.Column<int>(type: "int", nullable: false),
                    Descripción = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidades", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Heroes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "DetalleHabilidades",
                columns: new[] { "ID", "HabilidadesID", "HeroID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Habilidades",
                columns: new[] { "ID", "Descripción", "DetalleID" },
                values: new object[,]
                {
                    { 1, "Blink", 1 },
                    { 2, "Recall", 1 }
                });

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Tracer es un ágil y valiente piloto de pruebas que se convirtió en una heroína del tiempo. Su habilidad para manipular el tiempo la convierte en una fuerza formidable en el campo de batalla, permitiéndole teletransportarse rápidamente y deshacer los daños recibidos.", "Tracer" },
                    { 2, "Reaper es un misterioso mercenario que esconde su rostro bajo una máscara de calavera. Utiliza una combinación de habilidades oscuras y tácticas sigilosas para acechar a sus enemigos y eliminarlos con su par de escopetas infernales.", "Reaper" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleHabilidades");

            migrationBuilder.DropTable(
                name: "Habilidades");

            migrationBuilder.DropTable(
                name: "Heroes");
        }
    }
}
