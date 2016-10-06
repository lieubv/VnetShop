using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VnetShop.Model.Models
{
    [Table("ExceptionMessage")]
    public class ExceptionMessage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExceptionID { set; get; }

        [MaxLength(20)]
        public string SerialNumber { set; get; }

        public int? DeviceID { set; get; }
        public int? GeoFenceID { set; get; }
        public int? NotificationType { set; get; }

        [MaxLength(500)]
        public string Message { set; get; }

        public DateTime? Created { set; get; }
        public int? Deleted { set; get; }
        public DateTime? ClearDate { set; get; }
        public int? ClearBy { set; get; }

        [MaxLength(1000)]
        public string Note { set; get; }

        public decimal? OLat { set; get; }
        public decimal? OLng { set; get; }
        public decimal? BaiduLat { set; get; }
        public decimal? BaiduLng { set; get; }
        public decimal? Lat { set; get; }
        public decimal? Lng { set; get; }
        public int? Power { set; get; }

        [MaxLength(250)]
        public string Address { set; get; }

        public bool? AccON { set; get; }
        public bool? EngineON { set; get; }

        [MaxLength(50)]
        public string OtherStatus { set; get; }

        public int? GSM { set; get; }
        public DateTime? DeviceUTCTime { set; get; }
    }
}