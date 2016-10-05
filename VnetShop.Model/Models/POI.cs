using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VnetShop.Model.Models
{
    [Table("POI")]
    public class POI
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { set; get; }

        public decimal lat { set; get; }
        public decimal lng { set; get; }

        [MaxLength(50)]
        public string name { set; get; }

        public int userID { set; get; }
        public DateTime created { set; get; }
    }
}