using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ICA01.Models
{
    public class Booking
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookingId { get; set; }

        [DataType(DataType.Date)]
        public DateTime BookingDate { get; set; }

        [ForeignKey("Room")]
        public int RoomNo { get; set; }
        public virtual Room Room { get; set; }

        [ForeignKey("Guest")]
        public int GuestId { get; set; }
        public virtual Guest Guest { get; set; }

        // [ForeignKey("Rate")]
        public int Occupants { get; set; }
        public virtual Rate Rate { get; set; }
       
        [ForeignKey("RoomType")]
        public string RoomTypeRequested { get; set; }
        public virtual RoomType RoomType { get; set; }

        public int Nights { get; set; }

        public String ArrivalTime { get; set; }

        public virtual List<Extra> Extras { get; set; }
    }
}