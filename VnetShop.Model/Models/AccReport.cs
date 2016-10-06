using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VnetShop.Model.Models
{
    [Table("AccReport")]
    public class AccReport
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        public int? DeviceID { set; get; }
        public DateTime? StartTime { set; get; }
        public DateTime? EndTime { set; get; }
        public DateTime? CreateTime { set; get; }
        public int? TypeID { set; get; }
        public int? timeDiffMinute { set; get; }
    }
}