using Microsoft.EntityFrameworkCore.Migrations;

namespace BusAppBackend.Migrations
{
    public partial class addingBusTableAndUrlBusTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.CreateTable(
                name: "BusEntity",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    marque = table.Column<string>(maxLength: 50, nullable: false),
                    model = table.Column<string>(maxLength: 50, nullable: false),
                    year = table.Column<string>(nullable: false),
                    nbrSeats = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusEntity", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "BusImgUrlEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(nullable: true),
                    BusEntityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusImgUrlEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusImgUrlEntity_BusEntity_BusEntityId",
                        column: x => x.BusEntityId,
                        principalTable: "BusEntity",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BusEntity",
                columns: new[] { "id", "marque", "model", "nbrSeats", "year" },
                values: new object[] { 1, "chevy", "F32 camaro", 50, "2022" });

            migrationBuilder.InsertData(
                table: "BusEntity",
                columns: new[] { "id", "marque", "model", "nbrSeats", "year" },
                values: new object[] { 2, "mercedes", "benz", 60, "2021" });

            migrationBuilder.InsertData(
                table: "BusEntity",
                columns: new[] { "id", "marque", "model", "nbrSeats", "year" },
                values: new object[] { 3, "vols", "777 vols", 55, "2020" });

            migrationBuilder.InsertData(
                table: "BusImgUrlEntity",
                columns: new[] { "Id", "BusEntityId", "Url" },
                values: new object[] { 1, 1, "url for chevy 1" });

            migrationBuilder.InsertData(
                table: "BusImgUrlEntity",
                columns: new[] { "Id", "BusEntityId", "Url" },
                values: new object[] { 2, 1, "url for chevy 2" });

            migrationBuilder.InsertData(
                table: "BusImgUrlEntity",
                columns: new[] { "Id", "BusEntityId", "Url" },
                values: new object[] { 3, 2, "url for benz" });

            migrationBuilder.CreateIndex(
                name: "IX_BusImgUrlEntity_BusEntityId",
                table: "BusImgUrlEntity",
                column: "BusEntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusImgUrlEntity");

            migrationBuilder.DropTable(
                name: "BusEntity");

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    passsword = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.id);
                });
        }
    }
}
