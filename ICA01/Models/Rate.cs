using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ICA01.Models
{
    public class Rate
    {
        [Key][Column(Order = 0)]                  
        [ForeignKey("RoomType")]
        public string RoomTypeId { get; set; }
        public virtual RoomType RoomType { get; set; }

        [Key][Column(Order = 1)]
        public int Occupancy { get; set; }
        public int Amount { get; set; }
    }
}