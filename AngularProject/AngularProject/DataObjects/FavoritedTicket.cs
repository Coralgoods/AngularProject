﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AngularProject.DataObjects
{
    public class FavoritedTicket
    {
        [Key]
        public int FavoriteId { get; set; }

        [Required]
        [StringLength(40)]
        public string userID { get; set; }

        public Ticket Ticket { get; set; }
    }
}
