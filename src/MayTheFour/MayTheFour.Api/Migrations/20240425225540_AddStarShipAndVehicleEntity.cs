using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MayTheFour.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddStarShipAndVehicleEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "may-the-fourth");

            migrationBuilder.CreateTable(
                name: "starships",
                schema: "may-the-fourth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: false),
                    CostInCredits = table.Column<string>(type: "TEXT", nullable: false),
                    Length = table.Column<string>(type: "TEXT", nullable: false),
                    MaxSpeed = table.Column<string>(type: "TEXT", nullable: false),
                    Crew = table.Column<string>(type: "TEXT", nullable: false),
                    Passengers = table.Column<string>(type: "TEXT", nullable: false),
                    CargoCapacity = table.Column<string>(type: "TEXT", nullable: false),
                    HyperdriveRating = table.Column<string>(type: "TEXT", nullable: false),
                    Mglt = table.Column<string>(type: "TEXT", nullable: false),
                    Consumables = table.Column<string>(type: "TEXT", nullable: false),
                    Class = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_starships", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "vehicles",
                schema: "may-the-fourth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: false),
                    CostInCredits = table.Column<string>(type: "TEXT", nullable: false),
                    Length = table.Column<string>(type: "TEXT", nullable: false),
                    MaxSpeed = table.Column<string>(type: "TEXT", nullable: false),
                    Crew = table.Column<string>(type: "TEXT", nullable: false),
                    Passengers = table.Column<string>(type: "TEXT", nullable: false),
                    CargoCapacity = table.Column<string>(type: "TEXT", nullable: false),
                    Consumables = table.Column<string>(type: "TEXT", nullable: false),
                    Class = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "starships_Movies",
                schema: "may-the-fourth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    StarshipId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_starships_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_starships_Movies_starships_StarshipId",
                        column: x => x.StarshipId,
                        principalSchema: "may-the-fourth",
                        principalTable: "starships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "vehicles_Movies",
                schema: "may-the-fourth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    VehicleId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicles_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_vehicles_Movies_vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "may-the-fourth",
                        principalTable: "vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_starships_Movies_StarshipId",
                schema: "may-the-fourth",
                table: "starships_Movies",
                column: "StarshipId");

            migrationBuilder.CreateIndex(
                name: "IX_vehicles_Movies_VehicleId",
                schema: "may-the-fourth",
                table: "vehicles_Movies",
                column: "VehicleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "starships_Movies",
                schema: "may-the-fourth");

            migrationBuilder.DropTable(
                name: "vehicles_Movies",
                schema: "may-the-fourth");

            migrationBuilder.DropTable(
                name: "starships",
                schema: "may-the-fourth");

            migrationBuilder.DropTable(
                name: "vehicles",
                schema: "may-the-fourth");
        }
    }
}
