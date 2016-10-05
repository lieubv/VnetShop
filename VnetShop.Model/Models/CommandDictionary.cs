using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VnetShop.Model.Models
{
    [Table("CommandDictionary")]
    public class CommandDictionary
    {
        [Key]
        [MaxLength(4)]
        [Column(TypeName = "char")]
        public string CommandCode { set; get; }

        [MaxLength(50)]
        public string CommandName { set; get; }

        [MaxLength(50)]
        public string EnglishName { set; get; }

        [MaxLength(200)]
        public string Description { set; get; }

        [MaxLength(200)]
        public string EnglishDescription { set; get; }
    }
}