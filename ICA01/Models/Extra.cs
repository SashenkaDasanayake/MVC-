using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ICA01.Models
{
    public class Extra
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int  ExtraId { get; set; }

        [ForeignKey("Booking")]
        public int BookingId { get; set; }
        public virtual Booking Booking { get; set; }
        public String Description { get; set; }
        public double Amount { get; set; }
    } 
}