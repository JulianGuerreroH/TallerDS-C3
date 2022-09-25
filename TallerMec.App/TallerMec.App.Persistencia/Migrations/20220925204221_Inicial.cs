using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TallerMec.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mecanics",
                columns: table => new
                {
                    mecanicoId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nivelEstudio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mecanics", x => x.mecanicoId);
                });

            migrationBuilder.CreateTable(
                name: "Propietarios",
                columns: table => new
                {
                    propietarioId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaNacimiento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propietarios", x => x.propietarioId);
                });

            migrationBuilder.CreateTable(
                name: "Revisions",
                columns: table => new
                {
                    revisionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    fechaRev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mecanicoId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vehiculoId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Revisions", x => x.revisionId);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    vehiculoId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipoVehiculo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    capacidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cilindraje = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ciudadOrigen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    propietarioId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.vehiculoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mecanics");

            migrationBuilder.DropTable(
                name: "Propietarios");

            migrationBuilder.DropTable(
                name: "Revisions");

            migrationBuilder.DropTable(
                name: "Vehiculos");
        }
    }
}
