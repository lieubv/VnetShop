using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VnetShop.Model.Models
{
    [Table("DevicesReport")]
    public class DevicesReport
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        public int? DeviceID { set; get; }

        public decimal? NowDistance { set; get; }
        public decimal? AllDistance { set; get; }
        public int? WarnCount { set; get; }
        public int? SpeedLimitCount { set; get; }
        public int? StopCount { set; get; }

        [MaxLength(20)]
        public string SerialNumber { set; get; }

        public DateTime? CreateTime { set; get; }
        public DateTime? UpdateTime { set; get; }
    }
}