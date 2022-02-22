using Microsoft.EntityFrameworkCore.Migrations;

namespace FlightBooking.Migrations
{
    public partial class AddForeignKeysToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Reservation",
                table: "ReservationForFlight",
                newName: "ID");

            migrationBuilder.AddColumn<int>(
                name: "ReservationID",
                table: "ReservationForFlight",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReservationForFlight_FlightNumber",
                table: "ReservationForFlight",
                column: "FlightNumber");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationForFlight_ReservationID",
                table: "ReservationForFlight",
                column: "ReservationID");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_ReservationId",
                table: "Payment",
                column: "ReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Reservation_ReservationId",
                table: "Payment",
                column: "ReservationId",
                principalTable: "Reservation",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationForFlight_Flights_FlightNumber",
                table: "ReservationForFlight",
                column: "FlightNumber",
                principalTable: "Flights",
                principalColumn: "Number",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationForFlight_Reservation_ReservationID",
                table: "ReservationForFlight",
                column: "ReservationID",
                principalTable: "Reservation",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Reservation_ReservationId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationForFlight_Flights_FlightNumber",
                table: "ReservationForFlight");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationForFlight_Reservation_ReservationID",
                table: "ReservationForFlight");

            migrationBuilder.DropIndex(
                name: "IX_ReservationForFlight_FlightNumber",
                table: "ReservationForFlight");

            migrationBuilder.DropIndex(
                name: "IX_ReservationForFlight_ReservationID",
                table: "ReservationForFlight");

            migrationBuilder.DropIndex(
                name: "IX_Payment_ReservationId",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "ReservationID",
                table: "ReservationForFlight");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "ReservationForFlight",
                newName: "Reservation");
        }
    }
}
