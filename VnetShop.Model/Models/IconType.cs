using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VnetShop.Model.Models
{
    [Table("IconType")]
    public class IconType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Name { set; get; }

        [Column(TypeName = "varchar")]
        [MaxLength(255)]
        public string Url { set; get; }

    }
}
