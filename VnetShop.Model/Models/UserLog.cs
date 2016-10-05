using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VnetShop.Model.Models
{
    [Table("UserLog")]
    public class UserLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserLogID { set; get; }

        public int UserID { set; get; }
        public DateTime LoginTime { set; get; }

        [MaxLength(15)]
        public string IPAddress { set; get; }
    }
}