using Microsoft.EntityFrameworkCore.Migrations;

namespace FlightBooking.Migrations
{
    public partial class AddForeignKeysToDB3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservationForFlight_Reservation_ReservationID",
                table: "ReservationForFlight");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "ReservationForFlight");

            migrationBuilder.RenameColumn(
                name: "ReservationID",
                table: "ReservationForFlight",
                newName: "ReservationId");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationForFlight_ReservationID",
                table: "ReservationForFlight",
                newName: "IX_ReservationForFlight_ReservationId");

            migrationBuilder.AlterColumn<int>(
                name: "ReservationId",
                table: "ReservationForFlight",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationForFlight_Reservation_ReservationId",
                table: "ReservationForFlight",
                column: "ReservationId",
                principalTable: "Reservation",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservationForFlight_Reservation_ReservationId",
                table: "ReservationForFlight");

            migrationBuilder.RenameColumn(
                name: "ReservationId",
                table: "ReservationForFlight",
                newName: "ReservationID");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationForFlight_ReservationId",
                table: "ReservationForFlight",
                newName: "IX_ReservationForFlight_ReservationID");

            migrationBuilder.AlterColumn<int>(
                name: "ReservationID",
                table: "ReservationForFlight",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "ReservationForFlight",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationForFlight_Reservation_ReservationID",
                table: "ReservationForFlight",
                column: "ReservationID",
                principalTable: "Reservation",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
