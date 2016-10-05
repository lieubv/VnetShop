using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VnetShop.Model.Models
{
    [Table("DeviceProtocol")]
    public class DeviceProtocol
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [MaxLength(20)]
        public string ProtocolName { set; get; }

        [MaxLength(20)]
        public string Protocol { set; get; }
    }
}