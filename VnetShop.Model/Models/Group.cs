using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VnetShop.Model.Models
{
    [Table("Groups")]
    public class Group
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GroupID { set; get; }

        [MaxLength(50)]
        public string GroupName { set; get; }

        public int UserID { set; get; }

        [MaxLength(50)]
        public string Username { set; get; }

        [MaxLength(255)]
        public string Description { set; get; }

        public DateTime Created { set; get; }
        public int GroupType { set; get; }
        public int AccountID { set; get; }
        public bool Deleted { set; get; }
    }
}