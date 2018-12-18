using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using PartyInvites.Core.Storage.Auth;
using PartyInvites.Models;

namespace PartyInvites.App_Start
{
    public class AutomapperConfig
    {
        public static void Init()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<RegistrationResponse, ApplicationUser>();
            });
        }
    }
}