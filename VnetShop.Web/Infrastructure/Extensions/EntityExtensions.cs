using VnetShop.Model.Models;
using VnetShop.Web.Models;

namespace VnetShop.Web.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdateUser(this User user, UserViewModel userVm)
        {
            user.UserID = userVm.UserID;
            user.UserName = userVm.UserName;
            user.ParentID = userVm.ParentID;
            user.LoginName = userVm.LoginName;
            user.PrimaryEmail = userVm.PrimaryEmail;
            user.CellPhone = userVm.CellPhone;
            user.Address1 = userVm.Address1;
            user.Status = userVm.Status;

            user.Created = user.Created;
            user.UpdateTime = user.UpdateTime;
            user.DeviceCount = userVm.DeviceCount;
            // update more properites
        }
    }
}