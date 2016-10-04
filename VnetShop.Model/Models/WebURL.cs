using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VnetShop.Model.Models
{
    [Table("WebURL")]
    internal class WebURL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // automatic increase ID
        public int ID { set; get; }

        public string URL { set; get; }

        public string LoginPage { set; get; }

        public string Logo { set; get; }

        public string Description { set; get; }
    }
}