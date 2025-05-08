using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_Passengers_PassportNumber",
                table: "Staffs");

            migrationBuilder.DropForeignKey(
                name: "FK_Travellers_Passengers_PassportNumber",
                table: "Travellers");

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_Passengers_PassportNumber",
                table: "Staffs",
                column: "PassportNumber",
                principalTable: "Passengers",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Travellers_Passengers_PassportNumber",
                table: "Travellers",
                column: "PassportNumber",
                principalTable: "Passengers",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_Passengers_PassportNumber",
                table: "Staffs");

            migrationBuilder.DropForeignKey(
                name: "FK_Travellers_Passengers_PassportNumber",
                table: "Travellers");

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_Passengers_PassportNumber",
                table: "Staffs",
                column: "PassportNumber",
                principalTable: "Passengers",
                principalColumn: "PassportNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Travellers_Passengers_PassportNumber",
                table: "Travellers",
                column: "PassportNumber",
                principalTable: "Passengers",
                principalColumn: "PassportNumber");
        }
    }
}
