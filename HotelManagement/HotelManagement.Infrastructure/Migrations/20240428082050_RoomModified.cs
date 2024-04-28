using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RoomModified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoomStatusId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "RoomStatus_CleanerId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "RoomStatus_CleaningStatus",
                table: "Rooms");

            migrationBuilder.CreateTable(
                name: "CleaningHistories",
                columns: table => new
                {
                    CleaningHistoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CleaningStatus = table.Column<int>(type: "int", nullable: false),
                    CleanerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CleanDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CleaningHistories", x => x.CleaningHistoryId);
                    table.ForeignKey(
                        name: "FK_CleaningHistories_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CleaningHistories_RoomId",
                table: "CleaningHistories",
                column: "RoomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CleaningHistories");

            migrationBuilder.AddColumn<Guid>(
                name: "RoomStatusId",
                table: "Rooms",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RoomStatus_CleanerId",
                table: "Rooms",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "RoomStatus_CleaningStatus",
                table: "Rooms",
                type: "int",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);
        }
    }
}
