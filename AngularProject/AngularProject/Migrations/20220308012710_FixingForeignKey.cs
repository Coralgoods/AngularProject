using Microsoft.EntityFrameworkCore.Migrations;

namespace AngularProject.Migrations
{
    public partial class FixingForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_FavoritedTickets_favoritedTicketsFavoriteId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_favoritedTicketsFavoriteId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "favoritedTicketsFavoriteId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "FavoritedTickets");

            migrationBuilder.AddColumn<int>(
                name: "TicketId",
                table: "FavoritedTickets",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FavoritedTickets_TicketId",
                table: "FavoritedTickets",
                column: "TicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_FavoritedTickets_Tickets_TicketId",
                table: "FavoritedTickets",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavoritedTickets_Tickets_TicketId",
                table: "FavoritedTickets");

            migrationBuilder.DropIndex(
                name: "IX_FavoritedTickets_TicketId",
                table: "FavoritedTickets");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "FavoritedTickets");

            migrationBuilder.AddColumn<int>(
                name: "favoritedTicketsFavoriteId",
                table: "Tickets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "FavoritedTickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_favoritedTicketsFavoriteId",
                table: "Tickets",
                column: "favoritedTicketsFavoriteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_FavoritedTickets_favoritedTicketsFavoriteId",
                table: "Tickets",
                column: "favoritedTicketsFavoriteId",
                principalTable: "FavoritedTickets",
                principalColumn: "FavoriteId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
