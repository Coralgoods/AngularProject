using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AngularProject.DataObjects
{
    public class TicketContext : DbContext
    {
        //by god this is amazing
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<FavoritedTicket> FavoritedTickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=HelpTickets;Trusted_Connection=True;");
        }




    }
}
