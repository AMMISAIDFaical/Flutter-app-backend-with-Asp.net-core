using Microsoft.EntityFrameworkCore.Migrations;

namespace BusAppBackend.Migrations
{
    public partial class addCompEntityEditBusEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "BusEntity",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "companyEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Wilaya = table.Column<string>(maxLength: 20, nullable: false),
                    Adress = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companyEntity", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "companyEntity",
                columns: new[] { "Id", "Adress", "Name", "Wilaya" },
                values: new object[] { 1, "adr 1", "bus comp 1", "ghardaia" });

            migrationBuilder.InsertData(
                table: "companyEntity",
                columns: new[] { "Id", "Adress", "Name", "Wilaya" },
                values: new object[] { 2, "adr 2", "bus comp 2", "alger" });

            migrationBuilder.UpdateData(
                table: "BusEntity",
                keyColumn: "id",
                keyValue: 1,
                column: "CompanyId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BusEntity",
                keyColumn: "id",
                keyValue: 2,
                column: "CompanyId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BusEntity",
                keyColumn: "id",
                keyValue: 3,
                column: "CompanyId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_BusEntity_CompanyId",
                table: "BusEntity",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusEntity_companyEntity_CompanyId",
                table: "BusEntity",
                column: "CompanyId",
                principalTable: "companyEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BusEntity_companyEntity_CompanyId",
                table: "BusEntity");

            migrationBuilder.DropTable(
                name: "companyEntity");

            migrationBuilder.DropIndex(
                name: "IX_BusEntity_CompanyId",
                table: "BusEntity");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "BusEntity");
        }
    }
}
