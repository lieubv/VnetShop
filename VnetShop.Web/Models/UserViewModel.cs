using System;

namespace VnetShop.Web.Models
{
    public class UserViewModel
    {
        public int UserID { set; get; }

        public int? ParentID { set; get; }

        public string UserName { set; get; }

        public string LoginName { set; get; }

        public string Password { set; get; }

        public int? UserType { set; get; }
        public bool? Gender { set; get; }

        public string FirstName { set; get; }
        public string MiddleName { set; get; }

        public string LastName { set; get; }

        public string TimeZone { set; get; }

        public string Address1 { set; get; }

        public string Address2 { set; get; }

        public int? Country { set; get; }
        public int? State { set; get; }

        public string HomePhone { set; get; }

        public string WorkPhone { set; get; }

        public string CellPhone { set; get; }

        public string SMSEmail { set; get; }

        public string PrimaryEmail { set; get; }

        public string SecondaryEmail { set; get; }

        public int? Status { set; get; }

        public DateTime? UpdateTime { set; get; }
        public DateTime? Created { set; get; }
        public bool? Deleted { set; get; }
        public int? SuperAdmin { set; get; }
        public int? AllDeviceCount { set; get; }
        public int? ActivationCount { set; get; }

        public int? MoneyCount { set; get; }

        public string GuardianName { set; get; }

        public string GuardianPhone { set; get; }

        public int? SubUserCount { set; get; }
        public int? DeviceCount { set; get; }
        public bool? VoiceSwitch { set; get; }
    }
}