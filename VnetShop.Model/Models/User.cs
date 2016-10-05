using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VnetShop.Model.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { set; get; }

        public int ParentID { set; get; }

        [MaxLength(255)]
        public string UserName { set; get; }

        [MaxLength(255)]
        public string LoginName { set; get; }

        [MaxLength(255)]
        public string Password { set; get; }

        public int UserType { set; get; }
        public bool Gender { set; get; }

        [MaxLength(50)]
        public string FirstName { set; get; }

        [MaxLength(50)]
        public string MiddleName { set; get; }

        [MaxLength(50)]
        public string LastName { set; get; }

        [MaxLength(100)]
        public string TimeZone { set; get; }

        [MaxLength(255)]
        public string Address1 { set; get; }

        [MaxLength(255)]
        public string Address2 { set; get; }

        public int Country { set; get; }
        public int State { set; get; }

        [MaxLength(50)]
        public string HomePhone { set; get; }

        [MaxLength(50)]
        public string WorkPhone { set; get; }

        [MaxLength(50)]
        public string CellPhone { set; get; }

        [MaxLength(100)]
        public string SMSEmail { set; get; }

        [MaxLength(100)]
        public string PrimaryEmail { set; get; }

        [MaxLength(100)]
        public string SecondaryEmail { set; get; }

        public int Status { set; get; }

        public DateTime UpdateTime { set; get; }
        public DateTime Created { set; get; }
        public bool Deleted { set; get; }
        public int SuperAdmin { set; get; }
        public int AllDeviceCount { set; get; }
        public int ActivationCount { set; get; }

        public int MoneyCount { set; get; }

        [MaxLength(50)]
        public string GuardianName { set; get; }

        [MaxLength(50)]
        public string GuardianPhone { set; get; }

        public int SubUserCount { set; get; }
        public int DeviceCount { set; get; }
        public bool VoiceSwitch { set; get; }
    }
}