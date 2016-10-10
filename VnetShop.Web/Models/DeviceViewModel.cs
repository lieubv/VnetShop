using System;

namespace VnetShop.Web.Models
{
    public class DeviceViewModel
    {
        public int DeviceID { set; get; }

        public string SerialNumber { set; get; }

        public string DeviceName { set; get; }

        public string DevicePassword { set; get; }

        public string CarUserName { set; get; }

        public string CarNum { set; get; }

        public string CellPhone { set; get; }

        public int? Status { set; get; }

        public string PhoneNum { set; get; }

        public int? Model { set; get; }

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

        public string BSJIP { set; get; }

        public int? AddHireDay { set; get; }
        public int? ServerID { set; get; }

        public string AddressKey { set; get; }

        public bool? IsCn { set; get; } // is inside CHINA ?
        public int? TankModel { set; get; }

        public string Head { set; get; }

        public bool? IsFirstKey { set; get; }

        public float? StealOil { set; get; }
        public bool? IsStealOil { set; get; }

        public float? AddOil { set; get; }
        public bool? IsAddOil { set; get; }
        public float? Scope { set; get; }

        public int? Type { set; get; }

        public string AddressKeyTow { set; get; }

        public string AddressKeyThree { set; get; }

        public int? LastKeyIndex { set; get; }
        public bool? IsLocation { set; get; }
        public DateTime? SalesTime { set; get; }

        public string ContractNumber { set; get; }

        public string Lessee { set; get; }
    }
}