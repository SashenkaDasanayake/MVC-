using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ICA01.Models
{
    public class RoomType
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public String Id { get; set; }
        public String description { get; set; }
    }
}