using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VnetShop.Model.Models
{
    [Table("CarCommandQueue")]
    public class CarCommandQueue
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(50)]
        public string DeviceID { set; get; }

        [Required]
        [MaxLength(200)]
        public string CommandText { set; get; }

        [Required]
        public DateTime? CreateDate { set; get; }

        [Required]
        public bool? IsSend { set; get; }

        [Required]
        public DateTime? SendDate { set; get; }

        public bool? IsResponse { set; get; }
        public DateTime? ResponseDate { set; get; }

        [MaxLength(500)]
        public string ResponseText { set; get; }

        [MaxLength(200)]
        public string CommandName { set; get; }

        public bool? IsOfflineSend { set; get; }

        [MaxLength(500)]
        public string Infos { set; get; }
    }
}