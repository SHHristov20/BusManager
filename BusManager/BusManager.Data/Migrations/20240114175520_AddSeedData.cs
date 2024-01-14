using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BusManager.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "Address", "CityId", "Name" },
                values: new object[,]
                {
                    { 1, "pl. Tsaritsa Yoanna", 2, "South Bus Station" },
                    { 2, "Blvd Knyagina Maria Luisa 100", 22, "Central Bus Station" },
                    { 3, "Blvd Vladislav Varnenchik 158", 3, "Central Bus Station" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password", "UserTypeId" },
                values: new object[,]
                {
                    { 1, "admin", "Admin", "Admin", "$2a$04$srEq7x2/m/gNjDV1BiOKYuozaHzx8uCiRFto/.y7hW4aUXyAsEKg2", 3 },
                    { 2, "staff", "Staff", "Staff", "$2a$04$DDXAkQvGT/HO2wYk6I81uOVNnFxvGFRUrKiwkSj2dVGw7UzBFegHy", 2 },
                    { 3, "user", "User", "User", "$2a$04$aTQazmIdabP6cV/VkbeyQuDV.eVX0lwE7x17dF6TmBN38aI3jDO0q", 1 }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "FromStationId", "Price", "Time", "ToStationId" },
                values: new object[,]
                {
                    { 1, 1, 14f, new DateTime(2024, 1, 17, 17, 30, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 2, 3, 14f, new DateTime(2024, 1, 17, 15, 40, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, 1, 30f, new DateTime(2024, 1, 17, 18, 10, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 4, 2, 30f, new DateTime(2024, 1, 18, 19, 10, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 5, 1, 14f, new DateTime(2024, 1, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 6, 3, 14f, new DateTime(2024, 1, 18, 17, 35, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 7, 1, 30f, new DateTime(2024, 1, 19, 16, 50, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 8, 2, 30f, new DateTime(2024, 1, 19, 20, 10, 0, 0, DateTimeKind.Unspecified), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
