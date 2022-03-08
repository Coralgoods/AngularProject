using Microsoft.EntityFrameworkCore.Migrations;

namespace AngularProject.Migrations
{
    public partial class InitialDatabaseCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavoritedTickets",
                columns: table => new
                {
                    FavoriteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userID = table.Column<string>(maxLength: 40, nullable: false),
                    Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoritedTickets", x => x.FavoriteId);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    favoritedTicketsFavoriteId = table.Column<int>(nullable: true),
                    ticketName = table.Column<string>(maxLength: 40, nullable: false),
                    createdBy = table.Column<string>(maxLength: 40, nullable: false),
                    ticketDescription = table.Column<string>(maxLength: 400, nullable: false),
                    isResolved = table.Column<bool>(nullable: false),
                    completedBy = table.Column<string>(maxLength: 40, nullable: true),
                    resolutionNotes = table.Column<string>(maxLength: 400, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_FavoritedTickets_favoritedTicketsFavoriteId",
                        column: x => x.favoritedTicketsFavoriteId,
                        principalTable: "FavoritedTickets",
                        principalColumn: "FavoriteId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_favoritedTicketsFavoriteId",
                table: "Tickets",
                column: "favoritedTicketsFavoriteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "FavoritedTickets");
        }
    }
}
