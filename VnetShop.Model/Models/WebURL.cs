using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VnetShop.Model.Models
{
    [Table("WebURL")]
    public class WebURL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // automatic increase ID
        public int ID { set; get; }

        [MaxLength(200)]
        public string URL { set; get; }

        [MaxLength(100)]
        public string LoginPage { set; get; }

        [MaxLength(500)]
        public string Logo { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }       
    }
}