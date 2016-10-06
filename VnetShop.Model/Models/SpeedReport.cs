using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VnetShop.Model.Models
{
    [Table("SpeedReport")]
    public class SpeedReport
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SID { set; get; }

        public int? DeviceID { set; get; }

        [MaxLength(20)]
        public string SerialNumber { set; get; }

        public int? TypeID { set; get; }
        public DateTime? StartTime { set; get; }
        public DateTime? EndTime { set; get; }
        public DateTime? CreateTime { set; get; }
        public decimal? OLat { set; get; }
        public decimal? OLng { set; get; }
        public decimal? Latitude { set; get; }
        public decimal? Longitude { set; get; }

        [MaxLength(500)]
        public string Address { set; get; }

        public DateTime? UpdateTime { set; get; }
        public bool? Status { set; get; }
        public float? TimediffMinute { set; get; }
        public decimal? SpeedLimit { set; get; }
    }
}