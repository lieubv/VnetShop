using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VnetShop.Model.Models;
using VnetShop.Web.Models;

namespace VnetShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<User, UserViewModel>();
            Mapper.CreateMap<Device, DeviceViewModel>();
        }
    }
}