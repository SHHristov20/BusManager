using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BusManager.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateStations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stations_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Blagoevgrad" },
                    { 2, "Burgas" },
                    { 3, "Varna" },
                    { 4, "Veliko Tarnovo" },
                    { 5, "Vidin" },
                    { 6, "Vraca" },
                    { 7, "Gabrovo" },
                    { 8, "Dobrich" },
                    { 9, "Kardzali" },
                    { 10, "Kyustendil" },
                    { 11, "Lovech" },
                    { 12, "Montana" },
                    { 13, "Pazardzhik" },
                    { 14, "Pernik" },
                    { 15, "Pleven" },
                    { 16, "Plovdiv" },
                    { 17, "Razgrad" },
                    { 18, "Ruse" },
                    { 19, "Silistra" },
                    { 20, "Sliven" },
                    { 21, "Smolyan" },
                    { 22, "Sofia" },
                    { 23, "Stara Zagora" },
                    { 24, "Targovishte" },
                    { 25, "Haskovo" },
                    { 26, "Shumen" },
                    { 27, "Yambol" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stations_CityId",
                table: "Stations",
                column: "CityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stations");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
