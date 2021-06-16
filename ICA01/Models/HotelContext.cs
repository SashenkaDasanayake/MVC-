using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ICA01.Models
{
    public class HotelContext : DbContext
    {
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Extra> Extras { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
    }
}