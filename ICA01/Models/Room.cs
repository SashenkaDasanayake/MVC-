using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ICA01.Models
{
    public class Room
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [ForeignKey("RoomType")]
        public string RoomTypeId { get; set; }
        public virtual RoomType RoomType { get; set; }
        public int MaxOccupancy { get; set; }
    }
}