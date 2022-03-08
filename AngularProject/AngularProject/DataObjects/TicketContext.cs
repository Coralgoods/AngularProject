using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AngularProject.DataObjects
{
    public class TicketContext : DbContext
    {
        //by god this comment was so helpful the world will be forever changed
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<FavoritedTicket> FavoritedTickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=HelpTickets;Trusted_Connection=True;");
        }




    }
}
