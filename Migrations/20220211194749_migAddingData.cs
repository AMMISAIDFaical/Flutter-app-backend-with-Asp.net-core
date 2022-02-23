using Microsoft.EntityFrameworkCore.Migrations;

namespace BusAppBackend.Migrations
{
    public partial class migAddingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(maxLength: 20, nullable: false),
                    age = table.Column<int>(nullable: false),
                    email = table.Column<string>(maxLength: 20, nullable: false),
                    password = table.Column<string>(nullable: false),
                    gender = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientEntity", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ClientEntity",
                columns: new[] { "Id", "age", "email", "gender", "name", "password" },
                values: new object[] { 1, 21, "rnb@gmail.com", "M", "rock n roll baby", "azerty" });

            migrationBuilder.InsertData(
                table: "ClientEntity",
                columns: new[] { "Id", "age", "email", "gender", "name", "password" },
                values: new object[] { 2, 29, "Steph@gmail.com", "M", "CURRY", "chefCurry" });

            migrationBuilder.InsertData(
                table: "ClientEntity",
                columns: new[] { "Id", "age", "email", "gender", "name", "password" },
                values: new object[] { 3, 40, "yela@gmail.com", "M", "yela", "MakeMeBeliver" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientEntity");
        }
    }
}
