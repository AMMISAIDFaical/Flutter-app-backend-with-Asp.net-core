using Microsoft.EntityFrameworkCore.Migrations;

namespace BusAppBackend.Migrations
{
    public partial class StopsMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StopsEntity",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StopsEntity",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StopsEntity",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "StopsEntity",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "StopsEntity",
                keyColumn: "Id",
                keyValue: 1,
                column: "Stops",
                value: "laghwat,djelfa,msilla,bordj");

            migrationBuilder.UpdateData(
                table: "StopsEntity",
                keyColumn: "Id",
                keyValue: 2,
                column: "Stops",
                value: "laghwat,djelfa,bosaada,media");

            migrationBuilder.UpdateData(
                table: "StopsEntity",
                keyColumn: "Id",
                keyValue: 3,
                column: "Stops",
                value: "wilaya A,wilaya B,wilaya C ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "StopsEntity",
                keyColumn: "Id",
                keyValue: 1,
                column: "Stops",
                value: "bordj");

            migrationBuilder.UpdateData(
                table: "StopsEntity",
                keyColumn: "Id",
                keyValue: 2,
                column: "Stops",
                value: "bosaada");

            migrationBuilder.UpdateData(
                table: "StopsEntity",
                keyColumn: "Id",
                keyValue: 3,
                column: "Stops",
                value: "djelfa");

            migrationBuilder.InsertData(
                table: "StopsEntity",
                columns: new[] { "Id", "Stops", "TripEntityId" },
                values: new object[,]
                {
                    { 4, "media", null },
                    { 5, "bejaia", null },
                    { 6, "laghwat", null },
                    { 7, "blida", null }
                });
        }
    }
}
