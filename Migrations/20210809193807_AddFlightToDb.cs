using Microsoft.EntityFrameworkCore.Migrations;

namespace FlightBooking.Migrations
{
    public partial class AddFlightToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    Number = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Departure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Arrival = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Departure_time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Arrival_time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Departure_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Arrival_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Plane_type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.Number);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flights");
        }
    }
}
