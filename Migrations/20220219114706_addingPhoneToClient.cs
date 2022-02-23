using Microsoft.EntityFrameworkCore.Migrations;

namespace BusAppBackend.Migrations
{
    public partial class addingPhoneToClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BusEntity_companyEntity_CompanyId",
                table: "BusEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationEntity_TripEntity_TripId",
                table: "ReservationEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_StopsEntity_TripEntity_TripEntityId",
                table: "StopsEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_TripEntity_BusEntity_BusId",
                table: "TripEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_companyEntity",
                table: "companyEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TripEntity",
                table: "TripEntity");

            migrationBuilder.RenameTable(
                name: "companyEntity",
                newName: "CompanyEntity");

            migrationBuilder.RenameTable(
                name: "TripEntity",
                newName: "TripsEntity");

            migrationBuilder.RenameIndex(
                name: "IX_TripEntity_BusId",
                table: "TripsEntity",
                newName: "IX_TripsEntity_BusId");

            migrationBuilder.AddColumn<string>(
                name: "phoneNumber",
                table: "ClientEntity",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyEntity",
                table: "CompanyEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TripsEntity",
                table: "TripsEntity",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "ClientEntity",
                keyColumn: "Id",
                keyValue: 1,
                column: "phoneNumber",
                value: "07586535");

            migrationBuilder.UpdateData(
                table: "ClientEntity",
                keyColumn: "Id",
                keyValue: 2,
                column: "phoneNumber",
                value: "06585535");

            migrationBuilder.UpdateData(
                table: "ClientEntity",
                keyColumn: "Id",
                keyValue: 3,
                column: "phoneNumber",
                value: "05196732");

            migrationBuilder.AddForeignKey(
                name: "FK_BusEntity_CompanyEntity_CompanyId",
                table: "BusEntity",
                column: "CompanyId",
                principalTable: "CompanyEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationEntity_TripsEntity_TripId",
                table: "ReservationEntity",
                column: "TripId",
                principalTable: "TripsEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StopsEntity_TripsEntity_TripEntityId",
                table: "StopsEntity",
                column: "TripEntityId",
                principalTable: "TripsEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TripsEntity_BusEntity_BusId",
                table: "TripsEntity",
                column: "BusId",
                principalTable: "BusEntity",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BusEntity_CompanyEntity_CompanyId",
                table: "BusEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationEntity_TripsEntity_TripId",
                table: "ReservationEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_StopsEntity_TripsEntity_TripEntityId",
                table: "StopsEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_TripsEntity_BusEntity_BusId",
                table: "TripsEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyEntity",
                table: "CompanyEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TripsEntity",
                table: "TripsEntity");

            migrationBuilder.DropColumn(
                name: "phoneNumber",
                table: "ClientEntity");

            migrationBuilder.RenameTable(
                name: "CompanyEntity",
                newName: "companyEntity");

            migrationBuilder.RenameTable(
                name: "TripsEntity",
                newName: "TripEntity");

            migrationBuilder.RenameIndex(
                name: "IX_TripsEntity_BusId",
                table: "TripEntity",
                newName: "IX_TripEntity_BusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_companyEntity",
                table: "companyEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TripEntity",
                table: "TripEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BusEntity_companyEntity_CompanyId",
                table: "BusEntity",
                column: "CompanyId",
                principalTable: "companyEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationEntity_TripEntity_TripId",
                table: "ReservationEntity",
                column: "TripId",
                principalTable: "TripEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StopsEntity_TripEntity_TripEntityId",
                table: "StopsEntity",
                column: "TripEntityId",
                principalTable: "TripEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TripEntity_BusEntity_BusId",
                table: "TripEntity",
                column: "BusId",
                principalTable: "BusEntity",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
