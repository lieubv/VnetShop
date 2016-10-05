using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VnetShop.Model.Models
{
    [Table("LKLocation")]
    public class LKLocation
    {
        [Required]
        public int LocationID { set; get; }

        public DateTime LastCommunication { set; get; }
        public DateTime ServerUtcDate { set; get; }
        public DateTime DeviceUtcDate { set; get; }
        public DateTime StopStartUtcDate { set; get; }
        public decimal Latitude { set; get; }
        public decimal Longitude { set; get; }
        public decimal BaiduLat { set; get; }
        public decimal BaiduLng { set; get; }
        [MaxLength(500)]
        public string Address { set; get; }
        public decimal Speed { set; get; }
        public decimal Course { set; get; }
        [MaxLength(20)]
        public string SerialNumber { set; get; }

        [Key]
        public int DeviceID { set; get; }
        public int DataType { set; get; }
        [MaxLength(500)]
        public string DataContext { set; get; }
        public int Status { set; get; }
        public DateTime SOSTime { set; get; }
        public DateTime ExceptionTime { set; get; }
        public decimal Distance { set; get; }
        public decimal OLat { set; get; }
        public decimal OLng { set; get; }
        public int IsStop { set; get; }
        public int IsOffline { set; get; }
        public int Exception { set; get; }
        public int CarStatus { set; get; }
        public bool IsValid { set; get; }

        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string DeviceAINFLS { set; get; }
    }
}