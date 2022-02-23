using Microsoft.EntityFrameworkCore.Migrations;

namespace BusAppBackend.Migrations
{
    public partial class addReservEntityAddTrip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TripEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Depart = table.Column<string>(nullable: false),
                    Arrivel = table.Column<string>(nullable: false),
                    DateDepart = table.Column<string>(nullable: false),
                    NbrPlaces = table.Column<int>(nullable: false),
                    StopsId = table.Column<int>(nullable: false),
                    Commentaire = table.Column<string>(nullable: true),
                    Note = table.Column<int>(nullable: false),
                    BusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TripEntity_BusEntity_BusId",
                        column: x => x.BusId,
                        principalTable: "BusEntity",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReservationEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(nullable: false),
                    ClientId = table.Column<int>(nullable: false),
                    TripId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReservationEntity_ClientEntity_ClientId",
                        column: x => x.ClientId,
                        principalTable: "ClientEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationEntity_TripEntity_TripId",
                        column: x => x.TripId,
                        principalTable: "TripEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StopsEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Stops = table.Column<string>(maxLength: 50, nullable: false),
                    TripEntityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StopsEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StopsEntity_TripEntity_TripEntityId",
                        column: x => x.TripEntityId,
                        principalTable: "TripEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "StopsEntity",
                columns: new[] { "Id", "Stops", "TripEntityId" },
                values: new object[,]
                {
                    { 1, "bordj", null },
                    { 2, "bosaada", null },
                    { 3, "djelfa", null },
                    { 4, "media", null },
                    { 5, "bejaia", null },
                    { 6, "laghwat", null },
                    { 7, "blida", null }
                });

            migrationBuilder.InsertData(
                table: "TripEntity",
                columns: new[] { "Id", "Arrivel", "BusId", "Commentaire", "DateDepart", "Depart", "NbrPlaces", "Note", "StopsId" },
                values: new object[,]
                {
                    { 1, "alger", 1, "its cool bus !", "2022-12-06/6:00 am", "ghardaia", 3, 10, 2 },
                    { 2, "ghardaia", 2, "its not bad trip  !", "2022-12-06/14:00 pm", "setif", 1, 8, 1 }
                });

            migrationBuilder.InsertData(
                table: "ReservationEntity",
                columns: new[] { "Id", "ClientId", "Status", "TripId" },
                values: new object[] { 1, 1, "valide", 1 });

            migrationBuilder.InsertData(
                table: "ReservationEntity",
                columns: new[] { "Id", "ClientId", "Status", "TripId" },
                values: new object[] { 2, 2, "pending", 2 });

            migrationBuilder.CreateIndex(
                name: "IX_ReservationEntity_ClientId",
                table: "ReservationEntity",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationEntity_TripId",
                table: "ReservationEntity",
                column: "TripId");

            migrationBuilder.CreateIndex(
                name: "IX_StopsEntity_TripEntityId",
                table: "StopsEntity",
                column: "TripEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_TripEntity_BusId",
                table: "TripEntity",
                column: "BusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReservationEntity");

            migrationBuilder.DropTable(
                name: "StopsEntity");

            migrationBuilder.DropTable(
                name: "TripEntity");
        }
    }
}
