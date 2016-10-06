using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VnetShop.Model.Models
{
    [Table("Devices")]
    public class Device
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DeviceID { set; get; }

        [MaxLength(20)]
        public string SerialNumber { set; get; }

        [MaxLength(100)]
        public string DeviceName { set; get; }

        [MaxLength(50)]
        public string DevicePassword { set; get; }

        [MaxLength(50)]
        public string CarUserName { set; get; }

        [MaxLength(50)]
        public string CarNum { set; get; }

        [MaxLength(50)]
        public string CellPhone { set; get; }

        public int? Status { set; get; }

        [MaxLength(50)]
        public string PhoneNum { set; get; }

        public int? Model { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        public DateTime? Created { set; get; }
        public bool? Deleted { set; get; }
        public DateTime? ActiveDate { set; get; }
        public DateTime? HireStartDate { set; get; }
        public DateTime? HireExpireDate { set; get; }
        public decimal? SpeedLimit { set; get; }
        public int? UserID { set; get; }
        public int? GroupID { set; get; }
        public int? Icon { set; get; }

        public float? OILCoefficient { set; get; }

        [MaxLength(50)]
        public string BSJIP { set; get; }

        public int? AddHireDay { set; get; }
        public int? ServerID { set; get; }

        [MaxLength(50)]
        public string AddressKey { set; get; }

        public bool? IsCn { set; get; } // is inside CHINA ?
        public int? TankModel { set; get; }

        [MaxLength(100)]
        [Column(TypeName = "varchar")]
        public string Head { set; get; }

        public bool? IsFirstKey { set; get; }

        public float? StealOil { set; get; }
        public bool? IsStealOil { set; get; }

        public float? AddOil { set; get; }
        public bool? IsAddOil { set; get; }
        public float? Scope { set; get; }

        public int? Type { set; get; }

        [MaxLength(50)]
        public string AddressKeyTow { set; get; }

        [MaxLength(50)]
        public string AddressKeyThree { set; get; }

        public int? LastKeyIndex { set; get; }
        public bool? IsLocation { set; get; }
        public DateTime? SalesTime { set; get; }

        [MaxLength(500)]
        public string ContractNumber { set; get; }

        [MaxLength(50)]
        public string Lessee { set; get; }
    }
}