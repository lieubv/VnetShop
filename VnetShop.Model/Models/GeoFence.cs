using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VnetShop.Model.Models
{
    [Table("GeoFence")]
    public class GeoFence
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GeofenceID { set; get; }

        [MaxLength(50)]
        public string FenceName { set; get; }

        public decimal? Latitude { set; get; }
        public decimal? Longitude { set; get; }
        public bool? Entry { set; get; }
        public bool? Exit { set; get; }
        public decimal? Radius { set; get; }
        public int? IsInclusion { set; get; }
        public DateTime? Created { set; get; }
        public bool? Deleted { set; get; }
        public decimal? Lat1 { set; get; }
        public decimal? Lng1 { set; get; }
        public int? FenceType { set; get; }
        public decimal? Width { set; get; }
        public int? UserID { set; get; }
        public int? DeviceID { set; get; }

        [MaxLength(255)]
        public string Description { set; get; }

        public DateTime? StartTime { set; get; }
        public DateTime? EndTime { set; get; }
    }
}